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
    public partial class frm_workspace : Form
    {
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
    }
}
