using System;
using Newtonsoft.Json.Linq;
using Sunny.UI;
using System.IO;
using dmake.Util;
using System.Reflection;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace dmake.GUI
{
    public partial class frm_Main : UIForm
    {

        Version verGui; string strVerGui, strVerInfo;


        static string newPorjPath = AppDomain.CurrentDomain.BaseDirectory + "NewProjectTemplate";
        static string appRootPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DMake");
        static string logFilePath = Path.Combine(appRootPath, "Logs");
        string workspacePath = "";
        LogFile logger = null;
        List<UIFlowLayoutPanel> pagePanels = null;


        public frm_Main() {
            InitializeComponent();

        }

        private void frm_Main_Load(object sender, EventArgs e) {

            try {
                verGui = Assembly.GetExecutingAssembly().GetName().Version;
                strVerGui = verGui.ToString();
                strVerInfo = $"dmake-core: {AssemblyGetter.AssemblyVersion}    dmake-gui: {strVerGui}";



                logger = LoggerFactory.GetLogger(logFilePath);

                if (!Directory.Exists(appRootPath)) {
                    Directory.CreateDirectory(appRootPath);
                }
                var dirs = DirectoryHelper.EnumerateSubDirectories(newPorjPath);
                foreach (var d in dirs) {
                    if (d.Name != "individual") {
                        cb_Template.Items.Add(d.Name);
                    }
                }

                toolTip.SetToolTip(btn_OpenAppData, btn_OpenAppData.TipsText);


                logger.Debug(strVerInfo);
                logger.Debug("DMake GUI start successfully.");


            }
            catch (Exception ex) {
                UIMessageBox.ShowError(ex.Message);
                if (logger != null) {
                    logger.ErrorException(ex);
                }
            }
        }

        private void btn_Init_Click(object sender, EventArgs e) {
            if (cb_Template.SelectedItem == null) {
                UIMessageBox.ShowWarning("请选择一个已有模板。");
                return;
            }
            string source = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "NewProjectTemplate",
                cb_Template.SelectedItem.ToString()
                );
            string dest = Path.Combine(appRootPath, DateTime.Now.ToString("yyyy-MM-dd_HHmmss_") + cb_Template.SelectedItem);
            try {
                DirectoryHelper.CopyDirectory(source, dest);
                workspacePath = dest;
                LoadFromProject(dest);
                btn_Init.Enabled = false;
                btn_Build.Enabled = true;
                btn_Save.Enabled = true;
                lbl_Status.Text = "项目已初始化";

            }
            catch (Exception ex) {
                UIMessageBox.ShowError(ex.Message);
                logger.ErrorException(ex);
            }



        }

        private void btn_Build_Click(object sender, EventArgs e) {
            WriteToMarkdown(this.workspacePath);
            Make();
            if (UIMessageBox.ShowAsk("即将打开工程目录以查看生成的文档，是否继续？")) {
                System.Diagnostics.Process.Start(this.workspacePath);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e) {
            try {
                WriteToMarkdown(workspacePath);
                UIMessageBox.ShowSuccess("保存完毕。");
            }
            catch (Exception ex) {
                UIMessageBox.ShowError(ex.Message);
                logger.ErrorException(ex);
            }
        }

        private void btn_OpenAppData_Click(object sender, EventArgs e) {
            if (this.workspacePath == "") {
                System.Diagnostics.Process.Start(appRootPath);
            }
            else {
                System.Diagnostics.Process.Start(workspacePath);
            }
        }

        private void btn_OpenExistProj_Click(object sender, EventArgs e) {
            string dir = appRootPath;
            if (DirEx.SelectDirEx("选择已有的工程目录", ref dir)) {
                workspacePath = dir;
                LoadFromProject(workspacePath);
                //btn_Init.Enabled = false;
                btn_Save.Enabled = true;
                btn_Build.Enabled = true;
            }
        }

        private void tab_Control_Selected(object sender, TabControlEventArgs e) {
            if (e.TabPage != null) {
                e.TabPage.Focus();
            }

        }

        void Make() {
            if (!IsValidWorkspace(workspacePath)) {
                return;
            }
            lbl_Status.Text = "读取makefile...";

            YamlConfigure config = YamlConfigureManager.ReadMakefile(workspacePath);
            JObject jo = new JObject();
            MarkdownReader mdr = null;
            foreach (var i in config.Source) {
                mdr = new MarkdownReader(Path.Combine(workspacePath, "md", i));
                var tmp = mdr.ReadToEnd().FieldValuePairs;
                jo = mdr.MergeJson(jo, tmp);
                mdr.Dispose();
            }

            try {
                MarkdownReader.ReplaceInternalAnchor(jo);

                string result = GenDocument(config, jo);
                UIMessageBox.ShowInfo($"{result}");
            }
            catch (Exception ex) {
                UIMessageBox.ShowError(ex.Message + "构建已中止。");
                logger.ErrorException(ex);
            }

        }

        string GenDocument(YamlConfigure config, JObject source) {
            DocumentGenerator gen = new DocumentGenerator();
            int success = 0, fail = 0;
            List<string> warns = new List<string>();
            foreach (var i in config.Files) {
                try {
                    string output = Path.Combine(workspacePath, i.Key);
                    string template = Path.Combine(workspacePath, "template", i.Value);
                    FileInfo fi = new FileInfo(output);
                    if (!Directory.Exists(fi.DirectoryName)) {
                        Directory.CreateDirectory(fi.DirectoryName);
                    }

                    warns.AddRange(
                        gen.CreateDocument(template, output, source)
                    );
                    success++;
                }
                catch (Exception ex) {
                    fail++;
                    UIMessageBox.ShowError(ex.Message);
                    logger.ErrorException(ex);
                    continue;
                }

            }
            string buildResult = $"文档生成完毕，共生成 {success} 个文档，失败 {fail} 个文档。";
            if (warns.Count > 0) {
                buildResult += "生成过程中遇到如下告警：\n";
                foreach (var warn in warns) {
                    buildResult += warn + "\n";
                }
            }
            return buildResult;
        }

        void WriteToMarkdown(string workspacePath) {
            foreach (TabPage page in this.tab_Control.TabPages) {
                List<UITextBox> txts = page.GetControls<UITextBox>(true);
                List<UILabel> labels = page.GetControls<UILabel>(true);
                using (StreamWriter sw = new StreamWriter(Path.Combine(workspacePath, "md", page.Name), false, Encoding.UTF8)) {
                    for (int i = 0; i < txts.Count; i++) {
                        string key = txts[i].Name.Replace("txt_", "");
                        string field = $"### {key}[{labels[i].Text}]";
                        string value = txts[i].Text;

                        // Write to .md
                        sw.WriteLine(field);
                        sw.WriteLine(value);
                        sw.WriteLine();
                    }
                    sw.Flush();
                }
            }
        }

        bool IsValidWorkspace(string path) {
            if (!DirectoryHelper.IsDmakeDirectory(workspacePath)) {
                UIMessageBox.ShowError($"找不到makefile，请确认{workspacePath}是一个dmake项目目录。\n\n一个正确的dmake项目目录应至少同时包含md、template目录和makefile.yaml(.yml)文件");
                return false;
            }
            return true;
        }

        // TODO: Need refactor
        void LoadFromProject(string path) {
            // Enumerate all .md files
            lbl_Status.Text = "读取makefile...";
            if (!IsValidWorkspace(workspacePath)) {
                return;
            }


            YamlConfigure config = YamlConfigureManager.ReadMakefile(workspacePath);
            JObject fieldValueCollection = new JObject();
            Dictionary<string, string> fieldDescCollection = new Dictionary<string, string>();
            MarkdownReader mdr = null;

            int pageCnt = 0;
            pagePanels = new List<UIFlowLayoutPanel>(config.Source.Count);
            this.tab_Control.RemoveAllPages();
            this.tab_Control.TabPages.Clear();

            foreach (var file in config.Source) {
                mdr = new MarkdownReader(Path.Combine(workspacePath, "md", file));
                ReadResult mdContent = mdr.ReadToEnd();
                JObject fieldValuePair = mdContent.FieldValuePairs;
                //Dictionary<string, string> fieldDescPair = mdContent.FieldDescPairs;

                DrawTabPage(file, file, pageCnt);
                DrawPanelControls(pagePanels[pageCnt], mdContent);

                fieldValueCollection = mdr.MergeJson(fieldValueCollection, fieldValuePair);
                pageCnt++;
                mdr.Dispose();
            }
            try {
                MarkdownReader.ReplaceInternalAnchor(fieldValueCollection);
                // Read them one by one, extract all H3 header and its content

                lbl_Status.Text = "加载完毕";
            }
            catch (Exception ex) {
                lbl_Status.Text = "加载中遇到错误";
                UIMessageBox.ShowError(ex.Message);
                logger.ErrorException(ex);
            }

        }

        void DrawTabPage(string name, string text, int index) {
            this.tab_Control.TabPages.Add(name, text, index);

            TabPage page = tab_Control.TabPages[index];


            var pnl_left = new UIPanel();
            var pnl_right = new UIPanel();
            var pnl_top = new UIPanel();

            pnl_left.Dock = DockStyle.Left;
            pnl_right.Dock = DockStyle.Right;
            pnl_top.Dock = DockStyle.Top;

            pnl_left.Size = new System.Drawing.Size(20, 0);
            pnl_left.RectSize = 0;
            pnl_left.RectSides = ToolStripStatusLabelBorderSides.None;
            pnl_left.RadiusSides = Sunny.UI.UICornerRadiusSides.None;

            pnl_right.Size = new System.Drawing.Size(20, 0);
            pnl_right.RectSize = 0;
            pnl_right.RectSides = ToolStripStatusLabelBorderSides.None;
            pnl_right.RadiusSides = Sunny.UI.UICornerRadiusSides.None;

            pnl_top.Size = new System.Drawing.Size(0, 20);
            pnl_top.RectSides = ToolStripStatusLabelBorderSides.None;
            pnl_top.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            pnl_top.RectSize = 0;


            UIFlowLayoutPanel pnl_MainContent = new UIFlowLayoutPanel();


            // 
            // uiFlowLayoutPanel1
            // 
            pnl_MainContent.Dock = DockStyle.Fill;
            pnl_MainContent.Name = "pnl_" + name;
            pnl_MainContent.Padding = new Padding(2);
            pnl_MainContent.RadiusSides = UICornerRadiusSides.None;
            pnl_MainContent.RectSides = ToolStripStatusLabelBorderSides.Bottom;



            // Controls add to parent

            page.Controls.Add(pnl_left);
            page.Controls.Add(pnl_right);
            page.Controls.Add(pnl_top);
            page.Controls.Add(pnl_MainContent);
            pagePanels.Add(pnl_MainContent);


        }

        void DrawPanelControls(UIFlowLayoutPanel panel, ReadResult content) {
            var defaultFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            int controlWidth = panel.Width - 120;

            foreach (var item in content.FieldDescPairs) {
                // add a UILabel
                UILabel lbl_hint = new UILabel();
                lbl_hint.Dock = DockStyle.Top;
                lbl_hint.Font = defaultFont;
                lbl_hint.Text = item.Value;// content.FieldDescPairs[item.Key];
                lbl_hint.Size = new System.Drawing.Size(controlWidth, 20);
                lbl_hint.Margin = new Padding(24, 15, 4, 5);
                lbl_hint.SetDPIScale();




                UITextBox txt_field = new UITextBox();
                txt_field.Dock = DockStyle.Top;
                txt_field.Font = defaultFont;
                txt_field.Multiline = true;
                string value = content.FieldValuePairs[item.Key].ToString().Replace("|", "\r\n");
                txt_field.Text = value;
                int lines = (value.Length - value.Replace("\r\n", "").Length) / 2;
                int multifier = lines > 1 ? lines / 2 : 1;
                txt_field.Size = new System.Drawing.Size(controlWidth, 80 * multifier);
                txt_field.Name = $"txt_{item.Key}";
                txt_field.SetDPIScale();


                txt_field.Location = new System.Drawing.Point(2, 22);
                txt_field.Margin = new Padding(24, 5, 4, 5);
                txt_field.MinimumSize = new System.Drawing.Size(1, 16);
                txt_field.Padding = new System.Windows.Forms.Padding(5);

                txt_field.Click += Txt_field_Click;

                panel.Add(lbl_hint);
                panel.Add(txt_field);

                // add a UITextBox


            }
            panel.BringToFront();
            //panel.GetControls<UITextBox>(true)[0].Focus();
            panel.Focus();

        }

        private void menuItem_About_Click(object sender, EventArgs e) {

            UIMessageBox.Show(strVerInfo, "关于");
        }

        private void Txt_field_Click(object sender, EventArgs e) {
            UITextBox txt = (UITextBox)sender;
            if (!txt.Focused) { txt.Focus(); }
        }
    }
}
