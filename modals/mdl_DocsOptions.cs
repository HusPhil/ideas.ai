using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IdeasAi.modals
{
    public partial class mdl_DocsOptions : Form
    {
        private string oldTitle;
        int confirm_count = 0;
        public Guid obj_id;
        public string current_title;
        private MainForm mainForm;

        public mdl_DocsOptions(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
        private void mdl_DocsOptions_Load(object sender, EventArgs e)
        {
            
            txb_setNoteTitle.Text = mainForm.frm_notebook.saver_obj.Title;
            oldTitle = txb_setNoteTitle.Text;
            var ownerForm = mainForm;
            this.Location = ModalManager.CenterLocation(ownerForm.Width, ownerForm.Height, this.Width, this.Height, ownerForm.Location.X, ownerForm.Location.Y);

            txb_setNoteTitle.SelectionStart = txb_setNoteTitle.Text.Length; ;
            txb_setNoteTitle.SelectionLength = 0;
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
            mainForm.dbManager_Docs.modifyField(mainForm.frm_notebook.saver_obj.UUID, "Title", txb_setNoteTitle.Text);

            if (!txb_setNoteTitle.Text.Equals(oldTitle))
            {
                mainForm.dbManager_Docs.modifyField(mainForm.frm_notebook.saver_obj.UUID, "Date_modified", DateTime.Now);
                mainForm.addNotification("success", "Successfully saved!", txb_setNoteTitle.Text);
            }

            mainForm.frm_notebook.displaySavedIdeas(mainForm.dbManager_Docs);
            mainForm.Focus();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            confirm_count++;

            if (confirm_count == 2)
            {
                mainForm.dbManager_Docs.deleteRecord(mainForm.frm_notebook.saver_obj.UUID);
                confirm_count = 0;
                btn_delete.Text = "Delete";
                mainForm.frm_notebook.displaySavedIdeas(mainForm.dbManager_Docs);

                this.Visible = false;
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
    }
}
