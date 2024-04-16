using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig;
using IdeasAi.Gemini_AI;
using IdeasAi.Ideas;
using IdeasAi.modals;
using IdeasAi.db;
using System.Drawing;
using System.IO;
using PlantUml.Net;
using IdeasAi.pages;
using System.Text.RegularExpressions;
using System.CodeDom.Compiler;


namespace IdeasAi.PageForms
{
    //public class MyClass
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}
    public partial class frm_consultation : Form
    {
        private MainForm mainForm;

        //PROPERTIES
        public Guid id_holder;
        public string content_holder;
        public string input_holder;
        public string markDownResonse;
        public DateTime date_holder;
        /// <summary>
        /// ////////////////////////////////////////////
        /// </summary>
        /// 


        public frm_consultation(MainForm _mainForm)
        {
            InitializeComponent();
            this.mainForm = _mainForm;
        }
        private string ConvertMarkdownToHtml(string markdownText)
        {
            // Convert Markdown to HTML
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

            Console.WriteLine(htmlText);
            // Set the HTML content to the WebBrowser control
            wb_container.DocumentText = htmlContent;
        }
        private async void btn_send_Click(object sender, EventArgs e)
        {
            mainForm.setModalBackground(this);
            mainForm.mdl_loading.state = MainForm.state_loadConsultation;
            mainForm.mdl_loading.getLblLoadInfo().Text = "Generating an answer..";
            mainForm.mdl_loading.ShowDialog();


        }
        public async void loadConsultation()
        {
            btn_send.Enabled = false;
            btn_save.Enabled = false;
            btn_print.Enabled = !true;
            btn_toWorkspace.Enabled = !true;

            var idea_obj = new Idea();
            var topic = this.txb_Consult.Text;

            Console.WriteLine(topic);
            idea_obj.Input = topic;
            try
            {
                idea_obj.Content = await idea_obj.GetResponse();
                mainForm.addNotification("success", "Successfully answered!", $"{idea_obj.Input}");
                displayResult(idea_obj.Content);

                id_holder = idea_obj.UUID;
                input_holder = idea_obj.Input;
                content_holder = idea_obj.Content;
                date_holder = idea_obj.DateCreated;
                btn_save.Enabled = true;
                btn_print.Enabled = true;
                btn_toWorkspace.Enabled = true;

            }
            catch (Exception ex)
            {
                wb_container.DocumentText = $"Ask appropriate questions in a clear manner.";
                mainForm.addNotification("error", "An error occured!", $"{ex.Message}");
            }

            btn_send.Enabled = true;
            mainForm.mdl_loading.Close();
            mainForm.modalBG.Hide();

        }



        private void btn_save_Click_1(object sender, EventArgs e)
        {
            mainForm.mdl_setter.OpenModal(this, typeof(mdl_saveNotes), mainForm);
        }
        private void frm_home_Load(object sender, EventArgs e)
        {

        }

        private void txb_Consult_TextChanged(object sender, EventArgs e)
        {
            txb_Consult.ForeColor = Color.White;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            wb_container.ShowPrintDialog();
        }

        private void btn_toWorkspace_Click(object sender, EventArgs e)
        {
            mainForm.frm_workspace.saver_obj.UUID = Guid.NewGuid();
            mainForm.frm_workspace.getTxbDocsTitle().Text = input_holder;
            mainForm.frm_workspace.getTxbEditor().Text = frm_workspace.ConvertMarkdownToPlainText(content_holder);

            mainForm.loadForm(mainForm.frm_workspace, mainForm.getPnlContent());
            mainForm.setActiveBtn(mainForm.getBtnWorkspace(), mainForm.getPnlPageTabs());
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

        private void txb_Consult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;

                txb_Consult.SelectedText = Clipboard.GetText();
            }
        }
    }
    
}
