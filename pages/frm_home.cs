using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig;
using IdeasAi.Gemini_AI;
using IdeasAi.Ideas;
using IdeasAi.db;

namespace IdeasAi.PageForms
{
    public partial class frm_home : Form
    {
        public frm_home()
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
        }
        private string ConvertMarkdownToHtml(string markdownText)
        {
            // Convert Markdown to HTML
            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            return Markdig.Markdown.ToHtml(markdownText, pipeline);
        }
        private void displayResult(string markdownText)
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private async void btn_send_Click(object sender, EventArgs e)
        {
            var idea = new Idea();
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
            await Task.Delay(500);

            var topic = this.textBox1.Text;

            Console.WriteLine(topic);
            idea.Input = topic;
            string response = idea.Content;
            displayResult(response);
            Console.WriteLine($"ID AY ITO: {idea.UUID}\nINPUT IS ITO: {idea.Input}\nDATE IS ITO: {idea.DateCreated}");
            var dbManager = new DatabaseManager("sqlite.db");
            dbManager.SaveObject(idea);

            var ideas = dbManager.GetAllIdeas();

            // Display the retrieved ideas
            Console.WriteLine("Retrieved Ideas:");
            foreach (var idea_var in ideas)
            {
                Console.WriteLine($"UUID: {idea_var.UUID}");
                Console.WriteLine($"Title: {idea_var.Title}");
                Console.WriteLine($"Content: {idea_var.Content}");
                Console.WriteLine($"Date Created: {idea_var.DateCreated}");
                Console.WriteLine();
            }

        }
    }
}
