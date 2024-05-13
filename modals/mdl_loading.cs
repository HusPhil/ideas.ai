using IdeasAi.ai_responses;
using IdeasAi.PageForms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeasAi.modals
{
    public partial class mdl_loading : Form
    {
        MainForm mainForm;
        frm_consultation senderForm;
        public int state;

        public mdl_loading(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        public mdl_loading(MainForm mainForm, frm_consultation sender)
        {
            this.mainForm = mainForm;
            this.senderForm = sender;
            
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void mdl_loading_Load(object sender, EventArgs e)
        {
            var ownerForm = mainForm;

            this.Location = ModalManager.CenterLocation(ownerForm.Width, ownerForm.Height, this.Width, this.Height, ownerForm.Location.X, ownerForm.Location.Y);
            this.BringToFront();

            switch (state)
            {
                case MainForm.state_loadMindmap:
                    mainForm.frm_workspace.loadMindmap();
                    break;
                case MainForm.state_loadConsultation:
                    this.senderForm.loadConsultation(this);
                    break;
            }
        }

        //GETTERS
        public ref Label getLblLoadInfo()
        {
            return ref lbl_loadingInfo;
        }

        
    }
}
