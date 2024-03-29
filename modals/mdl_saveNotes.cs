using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using IdeasAi.db;
using IdeasAi.Ideas;

namespace IdeasAi.modals
{
    public partial class mdl_saveNotes : Form
    {
        public MainForm mainForm;
        public mdl_saveNotes(MainForm _mainForm)
        {
            InitializeComponent();
            this.mainForm = _mainForm;


        }
        private void tmr_animation_Tick(object sender, EventArgs e)
        {
            if(Opacity >= 1)
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
            txb_setNoteTitle.Text = mainForm.frm_home.input_holder;
            var ownerForm = mainForm;
            this.Location = ModalSetter.CenterLocation(ownerForm.Width, ownerForm.Height, this.Width, this.Height, ownerForm.Location.X, ownerForm.Location.Y);
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            
            var idea_save_obj = new DBObjectManager();
            idea_save_obj.UUID = mainForm.frm_home.id_holder;
            idea_save_obj.Title = txb_setNoteTitle.Text;
            idea_save_obj.Input = mainForm.frm_home.input_holder;
            idea_save_obj.Content = mainForm.frm_home.content_holder;
            idea_save_obj.DateCreated = mainForm.frm_home.date_holder;

            mainForm.dbManager_Note.SaveObject(idea_save_obj);

            mainForm.loadForm(mainForm.frm_notebook,mainForm.getPnlContent());
            mainForm.setActiveBtn(mainForm.getBtnNotebook(), mainForm.getPnlPageTabs());
            mainForm.frm_notebook.displaySavedIdeas(mainForm.dbManager_Note);

            // Load the notebook form into the content panel
            mainForm.BringToFront();
            this.Hide();

        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Owner.BringToFront();
            this.Hide();
        }

    }
}
