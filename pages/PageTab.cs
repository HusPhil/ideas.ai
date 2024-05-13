using IdeasAi.PageForms;
using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IdeasAi.pages
{
    public class PageTab
    {
        MainForm mainForm;
        public bool active;
        public System.Windows.Forms.Label title { get; set; }
        public Panel container { get; set; }
        public frm_consultation page { get; set; }
        System.Windows.Forms.Button btnClose { get; set; }

        public PageTab()
        {

        }

        public PageTab(MainForm mainForm, Panel container, frm_consultation page, System.Windows.Forms.Label title, System.Windows.Forms.Button btnClose)
        {
            this.mainForm = mainForm;
            this.container = container;
            this.page = page;
            this.title = title;
            this.btnClose = btnClose;

            title.Text = "New tab";
            container.Click += (s, ev) => container_Click();
            title.Click += (s, ev) => container_Click();
            page.btn_send.Click += (s, ev) => sendPage_Click();
            btnClose.Click += (s, ev) => btnClose_Click();

            


            setActive();

            mainForm.setActiveBtn(mainForm.getBtnConsult(), mainForm.getPnlPageTabs());
            mainForm.loadForm(page, mainForm.getPnlContent());
        }

        public void container_Click()
        {
            setActive();


            mainForm.setActiveBtn(mainForm.getBtnConsult(), mainForm.getPnlPageTabs());
            mainForm.loadForm(page, mainForm.getPnlContent());
        }

        private void setActive()
        {
            removeActive();
            this.active = true;
            this.container.BackColor = ColorTranslator.FromHtml((string)mainForm.decors["Themes"]["LightTheme"]["accent200"]);

        }

        public void removeActive()
        {
            foreach (var tab in mainForm.tabs)
            {
                if (tab.active)
                {
                    tab.active = false;
                    tab.container.BackColor = ColorTranslator.FromHtml((string)mainForm.decors["Themes"]["LightTheme"]["accent100"]);
                }
            }
        }

        private void sendPage_Click()
        {
            title.Text = page.txb_Consult.Text;
        }

        private void btnClose_Click()
        {
            mainForm.tabs.Remove(this);
            mainForm.pnl_addTab.Controls.Remove(container);
            container.Dispose();
            page.Dispose();
            btnClose.Dispose();
            title.Dispose();
        }
    }
}
