using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeasAi.modals
{
    public partial class mdl_howToUse : Form
    {
        MainForm mainForm;
        public mdl_howToUse(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
        private void tmr_animation_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                tmr_animation.Stop();
            }
            else
            {
                Opacity += .05;
            }
        }

        private void mdl_howToUse_Load(object sender, EventArgs e)
        {
            var ownerForm = mainForm;
            this.Location = ModalSetter.CenterLocation(ownerForm.Width, ownerForm.Height, this.Width, this.Height, ownerForm.Location.X, ownerForm.Location.Y);

            var currentActivBtn = mainForm.btn_active.Text;
            
            if(currentActivBtn == mainForm.getBtnHome().Text)
            {
                lbl_content.Text = "This is how to use the home";
            }
            else if (currentActivBtn == mainForm.getBtnNotebook().Text)
            {
                lbl_content.Text = "This is how to use the notebook";

            }
            else if (currentActivBtn == mainForm.getBtnWorkspace().Text)
            {
                lbl_content.Text = "This is how to use the workspace";

            }
            else if (currentActivBtn == mainForm.getBtnMindmap().Text)
            {
                lbl_content.Text = "This is how to use the mindmap";

            }
            else if (currentActivBtn == mainForm.getBtnConsult().Text)
            {
                lbl_content.Text = "This is how to use the consult";

            }


        }

        private void btn_okay_Click(object sender, EventArgs e)
        {
            mainForm.modalBG.Hide();
            this.Close();
        }
    }
}
