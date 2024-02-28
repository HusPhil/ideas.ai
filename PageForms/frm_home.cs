using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig;
using System.Threading.Tasks;
using IdeasAi.Gemini_AI;
using System.Net.Http;
using System.Xml;

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

        private async void button1_Click(object sender, EventArgs e)
        {
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
            var prompt = "Pretend you are an expert about providing useful ideas. " +
                "If the topic is not valid or vague, suggest other topics to explore instead. " +
                "Make a table, and make a column for each subtopic." +
                "The rows of each columns must provide brief information, significance, project ideas, and research ideas about the subtopics." +
                "Below the table, supply further information and explain the topic and its subtopic as if you are speaking to a child." +
                "Finally, make an outline about the topic as well as some references on where the user can learn more." +
                $"The topic supplied: {topic}";

            string response = ScriptRunner.runScript("Gemini_AI\\Scripts\\gemini.py", prompt);
            Console.WriteLine(response);
            displayResult(response);
        }
    }
}
