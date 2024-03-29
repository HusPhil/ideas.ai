using ComponentFactory.Krypton.Toolkit;
using IdeasAi.ai_responses;
using IdeasAi.modals;
using Markdig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeasAi.pages
{
    public partial class frm_workspace : Form
    {
        //GETTERS
        public Guid id_holder;
        public string content_holder;
        public string title_holder;
        public string input_holder;
        public DateTime date_holder;
        //
        MainForm mainForm;
        public frm_workspace(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnl_textEditor_Paint(object sender, PaintEventArgs e)
        {

        }
        private static string ConvertMarkdownToPlainText(string markdown)
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
            btn_organizeIdea.Enabled = false;
            txb_textEditor.ReadOnly = true;

            var orgIdea_obj = new OrganizedIdea();
            orgIdea_obj.Input = txb_textEditor.Text;
            orgIdea_obj.Content = await orgIdea_obj.GetResponse();

            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();

            txb_textEditor.Text = ConvertMarkdownToPlainText(orgIdea_obj.Content);
            btn_organizeIdea.Enabled = true;
            txb_textEditor.ReadOnly = false;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            title_holder = txb_docsTitle.Text;
            content_holder = txb_textEditor.Text;
            
            mainForm.mdl_setter.OpenModal(this, typeof(mdl_saveDocs), mainForm);
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {

        }

        private async void btn_createMindmap_Click(object sender, EventArgs e)
        {
            var mindmap_obj = new Mindmap();
            mindmap_obj.Input = ConvertMarkdownToPlainText(txb_textEditor.Text);
            mindmap_obj.Content = await mindmap_obj.GetResponse();

            mainForm.frm_mindmap.getTxbMarkdownInput().Text = mindmap_obj.Content;
            mainForm.frm_mindmap.generateMindmap(mindmap_obj.Content);

            mainForm.loadForm(mainForm.frm_mindmap, mainForm.getPnlContent());
            mainForm.setActiveBtn(mainForm.getBtnMindmap(), mainForm.getPnlPageTabs());
        }


        //GETTERS
        public ref KryptonTextBox getTxbDocsTitle()
        {
            return ref txb_docsTitle;
        }

        public ref KryptonTextBox getTxbEditor()
        {
            return ref txb_textEditor;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            id_holder = Guid.NewGuid();
            txb_docsTitle.Text = "Untitled Docs";
            txb_textEditor.Text = "";
        }
    }
}
