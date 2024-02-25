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

namespace IdeasAi.PageForms
{
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
            string markdownText = @"









| Feature | Description | Benefits | Drawbacks | Considerations |
|---|---|---|---|---|
| Topic-based suggestions | App suggests ideas based on a topic entered by the user. | Provides personalized and relevant ideas. | May be limited to topics with enough data. | Requires a large database of ideas and topics. |
| AI-powered generation | App uses AI algorithms to generate new and unique ideas. | Offers a wide range of diverse and creative ideas. | Results may be unpredictable or nonsensical. | Requires a sophisticated AI model. |
| Collaborative brainstorming | App allows users to collaborate and share ideas with others. | Encourages teamwork and collective thinking. | May lead to disagreements or conflicts. | Requires a social platform or messaging system. |
| Idea evaluation | App provides users with tools to evaluate and refine their ideas. | Helps users identify the most promising ideas. | May introduce bias or subjectivity. | Requires a structured evaluation framework. |
| Idea implementation | App offers resources and guidance to help users implement their ideas. | Increases the likelihood of idea success. | May require additional fees or services. | Requires partnerships with service providers or resources. |




























";



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
        private string ConvertMarkdownToHtml(string markdownText)
        {
            // Convert Markdown to HTML
            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            return Markdig.Markdown.ToHtml(markdownText, pipeline);
        }
    }
}
