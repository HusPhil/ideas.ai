using System;
using System.Windows.Forms;
using Markdig;
using IdeasAi.Ideas;
using IdeasAi.modals;
using IdeasAi.pages;
using Microsoft.Win32;
using IdeasAi.db;
using IdeasAi.ai_responses;


namespace IdeasAi.PageForms
{
    public partial class frm_consultation : Form
    {
        public const string howToUse = @"
        This is how to use the consultation kineme:
        firrst: you have to kineme              EDI WOW SAYOI

        ";
        private MainForm mainForm;

        //PROPERTIES
        public DBObjectManager saver_obj;

        public frm_consultation(MainForm _mainForm)
        {
            InitializeComponent();
            this.mainForm = _mainForm;
            saver_obj = new DBObjectManager();
            OptimizeInternetExplorerVersion();
        }
        private void OptimizeInternetExplorerVersion()
        {
            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";

            using (var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
            {
                key.SetValue(appName, 99999, RegistryValueKind.DWord);
            }

            wb_container.Navigate("https://google.com/");

        }
        private string ConvertMarkdownToHtml(string markdownText)
        {
            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            return Markdig.Markdown.ToHtml(markdownText, pipeline);
        }

        public void displayResult(string markdownText)
        {
            string htmlText = ConvertMarkdownToHtml(markdownText);

            string htmlContent = @"
                    <!DOCTYPE html>
                    <html>
                    <head>
                    <style>
                        table {
                        border-collapse: collapse;
                        width: 100%;
                          }
                          th, td {
                            border: 1px solid black;
                            padding: 8px;
                            text-align: left;
                          }
                          tr:nth-child(even) {
                            background-color: #b0d07e;
                          }
                          th {
                            background-color: #b0d07e;
                           }
                    </style>
                    </head>
                    <body>
                    " + htmlText + @"
                    </body>
                    </html>
                    ";

            wb_container.DocumentText = htmlContent;
        }
        public async void loadConsultation()
        {
            btn_send.Enabled = false;
            btn_save.Enabled = false;
            btn_print.Enabled = !true;
            btn_toWorkspace.Enabled = !true;

            var topic = this.txb_Consult.Text;
            var idea_obj = new AI_ResponseBuilder<AI_Consultant>()
                .WithInput(topic)
                .Build();

            try
            {
                idea_obj.Content = await idea_obj.GetResponse(mainForm.settings);
                mainForm.addNotification("success", "Successfully answered!", $"{idea_obj.Input}");
                displayResult(idea_obj.Content);

                saver_obj.UUID = idea_obj.UUID;
                saver_obj.Input = idea_obj.Input;
                saver_obj.Content = idea_obj.Content;
                saver_obj.DateCreated = idea_obj.DateCreated;
                btn_save.Enabled = true;
                btn_print.Enabled = true;
                btn_toWorkspace.Enabled = true;

            }
            catch (Exception ex)
            {
                wb_container.DocumentText = $"Something went wrong. Please check your internet connection and try again  by asking appropriate questions in a clear manner. Thank you!";
                mainForm.addNotification("error", "An error occured!", $"{ex.Message}");
            }
            finally
            {
                btn_send.Enabled = true;
                mainForm.mdl_loading.Close();
                mainForm.modalBG.Hide();

            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            mainForm.setModalBackground(this);
            mainForm.mdl_loading.state = MainForm.state_loadConsultation;
            mainForm.mdl_loading.getLblLoadInfo().Text = "Generating an answer..";
            ModalManager.ShowModal(mainForm, this, mainForm.mdl_loading);
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            ModalManager.ShowModal(mainForm, this, new mdl_saveNotes(mainForm));
        }
        private void btn_print_Click(object sender, EventArgs e)
        {
            wb_container.ShowPrintDialog();
        }
        private void btn_toWorkspace_Click(object sender, EventArgs e)
        {
            mainForm.frm_workspace.saver_obj.UUID = Guid.NewGuid();
            mainForm.frm_workspace.getTxbDocsTitle().Text = saver_obj.Title;
            mainForm.frm_workspace.getTxbEditor().Text = MainForm.ConvertMarkdownToPlainText(saver_obj.Content);

            mainForm.loadForm(mainForm.frm_workspace, mainForm.getPnlContent());
            mainForm.setActiveBtn(mainForm.getBtnWorkspace(), mainForm.getPnlPageTabs());
        }
        private void txb_Consult_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Consult.Text))
            {
                btn_send.Enabled = false;
            }
            else
            {
                btn_send.Enabled = true;
            }
        }
        private void txb_Consult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;

                txb_Consult.SelectedText = Clipboard.GetText();
            }
        }

        //GETTERS
        public ref Button getSaveBtn()
        {
            return ref btn_save;
        }
        public ref Button getPrintBtn()
        {
            return ref btn_print;
        }
        public ref Button getToWorkspaceBtn()
        {
            return ref btn_toWorkspace;
        }

        private void btn_searchMode_Click(object sender, EventArgs e)
        {
            wb_container.Navigate("google.com");
        }
    }

}
