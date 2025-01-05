using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;

namespace dmake.GUI
{
    public partial class Frm_InitProject : UIForm
    {
        public delegate void ProjectInitEventHandler(object sender, ProjectInitArgs e);
        public event ProjectInitEventHandler ProjectInitChoosed;

        public Frm_InitProject() {
            InitializeComponent();
            radioGrp_TicketType.SelectedIndex = 1;
            cb_WorkRisk.SelectedIndex = 1;

        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e) {
            // Check all options are valid.
            if (!isInitChoiceValid()) {
                this.ShowErrorDialog("必选项未选");
                return;
            }


            int ticketTypeIndex = radioGrp_TicketType.SelectedIndex;
            string ticketType = ticketTypeIndex > 0 ? radioGrp_TicketType.Items[ticketTypeIndex].ToString() : "";
            List<string> extraPapers = chkGrp_OtherOptions.SelectedItems.ConvertAll(item => item.ToString());


            string workRisk = cb_WorkRisk.SelectedText;
            List<string> riskStandard = cb_RiskStandard.Text.Split(";").Where(i => i.Trim() != "").ToList();

            string workContent = txt_WorkContent.Text;
            string substation = txt_Substation.Text;
            var args = new ProjectInitArgs(ticketType, substation, workContent, workRisk, extraPapers, riskStandard);

            ProjectInitChoosed?.Invoke(this, args);
            this.Close();


        }
        private bool isInitChoiceValid() {
            return cb_RiskStandard.Text != "" && txt_WorkContent.Text != "" && txt_Substation.Text != "";
        }
    }

    public class ProjectInitArgs
    {
        public string TicketType { get; private set; }
        public string RiskLevel { get; private set; }
        public string WorkContent { get; private set; }
        public string Substation { get; private set; }
        public List<string> ExtraPapers { get; private set; }
        public List<string> RiskStandard { get; private set; }

        public ProjectInitArgs(string ticketType, string substation, string workContent, string riskLevel, List<string> extraPapers, List<string> riskStandard) {
            WorkContent = workContent;
            Substation = substation;
            TicketType = ticketType;
            RiskLevel = riskLevel;
            ExtraPapers = extraPapers;
            RiskStandard = riskStandard;
        }
    }
}
