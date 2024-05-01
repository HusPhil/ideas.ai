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
    public partial class frm_SPLASH : Form
    {
        List<string> loaders = new List<string>();
        int counter;
        MainForm mainForm;
        public frm_SPLASH()
        {
            InitializeComponent();
            //loaders.Add("Tick-tock, we're winding up for an amazing experience!");
            //loaders.Add("Professor Neko prepares... Your app becomes a masterpiece!");
            //loaders.Add("Professor Neko's whiskers are twitching...");
            //loaders.Add("Professor Neko's whiskers are twitching...");
            //loaders.Add("Professor Neko's whiskers are twitching...");
            //loaders.Add("Professor Neko's whiskers are twitching...");
            //loaders.Add("...Your app is almost ready to pounce!");
            //loaders.Add("...Your app is almost ready to pounce!");
            //loaders.Add("...Your app is almost ready to pounce!");
            //loaders.Add("Hold tight while Professor Neko sprinkle some coding fairy dust!");
            //loaders.Add("Hang in there! We're on the brink of digital awesomeness!");
            //loaders.Add("Hang in there! We're on the brink of digital awesomeness!");
            //loaders.Add("Hang in there! We're on the brink of digital awesomeness!");
            counter = 0;

            tmr_start.Start();

            mainForm = new MainForm(this);
        }

        private void tmr_start_Tick(object sender, EventArgs e)
        {
            
            if (counter > loaders.Count - 1)
            {
                tmr_start.Stop();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                lbl_loader.Text = loaders[counter];
                counter++;
            }
        }
    }
}
