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
            this.Location = ModalManager.CenterLocation(ownerForm.Width, ownerForm.Height, this.Width, this.Height, ownerForm.Location.X, ownerForm.Location.Y);
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
                    this.Close();
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
                var notebookName = txb_noteName.Text;


                if (mainForm.frm_notebook.getCbDBSelector().Items.Contains(notebookName))
                {
                    mainForm.addNotification("error", "Failed to open!", $"Notebook already exist!");
                    this.Close();
                    return;
                }

                DatabaseManager.CreateNewNotebook(notebookName, txb_saveDBPath.Text + "\\" + notebookName + ".db");
                DatabaseManager.AddNewDatabasePath(notebookName, txb_saveDBPath.Text + "\\" + notebookName + ".db", mainForm.settings);

                mainForm.frm_notebook.setNotebookKeys(true);
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
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    // Set initial directory (optional)
                    openFileDialog.InitialDirectory = @"C:\";

                    // Set the file dialog filter
                    openFileDialog.Filter = "Database files (*.db)|*.db|All files (*.*)|*.*";


                    // Allow multiple files to be selected (optional)
                    openFileDialog.Multiselect = false;

                    // Show the dialog and capture the result
                    DialogResult result = openFileDialog.ShowDialog();

                    // Check if the user clicked OK
                    if (result == DialogResult.OK)
                    {
                        // Get the selected file path
                        string filePath = openFileDialog.FileName;
                        string fileName = Path.GetFileNameWithoutExtension(filePath);
                        string notebookName = fileName;


                        if (mainForm.frm_notebook.getCbDBSelector().Items.Contains(fileName))
                        {
                            mainForm.addNotification("error", "Failed to open!", $"Notebook already exist!");
                            this.Close();
                            return;
                        }

                        DatabaseManager.AddNewDatabasePath(fileName, filePath, mainForm.settings);
                        mainForm.frm_notebook.setNotebookKeys(true);
                        mainForm.addNotification("success", "Notebook added!", $"{notebookName} was opened");
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
