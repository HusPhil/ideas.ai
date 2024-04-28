using IdeasAi.ai_responses;
using IdeasAi.Ideas;
using Markdig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Expando;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeasAi.modals
{
    public partial class mdl_organize : Form
    {
        MainForm mainForm;
        public mdl_organize(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void mdl_organize_Load(object sender, EventArgs e)
        {
            cb_modeSelector.SelectedIndex = 0;
            var ownerForm = mainForm;
            this.Location = ModalManager.CenterLocation(ownerForm.Width, ownerForm.Height, this.Width, this.Height, ownerForm.Location.X, ownerForm.Location.Y);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            mainForm.modalBG.Hide();
            this.Hide();
        }

        private async void btn_go_Click(object sender, EventArgs e)
        {
            
            string selectedMode = cb_modeSelector.SelectedItem.ToString();
            var loader = new mdl_loading(mainForm);
            

            mainForm.loadForm(loader, pnl_body);

            switch (selectedMode)
            {
                case "Grammar Checker":
                    loader.getLblLoadInfo().Text = "Checking the grammar..";
                    var grammarChecker = new AI_ResponseBuilder<AI_GrammarChecker>()
                        .WithInput(txb_preview.Text)
                        .Build();

                    grammarChecker.Content = await grammarChecker.GetResponse(mainForm.settings);
                    txb_preview.Text = MainForm.ConvertMarkdownToPlainText(grammarChecker.Content);

                    break;
                case "Summarizer":
                    loader.getLblLoadInfo().Text = "Summarizing your ideas..";

                    var summarizer = new AI_ResponseBuilder<AI_Summarizer>()
                        .WithInput(txb_preview.Text)
                        .Build();
                    
                    summarizer.Content = await summarizer.GetResponse(mainForm.settings);
                    txb_preview.Text = MainForm.ConvertMarkdownToPlainText(summarizer.Content);

                    break;
                case "Expand Ideas":
                    loader.getLblLoadInfo().Text = "Expanding your ideas..";

                    var expander = new AI_ResponseBuilder<AI_Elaborator>()
                        .WithInput(txb_preview.Text)
                        .Build();
                    expander.Content = await expander.GetResponse(mainForm.settings);
                    txb_preview.Text = MainForm.ConvertMarkdownToPlainText(expander.Content);

                    break;
                case "Categorize Ideas":
                    loader.getLblLoadInfo().Text = "Categorizing your ideas..";

                    var categorizer = new AI_ResponseBuilder<AI_Categorizer>()
                        .WithInput(txb_preview.Text)
                        .Build();
                    categorizer.Content = await categorizer.GetResponse(mainForm.settings);
                    txb_preview.Text = MainForm.ConvertMarkdownToPlainText(categorizer.Content);

                    break;
                case "SCAMPER Technique":
                    loader.getLblLoadInfo().Text = "Organizing (SCAMPER) your ideas..";

                    var scamper = new AI_ResponseBuilder<AI_Scamper>()
                        .WithInput(txb_preview.Text)
                        .Build();
                    scamper.Content = await scamper.GetResponse(mainForm.settings);
                    txb_preview.Text =  MainForm.ConvertMarkdownToPlainText(scamper.Content);

                    break;
            }
            btn_save.Enabled = true;
            mainForm.removeForm(loader, pnl_body);
        }

        private void cb_modeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            mainForm.frm_workspace.getTxbEditor().Text += "\n\n" + cb_modeSelector.SelectedItem.ToString() + ":\n" + txb_preview.Text;
            mainForm.frm_workspace.getTxbEditor().SelectionStart = mainForm.frm_workspace.getTxbEditor().TextLength;
            mainForm.frm_workspace.getTxbEditor().ScrollToCaret();
            btn_save.Enabled = false;

            this.Hide();
        }

        public ref RichTextBox getTxbPreview()
        {
            return ref txb_preview;
        }

       
    }
}