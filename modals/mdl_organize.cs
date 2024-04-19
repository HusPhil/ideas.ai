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
    public partial class mdl_organize : Form
    {
        MainForm mainForm;
        public mdl_organize(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void mdl_organize_Load(object sender, EventArgs e)
        {
            var ownerForm = mainForm;
            this.Location = ModalSetter.CenterLocation(ownerForm.Width, ownerForm.Height, this.Width, this.Height, ownerForm.Location.X, ownerForm.Location.Y);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            mainForm.modalBG.Hide();
            this.Hide();
        }
    }
}
