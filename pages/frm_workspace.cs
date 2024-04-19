using ComponentFactory.Krypton.Toolkit;
using IdeasAi.ai_responses;
using IdeasAi.db;
using IdeasAi.Ideas;
using IdeasAi.modals;
using IdeasAi.Properties;
using Markdig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeasAi.pages
{
    public partial class frm_workspace : Form
    {
        //GETTERS
        //public Guid id_holder;
        //public string content_holder;
        //public string title_holder;
        //public string input_holder;
        //public DateTime date_holder;
        public DBObjectManager saver_obj;
        //
        MainForm mainForm;
        public frm_workspace(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            saver_obj = new DBObjectManager();
            saver_obj.UUID = Guid.NewGuid();
            saver_obj.Content = txb_textEditor.Text;
            saver_obj.Title = txb_docsTitle.Text;
            pbx_loading.Image = null;
            this.DoubleBuffered = true;
        }

        public static string ConvertMarkdownToPlainText(string markdown)
        {
            // Replace Markdown heading syntax with plain text equivalent
            markdown = Regex.Replace(markdown, @"^#+\s*(.*?)\s*#*[\r\n]*", "$1\n\n", RegexOptions.Multiline);

            // Replace Markdown bold syntax with plain text equivalent
            markdown = Regex.Replace(markdown, @"\*\*(.*?)\*\*", "$1");

            // Replace Markdown italic syntax with plain text equivalent
            markdown = Regex.Replace(markdown, @"\*(.*?)\*", "$1");

            // Replace Markdown code block syntax with plain text equivalent
            markdown = Regex.Replace(markdown, @"```(.+?)```", "$1");

            // Replace Markdown inline code syntax with plain text equivalent
            markdown = Regex.Replace(markdown, @"`(.+?)`", "$1");

            // Replace Markdown list syntax with plain text equivalent
            markdown = Regex.Replace(markdown, @"^\s*\*\s*(.*?)\s*", "- $1\n", RegexOptions.Multiline);

            return markdown;
        }
        private async void btn_organizeIdea_Click(object sender, EventArgs e)
        {
            mainForm.setModalBackground(this);
            mainForm.mdl_organize.ShowDialog();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            saver_obj.Title = txb_docsTitle.Text;
            saver_obj.Content = txb_textEditor.Text;
            
            mainForm.mdl_setter.OpenModal(this, typeof(mdl_saveDocs), mainForm);
        }
        private void btn_openFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                // Set initial directory (optional)
                openFileDialog1.InitialDirectory = @"C:\";

                // Set the file dialog filter
                openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                // Allow multiple files to be selected (optional)
                openFileDialog1.Multiselect = false;

                // Show the dialog and capture the result
                DialogResult result = openFileDialog1.ShowDialog();

                // Check if the user clicked OK
                if (result == DialogResult.OK)
                {
                    // Get the selected file path
                    string filePath = openFileDialog1.FileName;
                    txb_textEditor.Text = File.ReadAllText(filePath);
                    txb_docsTitle.Text = Path.GetFileNameWithoutExtension(filePath);
                    FileInfo fileInfo = new FileInfo(filePath);
                    lbl_lastDateSaved.Text = $"Last Modified: {fileInfo.LastWriteTime.ToString("yyyy-MM-dd hh:mm tt")}";
                    mainForm.addNotification("success", "Document opened!", $"{txb_docsTitle.Text} was opened");

                    btn_docsDel.Visible = !true;
                    saver_obj.UUID = Guid.Empty;
                }
                else
                {
                    mainForm.addNotification("error", "Failed to open!", $"A document was not opened properly");
                }
               
            }
        }
        private void btn_createMindmap_Click(object sender, EventArgs e)
        {
            mainForm.setModalBackground(this);
            mainForm.mdl_loading.state = MainForm.state_loadMindmap;
            mainForm.mdl_loading.getLblLoadInfo().Text = "Generating your Mindmap..";
            mainForm.mdl_loading.ShowDialog();

        }
        public async void loadMindmap()
        {
            var mindmap_obj = new Mindmap();
            mindmap_obj.Input = ConvertMarkdownToPlainText(txb_textEditor.Text);


            try
            {
                mindmap_obj.Content = await mindmap_obj.GetResponse();
                mainForm.frm_mindmap.getTxbMarkdownInput().Text = mindmap_obj.Content;
                mainForm.frm_mindmap.generateMindmap(mindmap_obj.Content);
                mainForm.frm_mindmap.getTxbTitle().Text = txb_docsTitle.Text + " [mindmap]";
                //mainForm.addNotification("success", "Successfully generated!", "A mindmap was successfully generated");
            }
            catch (Exception exception)
            {
                mainForm.addNotification("error", "Failed to generate!", $"Error: {exception.Message}");
            }
            

            mainForm.loadForm(mainForm.frm_mindmap, mainForm.getPnlContent());
            mainForm.setActiveBtn(mainForm.getBtnMindmap(), mainForm.getPnlPageTabs());

            mainForm.mdl_loading.Close();
            mainForm.modalBG.Hide();
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            saver_obj.UUID = Guid.NewGuid();
            txb_docsTitle.Text = "Untitled Docs";
            txb_textEditor.Text = "";
            lbl_lastDateSaved.Text = "Last Modified: N/A";
            saver_obj.Content = txb_textEditor.Text;
            saver_obj.Title = txb_docsTitle.Text;
            mainForm.addNotification("info", "New document opened!", "Empty workspace loaded");
        }
        private void txb_textEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.S)
            {
                saver_obj.Content = saver_obj.Content;
                saver_obj.Title = txb_docsTitle.Text;
                saver_obj.DateCreated = DateTime.Now;

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
                    mainForm.dbManager_Docs.modifyField(saver_obj.UUID, "Title", saver_obj.Title);
                    mainForm.dbManager_Docs.modifyField(saver_obj.UUID, "Date_modified", saver_obj.DateCreated);
                    Console.WriteLine("already exist");
                }
                e.SuppressKeyPress = true;
                lbl_lastDateSaved.Text = $"Last Modified: {DateTime.Now.ToString("yyyy-MM-dd hh:mm tt")}";
                mainForm.addNotification("success", "Successfully saved!", $"{saver_obj.Title}");
                
            }
            else if (e.Control && e.KeyCode == Keys.Q)
            {
                // Get the clipboard data
                string selectedText = txb_textEditor.SelectedText;

                // Check if the clipboard contains image data
                if (!string.IsNullOrWhiteSpace(selectedText))
                {
                    txb_QSearch.ForeColor = Color.Black;
                    txb_QSearch.Text = selectedText;
                    btn_QSearch_Click(sender, e);
                }
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
                txb_textEditor.SelectedText = Clipboard.GetText();
            }



        }
        private void txb_textEditor_TextChanged(object sender, EventArgs e)
        {
            saver_obj.Content = txb_textEditor.Text;
            
        }
        private async void btn_QSearch_Click(object sender, EventArgs e)
        {
            // make a new instance of Ai response responsible for quick search
            var asyncNotif = mainForm.addAsyncNotification("response", "Now searching for:", $"{txb_QSearch.Text}");
            asyncNotif.Show();
            asyncNotif.BringToFront();

            var qsearch_obj = new QuickSearch();
            qsearch_obj.Input = ConvertMarkdownToPlainText(txb_QSearch.Text);
            pbx_loading.Image = Resources.dot_loading;
            pbx_loading.Visible = true;
            btn_QSearch.Enabled = !true;


            try
            {
                qsearch_obj.Content = await qsearch_obj.GetResponse();
                txb_qsearchRes.Text = ConvertMarkdownToPlainText(qsearch_obj.Content);
                mainForm.addNotification("success", "Success!", "View search result");
            }
            catch(Exception ex)
            {
                mainForm.addNotification("warning", "An error occured: ", ex.Message);
                Console.WriteLine(ex.Message);
            }
            
            pbx_loading.Image = null;
            pbx_loading.Visible = !true;
            btn_QSearch.Enabled = true;

            asyncNotif.Dispose();
            mdl_notif.instancesCount--;
            mainForm.setNotifPosition();

            // set its INput
        }
        private void txb_QSearch_Click(object sender, EventArgs e)
        {
            if (txb_QSearch.ForeColor.Equals(Color.Silver))
            {
                txb_QSearch.Text = "";
            }
            txb_QSearch.ForeColor = Color.Black;
        }
        private void txb_QSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btn_QSearch.Enabled)
            {
                btn_QSearch_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
        private void btn_docOptions_Click(object sender, EventArgs e)
        {
            if (pnl_docConts.Visible)
            {
                pnl_docConts.Visible = !true;
            }
            else
            {
                pnl_docConts.Visible = true;
            }
        }
        private void btn_docsDel_Click(object sender, EventArgs e)
        {
            if(pnl_confirmDel.Visible)
            {
                pnl_confirmDel.Visible = !true;
            }
            else
            {
                pnl_confirmDel.Visible = true;
            }
        }
        private void frm_workspace_Paint(object sender, PaintEventArgs e)
        {
            pnl_confirmDel.Visible = !true;
            if (mainForm.dbManager_Docs.recordExist(saver_obj.UUID))
            {
                btn_docsDel.Visible = true;
            }
            else
            {
                btn_docsDel.Visible = !true;
            }
            Console.WriteLine(saver_obj.UUID);
        }
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (mainForm.dbManager_Docs.recordExist(saver_obj.UUID))
            {
                try
                {
                    mainForm.dbManager_Docs.deleteRecord(saver_obj.UUID);
                    mainForm.addNotification("success", "Successfully deleted!", $"{saver_obj.Title} was deleted");
                    btn_new_Click(sender, e);
                    pnl_confirmDel.Visible = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR FOUND IN DOCSDEL" + ex.Message);
                    mainForm.addNotification("success", "Deleting failed!", $"{saver_obj.Title} failed to be deleted");
                }
            }
        }


        //GETTERS
        public ref KryptonTextBox getTxbDocsTitle()
        {
            return ref txb_docsTitle;
        }

        public ref RichTextBox getTxbEditor()
        {
            return ref txb_textEditor;
        }

        public ref DBObjectManager getSaverObj()
        {
            return ref saver_obj;
        }
        public ref Label getLblLastDateSaved()
        {
            return ref lbl_lastDateSaved;
        }

    }
}
