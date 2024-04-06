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
using System.Web;
using System.Windows.Forms;

namespace IdeasAi.modals
{
    public partial class mdl_NotesOptions : Form
    {
        int confirm_count = 0;
        public MainForm mainForm;
        public Guid obj_id;
        public string current_title;
        private string oldTitle;
        public mdl_NotesOptions(MainForm _mainForm)
        {
            this.mainForm = _mainForm;
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            txb_setNoteTitle.Text = mainForm.frm_notebook.current_title;
            oldTitle = txb_setNoteTitle.Text;
            var ownerForm = mainForm;
            this.Location = ModalSetter.CenterLocation(ownerForm.Width, ownerForm.Height, this.Width, this.Height, ownerForm.Location.X, ownerForm.Location.Y);
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
            

            mainForm.dbManager_Note.modifyField(mainForm.frm_notebook.current_id, "Title", txb_setNoteTitle.Text);

            if (!txb_setNoteTitle.Text.Equals(oldTitle))
            {
                mainForm.dbManager_Note.modifyField(mainForm.frm_notebook.current_id, "Date_modified", DateTime.Now);
            }
            
            mainForm.frm_notebook.displaySavedIdeas(mainForm.dbManager_Note);
            mainForm.Focus();

        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            confirm_count++;

            if(confirm_count == 2)
            {
                mainForm.dbManager_Note.deleteRecord(mainForm.frm_notebook.current_id);
                confirm_count = 0;
                btn_delete.Text = "Delete";
                mainForm.frm_notebook.displaySavedIdeas(mainForm.dbManager_Note);

                this.Visible = false ;
                mainForm.Focus();
            }

            btn_delete.Text = "Click again to confirm";
        }
        private void txb_setNoteTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Call your save method here
                btn_save_Click(sender, e);

                // Prevent the default behavior (e.g., beep sound)
                e.SuppressKeyPress = true;
                Hide();
            }
        }

        //GETTERS
        public ref KryptonTextBox getTxbTitle()
        {
            return ref txb_setNoteTitle;
        }
    }
}
