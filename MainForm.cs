using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using WinformDemo3.PageForms_test;

namespace WinformDemo3
{
    public partial class MainForm : KryptonForm
    {
        Button btn_active;
        Color color_active = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
        Color color_inactive = System.Drawing.Color.Transparent;
        testForm tF = new testForm();

        public MainForm()
        {
            InitializeComponent();
            setActiveBtn((object) this.btn_home);
            btn_active = this.btn_home;
            lbl_currentPage.Text = btn_active.Text;


        }

        private void setActiveBtn(object btn)
        {
            removeActiveBtn();
            if ((Button) btn != btn_active)
            {
                btn_active = (Button) btn;
                btn_active.BackColor = color_active;
                lbl_currentPage.Text = btn_active.Text;
            }
        }

        private void removeActiveBtn()
        {
            foreach(var btn in pnl_pageTabs.Controls)
            {
                if((Button) btn == btn_active)
                {
                    btn_active.BackColor = color_inactive;
                    break;
                }
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            setActiveBtn(sender);
            tF.TopLevel = false;
            pnl_content.Controls.Add(tF);
            tF.BringToFront();
            tF.Dock = DockStyle.Fill;
            tF.Show();
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
        }
    }
}
