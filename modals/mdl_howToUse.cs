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
        public mdl_howToUse(MainForm mainForm, string title, string content)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            lbl_title.Text = title;
            lbl_content.Text = content;
        }
        

        private void mdl_howToUse_Load(object sender, EventArgs e)
        {
            var ownerForm = mainForm;
            this.Location = ModalManager.CenterLocation(ownerForm.Width, ownerForm.Height, this.Width, this.Height, ownerForm.Location.X, ownerForm.Location.Y);

            var size = TextRenderer.MeasureText(lbl_content.Text, lbl_content.Font);
            lbl_content.Size = new Size(size.Width, size.Height + 150);
           

        }

        private void btn_okay_Click(object sender, EventArgs e)
        {
            mainForm.modalBG.Hide();
            this.Close();
        }

        private void lbl_content_Click(object sender, EventArgs e)
        {

        }
    }
}
