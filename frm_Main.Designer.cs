namespace dmake.GUI
{
    partial class frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.btn_Init = new Sunny.UI.UIButton();
            this.StyleManager = new Sunny.UI.UIStyleManager(this.components);
            this.btn_Build = new Sunny.UI.UISymbolButton();
            this.lbl_Status = new Sunny.UI.UILabel();
            this.tab_Control = new Sunny.UI.UITabControl();
            this.btn_OpenExistProj = new Sunny.UI.UIButton();
            this.btn_Save = new Sunny.UI.UISymbolButton();
            this.toolTip = new Sunny.UI.UIToolTip(this.components);
            this.btn_OpenAppData = new Sunny.UI.UISymbolButton();
            this.ctxMenu = new Sunny.UI.UIContextMenuStrip();
            this.menuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ImportImage = new Sunny.UI.UISymbolButton();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Init
            // 
            this.btn_Init.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Init.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Init.Location = new System.Drawing.Point(258, 50);
            this.btn_Init.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Init.Name = "btn_Init";
            this.btn_Init.Size = new System.Drawing.Size(212, 42);
            this.btn_Init.TabIndex = 2;
            this.btn_Init.Text = "初始化工程";
            this.btn_Init.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Init.Click += new System.EventHandler(this.btn_Init_Click);
            // 
            // StyleManager
            // 
            this.StyleManager.DPIScale = true;
            this.StyleManager.GlobalFontName = "微软雅黑";
            // 
            // btn_Build
            // 
            this.btn_Build.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Build.Enabled = false;
            this.btn_Build.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Build.Location = new System.Drawing.Point(563, 628);
            this.btn_Build.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Build.Name = "btn_Build";
            this.btn_Build.Size = new System.Drawing.Size(212, 42);
            this.btn_Build.TabIndex = 4;
            this.btn_Build.Text = "构建工程";
            this.btn_Build.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Build.Click += new System.EventHandler(this.btn_Build_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Status.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_Status.Location = new System.Drawing.Point(0, 673);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Padding = new System.Windows.Forms.Padding(10, 0, 0, 5);
            this.lbl_Status.Size = new System.Drawing.Size(1024, 27);
            this.lbl_Status.TabIndex = 5;
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab_Control
            // 
            this.tab_Control.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tab_Control.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_Control.ItemSize = new System.Drawing.Size(150, 40);
            this.tab_Control.Location = new System.Drawing.Point(3, 106);
            this.tab_Control.MainPage = "";
            this.tab_Control.Name = "tab_Control";
            this.tab_Control.SelectedIndex = 0;
            this.tab_Control.Size = new System.Drawing.Size(1018, 506);
            this.tab_Control.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_Control.TabIndex = 6;
            this.tab_Control.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_Control.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_Control_Selected);
            // 
            // btn_OpenExistProj
            // 
            this.btn_OpenExistProj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenExistProj.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenExistProj.Location = new System.Drawing.Point(563, 50);
            this.btn_OpenExistProj.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_OpenExistProj.Name = "btn_OpenExistProj";
            this.btn_OpenExistProj.Size = new System.Drawing.Size(212, 42);
            this.btn_OpenExistProj.TabIndex = 2;
            this.btn_OpenExistProj.Text = "打开已有工程";
            this.btn_OpenExistProj.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenExistProj.Click += new System.EventHandler(this.btn_OpenExistProj_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Save.Location = new System.Drawing.Point(258, 628);
            this.btn_Save.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(212, 42);
            this.btn_Save.Symbol = 61639;
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "保存工程";
            this.btn_Save.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.toolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.toolTip.OwnerDraw = true;
            // 
            // btn_OpenAppData
            // 
            this.btn_OpenAppData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenAppData.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenAppData.Location = new System.Drawing.Point(946, 57);
            this.btn_OpenAppData.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_OpenAppData.Name = "btn_OpenAppData";
            this.btn_OpenAppData.Size = new System.Drawing.Size(55, 35);
            this.btn_OpenAppData.Symbol = 61564;
            this.btn_OpenAppData.SymbolSize = 32;
            this.btn_OpenAppData.TabIndex = 7;
            this.btn_OpenAppData.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenAppData.TipsText = "打开程序数据目录";
            this.btn_OpenAppData.Click += new System.EventHandler(this.btn_OpenAppData_Click);
            // 
            // ctxMenu
            // 
            this.ctxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ctxMenu.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctxMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_About});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(111, 26);
            // 
            // menuItem_About
            // 
            this.menuItem_About.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuItem_About.Name = "menuItem_About";
            this.menuItem_About.Size = new System.Drawing.Size(110, 22);
            this.menuItem_About.Text = "关于";
            this.menuItem_About.Click += new System.EventHandler(this.menuItem_About_Click);
            // 
            // btn_ImportImage
            // 
            this.btn_ImportImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ImportImage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ImportImage.Location = new System.Drawing.Point(866, 57);
            this.btn_ImportImage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_ImportImage.Name = "btn_ImportImage";
            this.btn_ImportImage.Size = new System.Drawing.Size(55, 35);
            this.btn_ImportImage.Symbol = 262210;
            this.btn_ImportImage.SymbolSize = 32;
            this.btn_ImportImage.TabIndex = 7;
            this.btn_ImportImage.TipsFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ImportImage.TipsText = "导入定置图";
            this.btn_ImportImage.Click += new System.EventHandler(this.btn_OpenAppData_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.btn_ImportImage);
            this.Controls.Add(this.btn_OpenAppData);
            this.Controls.Add(this.tab_Control);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Build);
            this.Controls.Add(this.btn_OpenExistProj);
            this.Controls.Add(this.btn_Init);
            this.ExtendBox = true;
            this.ExtendMenu = this.ctxMenu;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.ShowTitleIcon = true;
            this.Text = "DMake-GUI";
            this.TitleFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 480);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton btn_Init;
        private Sunny.UI.UIStyleManager StyleManager;
        private Sunny.UI.UISymbolButton btn_Build;
        private Sunny.UI.UILabel lbl_Status;
        private Sunny.UI.UITabControl tab_Control;
        private Sunny.UI.UIButton btn_OpenExistProj;
        private Sunny.UI.UISymbolButton btn_Save;
        private Sunny.UI.UIToolTip toolTip;
        private Sunny.UI.UISymbolButton btn_OpenAppData;
        private Sunny.UI.UIContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_About;
        private Sunny.UI.UISymbolButton btn_ImportImage;
    }
}

