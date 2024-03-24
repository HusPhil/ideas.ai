using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeasAi.modals
{
    public partial class mdl_editNotes : Form
    {
        int confirm_count = 0;
        public MainForm mainForm;
        public Guid obj_id;
        public string current_title;
        public mdl_editNotes(MainForm _mainForm)
        {
            this.mainForm = _mainForm;
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            txb_setNoteTitle.Text = mainForm.frm_notebook.current_title;
            var ownerForm = mainForm;
            this.Location = ModalSetter.CenterLocation(ownerForm.Width, ownerForm.Height, this.Width, this.Height, ownerForm.Location.X, ownerForm.Location.Y);
        }

        //GETTERS
        public ref KryptonTextBox getTxbTitle()
        {
            return ref txb_setNoteTitle;
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
        private void btn_save_Click(object sender, EventArgs e)
        {
            mainForm.dbManager_Idea.modifyField(mainForm.frm_notebook.current_id, "Title", txb_setNoteTitle.Text);
            mainForm.frm_notebook.displaySavedIdeas();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            confirm_count++;

            if(confirm_count == 2)
            {
                mainForm.dbManager_Idea.deleteRecord(mainForm.frm_notebook.current_id);
                confirm_count = 0;
                btn_delete.Text = "Delete";
                mainForm.frm_notebook.displaySavedIdeas();
                this.Hide();
            }

            btn_delete.Text = "Click again to confirm.";
        }
    }
}
