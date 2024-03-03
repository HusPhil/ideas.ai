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
    public partial class frm_settings : Form
    {
        public MainForm mainForm;
        public frm_settings(MainForm _mainForm)
        {
            InitializeComponent();
            this.mainForm = _mainForm;
        }
    }
}
