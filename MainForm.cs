using System;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using IdeasAi.PageForms;
using IdeasAi.pages;

namespace IdeasAi
{
    public partial class MainForm : KryptonForm
    {
        // PAGE FORMS
        public frm_home frm_home = new frm_home();
        public frm_settings frm_settings = new frm_settings();
        public frm_notebook frm_notebook = new frm_notebook();
        //

        public static MainForm instance;


        Button btn_active;
        Color color_active = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
        Color color_inactive = System.Drawing.Color.Transparent;



        public MainForm()
        {
            InitializeComponent();
            setActiveBtn((object)this.btn_home);
            loadForm(frm_home, pnl_content);

            btn_active = this.btn_home;
            lbl_currentPage.Text = btn_active.Text;
            
            instance = this;
        }


        public void loadForm(Form frm, Control container)
        {
            removeForm(frm, container);
            frm.Owner = this;
            frm.TopLevel = false;
            container.Controls.Add(frm);
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void removeForm(Form frm, Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is Form form)
                {
                    container.Controls.Remove(control);

                    break;
                }
            }
        }

        public void setActiveBtn(object btn)
        {
            removeActiveBtn();
            if ((Button)btn != btn_active)
            {
                btn_active = (Button)btn;
                btn_active.BackColor = color_active;
                lbl_currentPage.Text = btn_active.Text;
            }
        }

        private void removeActiveBtn()
        {
            foreach (var btn in pnl_pageTabs.Controls)
            {
                if ((Button)btn == btn_active)
                {
                    btn_active.BackColor = color_inactive;
                    break;
                }
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            setActiveBtn(sender);


            loadForm(frm_home, pnl_content);
        }

        private void btn_workspace_Click(object sender, EventArgs e)
        {
            setActiveBtn(sender);
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            setActiveBtn(sender);
        }

        private void btn_unde_Click(object sender, EventArgs e)
        {

            setActiveBtn(sender);
            loadForm(frm_settings, pnl_content);
        }

        private void btn_notebook_Click(object sender, EventArgs e)
        {
            setActiveBtn(sender);
            loadForm(frm_notebook, pnl_content);

            

            frm_notebook.displaySavedIdeas();
        }
    }
}
