using IdeasAi.ai_responses;
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
            this.Location = ModalSetter.CenterLocation(ownerForm.Width, ownerForm.Height, this.Width, this.Height, ownerForm.Location.X, ownerForm.Location.Y);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            mainForm.modalBG.Hide();
            this.Hide();
        }

        private async void btn_go_Click(object sender, EventArgs e)
        {
            //get the selected item from the mode selector
            string selectedMode = cb_modeSelector.SelectedItem.ToString();
            //call the class for the respective mode
            //Summarizer
            //Grammar Checker
            //Expand Ideas
            //Categorize Ideas
            //SCAMPER Technique

            var loader = new mdl_loading(mainForm);
            

            mainForm.loadForm(loader, pnl_body);

            switch (selectedMode)
            {
                case "Grammar Checker":
                    Console.WriteLine("Grammar Check!");
                    break;
                case "Summarizer":
                    loader.getLblLoadInfo().Text = "Summarizing your ideas..";
                    var summarizer = new Summarizer();
                    summarizer.Input = txb_preview.Text;
                    summarizer.Content = await summarizer.GetResponse(mainForm.settings);
                    mainForm.removeForm(loader, pnl_body);
                    txb_preview.Text = summarizer.Content;
                    break;
                case "Expand Ideas":

                    break;
                case "Categorize Ideas":

                    break;
                case "SCAMPER Technique":

                    break;
            }
        }

        private void cb_modeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            mainForm.frm_workspace.getTxbEditor().Text += cb_modeSelector.SelectedItem.ToString() + ":\n" + txb_preview.Text;
        }

        public ref RichTextBox getTxbPreview()
        {
            return ref txb_preview;
        }

       
    }
}