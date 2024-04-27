using IdeasAi.modals;
using IdeasAi.PageForms;
using System;
using System.Windows.Forms;

namespace IdeasAi.pages
{
    public partial class frm_home : Form
    {
        MainForm mainForm;
        public const string howToUse = @"
        This is how to use the home kineme:
        firrst: you have to kineme              EDI WOW SAYOI

        ";
        public frm_home(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btn_QhubInfo_Click(object sender, EventArgs e)
        {
            ModalManager.ShowModal(mainForm, this, new mdl_howToUse(mainForm, "QHub", frm_consultation.howToUse));
        }

        private void btn_NotebookInfo_Click(object sender, EventArgs e)
        {
            ModalManager.ShowModal(mainForm, this, new mdl_howToUse(mainForm, "Notebook", frm_notebook.howToUse));
        }

        private void btn_WorkspaceInfo_Click(object sender, EventArgs e)
        {
            ModalManager.ShowModal(mainForm, this, new mdl_howToUse(mainForm, "Workspace", frm_workspace.howToUse));
        }

        private void btn_MindmapInfo_Click(object sender, EventArgs e)
        {
            ModalManager.ShowModal(mainForm, this, new mdl_howToUse(mainForm, "Mindmap", frm_mindmap.howToUse));
        }

        private void btn_getStarted_Click(object sender, EventArgs e)
        {
            mainForm.loadForm(mainForm.frm_consultation, mainForm.getPnlContent());
            mainForm.setActiveBtn(mainForm.getBtnConsult(), mainForm.getPnlPageTabs());
        }
    }
}
