using IdeasAi.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeasAi.modals
{
    public partial class mdl_saveDocs : Form
    {
        private MainForm mainForm;
        private DBObjectManager saver_obj;
        public mdl_saveDocs(MainForm mainForm) 
        {
            InitializeComponent();
            this.mainForm = mainForm;
            saver_obj = new DBObjectManager();

            this.tmr_animation.Enabled = true;
            this.tmr_animation.Interval = 1;
            this.tmr_animation.Tick += new System.EventHandler(this.tmr_animation_Tick);
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
            var ownerForm = mainForm;
            this.Location = ModalSetter.CenterLocation(ownerForm.Width, ownerForm.Height, this.Width, this.Height, ownerForm.Location.X, ownerForm.Location.Y);

            txb_setNoteTitle.Text = mainForm.frm_workspace.getSaverObj().Title;
            

            saver_obj.Title = txb_setNoteTitle.Text;
            saver_obj.Content = mainForm.frm_workspace.getSaverObj().Content;
            saver_obj.UUID = mainForm.frm_workspace.getSaverObj().UUID;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void btn_notebookSave_Click(object sender, EventArgs e)
        {
            

            if (!mainForm.dbManager_Docs.recordExist(saver_obj.UUID))
            {
                mainForm.dbManager_Docs.saveObject(saver_obj);
                mainForm.loadForm(mainForm.frm_notebook, mainForm.getPnlContent());
                mainForm.setActiveBtn(mainForm.getBtnNotebook(), mainForm.getPnlPageTabs());
                mainForm.frm_notebook.setActiveBtn(mainForm.frm_notebook.getBtnDocsTab(), mainForm.frm_notebook.getTbpnlTabs());
                mainForm.frm_notebook.displaySavedIdeas(mainForm.dbManager_Docs);
            }
            else
            {
                mainForm.dbManager_Docs.modifyField(saver_obj.UUID, "Content", saver_obj.Content);
                mainForm.dbManager_Docs.modifyField(saver_obj.UUID, "Title", txb_setNoteTitle.Text);
                mainForm.dbManager_Docs.modifyField(saver_obj.UUID, "Date_modified", DateTime.Now);
                Console.WriteLine("already exist");
            }

            mainForm.frm_workspace.getTxbDocsTitle().Text = txb_setNoteTitle.Text;

            this.Hide();
        }
        private void btn_fileSave_Click(object sender, EventArgs e)
        {
            string filePath = "";

            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.InitialDirectory = @"Documents";
                saveFileDialog1.FileName = txb_setNoteTitle.Text;
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                DialogResult result = saveFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    filePath = saveFileDialog1.FileName;
                    Console.WriteLine("Selected file: " + filePath);
                }
            } 

            if (filePath != "")
            {
                DatabaseManager.SaveStringAsTextFile(filePath, saver_obj.Content);
            }
            this.Hide();
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            Hide();
        }

        private void txb_setNoteTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_notebookSave_Click(sender, e);

                // Prevent the default behavior (e.g., beep sound)
                e.SuppressKeyPress = true;
                Hide();
            }
        }
    }
}
