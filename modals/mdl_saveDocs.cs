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
    public partial class mdl_saveDocs : Form
    {
        MainForm mainForm;
        public mdl_saveDocs(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
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

        private void frm_modal_Load(object sender, EventArgs e)
        {
            txb_setNoteTitle.Text = mainForm.frm_workspace.title_holder;
            var ownerForm = mainForm;
            this.Location = ModalSetter.CenterLocation(ownerForm.Width, ownerForm.Height, this.Width, this.Height, ownerForm.Location.X, ownerForm.Location.Y);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
