using IdeasAi.db;
using IdeasAi.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IdeasAi.modals
{
    public partial class mdl_notebookSettings : Form
    {
        MainForm mainForm;
        public mdl_notebookSettings(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void pnl_content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mdl_notebookSettings_Load(object sender, EventArgs e)
        {
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

        private void btn_browsePath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog())
            {
                // Set initial directory (optional)
                folderBrowserDialog1.SelectedPath = @"C:\";

                // Show the dialog and capture the result
                DialogResult result = folderBrowserDialog1.ShowDialog();

                // Check if the user clicked OK
                if (result == DialogResult.OK)
                {
                    // Get the selected folder path
                    string folderPath = folderBrowserDialog1.SelectedPath;
                    txb_saveDBPath.Text = folderPath;
                }
                else
                {
                    txb_saveDBPath.Text = "";
                    // Handle case where the user cancels the dialog
                    mainForm.addNotification("error", "Failed to open!", "A folder was not selected properly");
                }
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_noteName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txb_noteName.Text) && !string.IsNullOrWhiteSpace(txb_saveDBPath.Text))
            {

                btn_createNew.Enabled = true;
            }
            else
            {
                btn_createNew.Enabled = false;
            }
        }

        private void txb_saveDBPath_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txb_noteName.Text) && !string.IsNullOrWhiteSpace(txb_saveDBPath.Text))
            {
                btn_createNew.Enabled = true;

            }
            else
            {
                btn_createNew.Enabled = false;
            }
        }

        private void btn_createNew_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager.CreateNewNotebook(txb_noteName.Text, txb_saveDBPath.Text + "\\" + txb_noteName.Text + ".db");
                DatabaseManager.AddNewDatabasePath(txb_noteName.Text, txb_saveDBPath.Text + "\\" + txb_noteName.Text + ".db", mainForm.settings);
                var notebookName = txb_noteName.Text;


                if (mainForm.frm_notebook.getCbDBSelector().Items.Contains(txb_noteName.Text))
                {
                    notebookName += "*";
                }
                
                mainForm.frm_notebook.getCbDBSelector().Items.Add(notebookName);
                mainForm.addNotification("success", "Notebook added!", $"{notebookName} was opened");

            }
            catch (Exception ex)
            {
                mainForm.addNotification("error", "Failed to create!", $"{ex.Message}");

            }
            this.Close();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                {
                    // Set initial directory (optional)
                    openFileDialog1.InitialDirectory = @"C:\";

                    // Set the file dialog filter
                    openFileDialog1.Filter = "Database files (*.db)|*.db|All files (*.*)|*.*";


                    // Allow multiple files to be selected (optional)
                    openFileDialog1.Multiselect = false;

                    // Show the dialog and capture the result
                    DialogResult result = openFileDialog1.ShowDialog();

                    // Check if the user clicked OK
                    if (result == DialogResult.OK)
                    {
                        // Get the selected file path
                        string filePath = openFileDialog1.FileName;
                        string fileName = Path.GetFileNameWithoutExtension(filePath);


                        DatabaseManager.AddNewDatabasePath(fileName, filePath, mainForm.settings);
                        if (mainForm.frm_notebook.getCbDBSelector().Items.Contains(fileName))
                        {
                            mainForm.frm_notebook.getCbDBSelector().Items.Add(fileName + "(*)");

                        }
                        else
                        {
                            mainForm.frm_notebook.getCbDBSelector().Items.Add(fileName);
                        }
                        mainForm.addNotification("success", "Notebook added!", $"{fileName} was opened");
                    }
                    else
                    {
                        this.Close();
                        mainForm.addNotification("error", "Failed to open!", $"A document was not opened properly");
                    }
                }
            }
            catch (Exception ex)
            {
                mainForm.addNotification("error", "Failed to create!", $"{ex.Message}");
                
            }
            this.Close();
        }
    }
}
