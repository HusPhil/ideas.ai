using Markdig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeasAi.PageForms
{
    public class MindMapControl : UserControl
    {
        private readonly WebBrowser webBrowser;

        public MindMapControl()
        {
            webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;

            Controls.Add(webBrowser);
        }

        public void UpdateMindMap(string htmlText)
        {
            // Update the WebBrowser control to display the parsed HTML
            webBrowser.DocumentText = htmlText;
        }
    }
    public partial class frm_settings : Form
    {
        public MainForm mainForm;
        private readonly MindMapControl mindMapControl;
        public frm_settings(MainForm _mainForm)
        {
            InitializeComponent();
            this.mainForm = _mainForm;
            // Initialize the mind map control
            mindMapControl = new MindMapControl();
            mindMapControl.Dock = DockStyle.Fill;

            Controls.Add(mindMapControl);
        }


        private void LoadMarkdown(string markdown)
        {
            // Parse the Markdown input using Markdig
            var parsedText = Markdown.ToHtml(markdown);

            // Update the mind map control with parsed data
            mindMapControl.UpdateMindMap(parsedText);
        }

        // Example usage: Load Markdown when form loads
        private void MainForm_Load(object sender, EventArgs e)
        {
            string markdown = @"# My Mindmap
                                - Topic 1
                                  - Subtopic 1.1
                                  - Subtopic 1.2
                                - Topic 2
                                  - Subtopic 2.1
                                  - Subtopic 2.2";
            LoadMarkdown(markdown);
        }

    }
}
