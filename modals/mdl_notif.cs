using IdeasAi.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeasAi.modals
{
    public partial class mdl_notif : Form
    {
        MainForm mainForm;
        bool debugOn;
        int closeCountDown;
        public string notifType;
        public static int instancesCount;
        public mdl_notif(MainForm mainForm, string notifType)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.DoubleBuffered = true;
            this.notifType = notifType;
            

            switch (notifType.ToLower())
            {
                case "success":
                    pbx_type.Image = Resources.notifSuccess;
                    pnl_type.BackColor = ColorTranslator.FromHtml((string)mainForm.decors["Themes"]["LightTheme"]["accent"]);
                    break;
                case "info":
                case "response":
                    pnl_type.BackColor = ColorTranslator.FromHtml((string)mainForm.decors["Themes"]["LightTheme"]["secondary100"]);
                    pbx_type.Image = Resources.notifInfo;
                    break;
                case "warning":
                case "error":
                    pnl_type.BackColor = ColorTranslator.FromHtml((string)mainForm.decors["Themes"]["LightTheme"]["accent100"]);
                    pbx_type.Image = Resources.notifError;
                    break;
            }
        }

        

        private void mdl_notif_Load(object sender, EventArgs e)
        {
            instancesCount++;
            mainForm.setNotifPosition();
        }

        public void Position()
        {
            int notifX = (mainForm.Width - this.Width) - 34;
            int notifY = (mainForm.Height - (this.Height))  - ((this.Height+5)*instancesCount);

            this.Location = new Point(notifX, notifY);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            instancesCount--;
            this.Dispose();
            mainForm.setNotifPosition();
        }
        private void tmr_close_Tick(object sender, EventArgs e)
        {
            closeCountDown++;
            if (closeCountDown == 5 && notifType != "response") {
            instancesCount--;
            this.Dispose();
            mainForm.setNotifPosition();
            }
            
        }

        private void pnl_notifBody_MouseHover(object sender, EventArgs e)
        {
            tmr_close.Stop();
            
        }

        private void pnl_notifBody_MouseLeave(object sender, EventArgs e)
        {
            tmr_close.Start();
        }

        private void lbl_type_MouseHover(object sender, EventArgs e)
        {
            tmr_close.Stop();
            pnl_notifBody.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lbl_type_MouseLeave(object sender, EventArgs e)
        {
            tmr_close.Start();
            pnl_notifBody.BorderStyle = BorderStyle.None;
        }

        private void pbx_type_Click(object sender, EventArgs e)
        {
            if (debugOn)
            {
                lbl_info.Dock = DockStyle.Fill;
                lbl_type.Visible = false;
                debugOn = false;
            }
            else
            {
                lbl_info.Dock = DockStyle.Bottom;
                lbl_type.Visible = true;
                debugOn = true;
            }
        }

        private void pbx_type_MouseHover(object sender, EventArgs e)
        {
            tmr_close.Stop();
        }

        private void pbx_type_MouseLeave(object sender, EventArgs e)
        {
            tmr_close.Start();
        }

        private void pnl_type_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
