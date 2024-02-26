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

namespace IdeasAi.PageForms
{
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
            displayResult("| Feature | Description | Benefits | Drawbacks | Considerations |\r\n|---|---|---|---|---|\r\n| Topic-based suggestions | App suggests ideas based on a topic entered by the user. | Provides personalized and relevant ideas. | May be limited to topics with enough data. | Requires a large database of ideas and topics. |\r\n| AI-powered generation | App uses AI algorithms to generate new and unique ideas. | Offers a wide range of diverse and creative ideas. | Results may be unpredictable or nonsensical. | Requires a sophisticated AI model. |\r\n| Collaborative brainstorming | App allows users to collaborate and share ideas with others. | Encourages teamwork and collective thinking. | May lead to disagreements or conflicts. | Requires a social platform or messaging system. |\r\n| Idea evaluation | App provides users with tools to evaluate and refine their ideas. | Helps users identify the most promising ideas. | May introduce bias or subjectivity. | Requires a structured evaluation framework. |\r\n| Idea implementation | App offers resources and guidance to help users implement their ideas. | Increases the likelihood of idea success. | May require additional fees or services. | Requires partnerships with service providers or resources. |\r\n");
            
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
            wb_container.DocumentText = "Getting a response for you!";
            await Task.Delay(500);

            var idea = this.textBox1.Text;
            Console.WriteLine(idea);
            var prompt = $"Pretend you are an expert with a vast knowledge about everything. You are to suggest useful ideas to the users about the supplied topic. Make a table of related suggestions/ideas about a topic. Make columns for each suggestion/idea. IT IS VERY IMPORTANT THAT YOU RESPOND WITH ONLY Atleast OF FIVE COLUMNS and at least 3 rows. The title of each column should be about the name of the idea being suggested. If the topic supplied is cannot be considered as a topic, tell the user to try again, else output only the TABLE and nothing . The topic supplied: {idea}. If you are not able to give the user suggestions about a topic, tell them the reason why and suggest spefic topics that they can ask instead. PLEASE GIVE THE TABLE ONLY AND NO OTHER TEXT";
            string hi = ScriptRunner.runScript("Gemini_AI\\Scripts\\gemini.py", prompt);
            Console.WriteLine(hi);
            displayResult(hi);
        }
    }
}
