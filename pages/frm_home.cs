using IdeasAi.modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeasAi.pages
{
    public partial class frm_home : Form
    {
        MainForm mainForm;
        public frm_home(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btn_QhubInfo_Click(object sender, EventArgs e)
        {
            mainForm.setModalBackground(this);
            mdl_howToUse mdl_HowToUse = new mdl_howToUse(mainForm);
            mdl_HowToUse.ShowDialog();
        }

        private void btn_NotebookInfo_Click(object sender, EventArgs e)
        {
            mainForm.setModalBackground(this);
            mdl_howToUse mdl_HowToUse = new mdl_howToUse(mainForm);
            mdl_HowToUse.ShowDialog();
        }

        private void btn_WorkspaceInfo_Click(object sender, EventArgs e)
        {
            mainForm.setModalBackground(this);
            mdl_howToUse mdl_HowToUse = new mdl_howToUse(mainForm);
            mdl_HowToUse.ShowDialog();
        }

        private void btn_MindmapInfo_Click(object sender, EventArgs e)
        {
            mainForm.setModalBackground(this);
            mdl_howToUse mdl_HowToUse = new mdl_howToUse(mainForm);
            mdl_HowToUse.ShowDialog();
        }
    }
}
