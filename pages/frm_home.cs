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

    }
}
