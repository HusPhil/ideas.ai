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


namespace IdeasAi.PageForms
{
    //public class MyClass
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}
    public partial class frm_home : Form
    {
        private MainForm mainForm;

        //PROPERTIES
        public Guid id_holder;
        public string content_holder;
        public string input_holder;
        public DateTime date_holder;
        /// <summary>
        /// ////////////////////////////////////////////
        /// </summary>
        /// 


        public frm_home(MainForm _mainForm)
        {
            InitializeComponent();
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
            btn_send.Enabled = false;
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
            btn_send.Enabled = true;
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

        

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            mainForm.mdl_setter.OpenModal(this, typeof(mdl_save), mainForm);
        }

        //GETTERS
        public ref Button getSaveBtn()
        {
            return ref btn_save;
        }
    }
    
}
