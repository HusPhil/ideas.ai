using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig;
using IdeasAi.Gemini_AI;
using IdeasAi.Ideas;
using IdeasAi.modals;
using IdeasAi.db;
using System.Drawing;

namespace IdeasAi.PageForms
{
    public partial class frm_home : Form
    {
        //PROPERTIES
        public ModalSetter modal_save;
        public Guid id_holder;
        public string content_holder;
        public string input_holder;
        public DateTime date_holder;

        public mdl_save modalSave= new mdl_save();

        /// <summary>
        /// ////////////////////////////////////////////
        /// </summary>
        /// 

        public frm_home()
        {
            InitializeComponent();
            modal_save = new ModalSetter(this, typeof(mdl_save));
            wb_container.DocumentText = @"
            <!DOCTYPE html>
            <html lang=""en"">
            <head>
            <meta charset=""UTF-8"">
            <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
            <title>Centered Container</title>
            <style>
              body {
                margin: 0;
                display: flex;
                justify-content: center;
                align-items: center;
                height: 100vh;
              }
              .container {
                text-align: center;
                padding: 20px;
                height: 100%;
              }
            </style>
            </head>
            <body>

            <div class=""container"">
              <h1>Ask me something</h1>
            </div>

            </body>
            </html>
            ";
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
    background-color: rgb(173, 197, 199);
  }
  th {
    background-color: rgb(173, 197, 199);
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
            btn_save.Enabled = false;
            var idea_obj = new Idea();
            wb_container.DocumentText = @"
                    <!DOCTYPE html>
                    <html>
                    <head>
                    <style>
                        body {
                            background-color: black;
                            color: white;
                        }
                        table {
                            border-collapse: collapse;
                            width: 100%;
                        }

                        th, td {
                            border: 1px solid #dddddd;
                            text-align: left;
                            padding: 8px;
                        }

                        th {
                            background-color: black;
                        }
                    </style>
                    </head>
                    <body>
                    " + "Getting a Response for You!" + @"
                    </body>
                    </html>
                    "; ;

            var topic = this.textBox1.Text;

            Console.WriteLine(topic);
            idea_obj.Input = topic;
            idea_obj.Content = await idea_obj.GetResponse(); 

            displayResult(idea_obj.Content);

            id_holder = idea_obj.UUID;
            input_holder = idea_obj.Input;
            content_holder = idea_obj.Content;
            date_holder = idea_obj.DateCreated;

            btn_save.Enabled = true;
            Console.WriteLine($"ID AY ITO: {idea_obj.UUID}\nINPUT IS ITO: {idea_obj.Input}\nDATE IS ITO: {idea_obj.DateCreated}");

           

            //Display the retrieved ideas
            //Console.WriteLine("Retrieved Ideas:");
            //foreach (var idea_var in ideas)
            //{
            //    Console.WriteLine($"UUID: {idea_var.UUID}");
            //    Console.WriteLine($"Title: {idea_var.Title}");
            //    Console.WriteLine($"Content: {idea_var.Content}");
            //    Console.WriteLine($"Date Created: {idea_var.DateCreated}");
            //    Console.WriteLine();
            //}

        }
        private void openModal()
        {

            Form modalBG = new Form();
            using (var modal = new mdl_save())
            {
                modalBG.Owner = this; 
                modalBG.StartPosition = FormStartPosition.Manual;
                modalBG.FormBorderStyle = FormBorderStyle.None;
                modalBG.Opacity = .50d;
                modalBG.BackColor = Color.Black;
                modalBG.Size = this.Size;
                modalBG.Location = this.Location;
                modalBG.ShowInTaskbar = false;
                modalBG.Show();
                modal.Owner = modalBG;
                
                modal.ShowDialog();
                modalBG.Dispose();
            }
        }
        
        private void btn_save_Click_1(object sender, EventArgs e)
        {
            modal_save.openModal();
        }
    }
}
