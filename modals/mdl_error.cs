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
    public partial class mdl_error : Form
    {
        MainForm mainForm;
        public mdl_error(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btn_okay_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.modalBG.Hide();
        }

        private void mdl_error_Load(object sender, EventArgs e)
        {
            
            var ownerForm = mainForm;
            this.Location = ModalSetter.CenterLocation(ownerForm.Width, ownerForm.Height, this.Width, this.Height, ownerForm.Location.X, ownerForm.Location.Y);
            BringToFront();
        }
    }
}
