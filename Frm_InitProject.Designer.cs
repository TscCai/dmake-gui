namespace dmake.GUI
{
    partial class Frm_InitProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InitProject));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("调继55号文，IV级");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("调继55号文，V级");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("调自，IV级");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("调自，V级");
            this.radioGrp_TicketType = new Sunny.UI.UIRadioButtonGroup();
            this.chkGrp_OtherOptions = new Sunny.UI.UICheckBoxGroup();
            this.btn_OK = new Sunny.UI.UIButton();
            this.btn_Cancel = new Sunny.UI.UIButton();
            this.chkGrp_WorkType = new Sunny.UI.UICheckBoxGroup();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cb_WorkRisk = new Sunny.UI.UIComboBox();
            this.cb_RiskStandard = new Sunny.UI.UIComboTreeView();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txt_WorkContent = new Sunny.UI.UITextBox();
            this.txt_Substation = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // radioGrp_TicketType
            // 
            this.radioGrp_TicketType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioGrp_TicketType.Items.AddRange(new object[] {
            "第一种工作票",
            "第二种工作票",
            "应急抢修单"});
            this.radioGrp_TicketType.Location = new System.Drawing.Point(23, 40);
            this.radioGrp_TicketType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioGrp_TicketType.MinimumSize = new System.Drawing.Size(1, 1);
            this.radioGrp_TicketType.Name = "radioGrp_TicketType";
            this.radioGrp_TicketType.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.radioGrp_TicketType.Size = new System.Drawing.Size(294, 171);
            this.radioGrp_TicketType.TabIndex = 2;
            this.radioGrp_TicketType.Text = "工作票类别(*)";
            this.radioGrp_TicketType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkGrp_OtherOptions
            // 
            this.chkGrp_OtherOptions.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkGrp_OtherOptions.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.chkGrp_OtherOptions.Items.AddRange(new object[] {
            "标准卡（旧版）",
            "标准卡（省调版）",
            "电力监控票",
            "信息安全告知书",
            "动火工作票",
            "有限空间作业方案"});
            this.chkGrp_OtherOptions.Location = new System.Drawing.Point(23, 227);
            this.chkGrp_OtherOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkGrp_OtherOptions.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkGrp_OtherOptions.Name = "chkGrp_OtherOptions";
            this.chkGrp_OtherOptions.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.chkGrp_OtherOptions.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("chkGrp_OtherOptions.SelectedIndexes")));
            this.chkGrp_OtherOptions.Size = new System.Drawing.Size(294, 246);
            this.chkGrp_OtherOptions.TabIndex = 3;
            this.chkGrp_OtherOptions.Text = "其他纸质材料";
            this.chkGrp_OtherOptions.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_OK
            // 
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(198, 489);
            this.btn_OK.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(137, 35);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "确定";
            this.btn_OK.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(502, 489);
            this.btn_Cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(137, 35);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // chkGrp_WorkType
            // 
            this.chkGrp_WorkType.ColumnCount = 2;
            this.chkGrp_WorkType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkGrp_WorkType.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.chkGrp_WorkType.Items.AddRange(new object[] {
            "装置插件更换、消缺",
            "远动装置点表下装",
            "网监装置工作",
            "调度数据网工作",
            "屏柜拆除、新立",
            "需投、退压板",
            "含同屏运行设备",
            "多屏柜工作"});
            this.chkGrp_WorkType.ItemSize = new System.Drawing.Size(220, 29);
            this.chkGrp_WorkType.Location = new System.Drawing.Point(337, 227);
            this.chkGrp_WorkType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkGrp_WorkType.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkGrp_WorkType.Name = "chkGrp_WorkType";
            this.chkGrp_WorkType.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.chkGrp_WorkType.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("chkGrp_WorkType.SelectedIndexes")));
            this.chkGrp_WorkType.Size = new System.Drawing.Size(463, 246);
            this.chkGrp_WorkType.TabIndex = 5;
            this.chkGrp_WorkType.Text = "工作类型选择";
            this.chkGrp_WorkType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(342, 142);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(122, 23);
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "作业风险(*)：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_WorkRisk
            // 
            this.cb_WorkRisk.DataSource = null;
            this.cb_WorkRisk.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cb_WorkRisk.FillColor = System.Drawing.Color.White;
            this.cb_WorkRisk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_WorkRisk.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cb_WorkRisk.Items.AddRange(new object[] {
            "III级",
            "IV级",
            "V级"});
            this.cb_WorkRisk.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cb_WorkRisk.Location = new System.Drawing.Point(458, 140);
            this.cb_WorkRisk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_WorkRisk.MinimumSize = new System.Drawing.Size(63, 0);
            this.cb_WorkRisk.Name = "cb_WorkRisk";
            this.cb_WorkRisk.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cb_WorkRisk.Size = new System.Drawing.Size(342, 29);
            this.cb_WorkRisk.TabIndex = 7;
            this.cb_WorkRisk.Text = "--请选择--";
            this.cb_WorkRisk.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_WorkRisk.Watermark = "";
            // 
            // cb_RiskStandard
            // 
            this.cb_RiskStandard.CheckBoxes = true;
            this.cb_RiskStandard.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cb_RiskStandard.FillColor = System.Drawing.Color.White;
            this.cb_RiskStandard.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_RiskStandard.Location = new System.Drawing.Point(458, 182);
            this.cb_RiskStandard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_RiskStandard.MinimumSize = new System.Drawing.Size(63, 0);
            this.cb_RiskStandard.Name = "cb_RiskStandard";
            treeNode1.Name = "relay_ClassIV";
            treeNode1.Text = "调继55号文，IV级";
            treeNode2.Name = "relay_ClassV";
            treeNode2.Text = "调继55号文，V级";
            treeNode3.Name = "auto_ClassIV";
            treeNode3.Text = "调自，IV级";
            treeNode4.Name = "auto_ClassV";
            treeNode4.Text = "调自，V级";
            this.cb_RiskStandard.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.cb_RiskStandard.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cb_RiskStandard.ShowClearButton = true;
            this.cb_RiskStandard.ShowLines = true;
            this.cb_RiskStandard.Size = new System.Drawing.Size(342, 29);
            this.cb_RiskStandard.TabIndex = 8;
            this.cb_RiskStandard.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_RiskStandard.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(342, 187);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(117, 23);
            this.uiLabel2.TabIndex = 9;
            this.uiLabel2.Text = "定级依据(*)：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(342, 97);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(122, 30);
            this.uiLabel3.TabIndex = 6;
            this.uiLabel3.Text = "作业名称(*)：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_WorkContent
            // 
            this.txt_WorkContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_WorkContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_WorkContent.Location = new System.Drawing.Point(458, 98);
            this.txt_WorkContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_WorkContent.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_WorkContent.Name = "txt_WorkContent";
            this.txt_WorkContent.Padding = new System.Windows.Forms.Padding(5);
            this.txt_WorkContent.ShowText = false;
            this.txt_WorkContent.Size = new System.Drawing.Size(342, 29);
            this.txt_WorkContent.TabIndex = 10;
            this.txt_WorkContent.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_WorkContent.Watermark = "";
            // 
            // txt_Substation
            // 
            this.txt_Substation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Substation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Substation.Location = new System.Drawing.Point(458, 50);
            this.txt_Substation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Substation.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Substation.Name = "txt_Substation";
            this.txt_Substation.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Substation.ShowText = false;
            this.txt_Substation.Size = new System.Drawing.Size(342, 29);
            this.txt_Substation.TabIndex = 12;
            this.txt_Substation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Substation.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(342, 49);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(122, 30);
            this.uiLabel4.TabIndex = 11;
            this.uiLabel4.Text = "变电站名称(*)：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_InitProject
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(820, 545);
            this.Controls.Add(this.txt_Substation);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.cb_WorkRisk);
            this.Controls.Add(this.cb_RiskStandard);
            this.Controls.Add(this.txt_WorkContent);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.chkGrp_WorkType);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.chkGrp_OtherOptions);
            this.Controls.Add(this.radioGrp_TicketType);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_InitProject";
            this.Text = "初始化DMake工程";
            this.TitleFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 480);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIRadioButtonGroup radioGrp_TicketType;
        private Sunny.UI.UICheckBoxGroup chkGrp_OtherOptions;
        private Sunny.UI.UIButton btn_OK;
        private Sunny.UI.UIButton btn_Cancel;
        private Sunny.UI.UICheckBoxGroup chkGrp_WorkType;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cb_WorkRisk;
        private Sunny.UI.UIComboTreeView cb_RiskStandard;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txt_WorkContent;
        private Sunny.UI.UITextBox txt_Substation;
        private Sunny.UI.UILabel uiLabel4;
    }
}