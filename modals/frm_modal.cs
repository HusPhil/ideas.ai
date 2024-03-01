using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdeasAi.PageForms;

namespace IdeasAi.modals
{
    public partial class frm_modal : Form
    {
        int i;
        public frm_modal()
        {
            InitializeComponent();
        }

        private void tmr_animation_Tick(object sender, EventArgs e)
        {
            if(Opacity >= 1)
            {
                tmr_animation.Stop();
            }
            else
            {
                Opacity += .05;
            }
        }

        private void frm_modal_Load(object sender, EventArgs e)
        {
            int centerX = (Owner.Owner.Owner.Width / 2) - (Width / 2);
            int centerY = (Owner.Owner.Owner.Height / 2) - (Height / 2);
            this.Location = new Point(Owner.Owner.Owner.Location.X + centerX, Owner.Owner.Owner.Location.Y + centerY);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
