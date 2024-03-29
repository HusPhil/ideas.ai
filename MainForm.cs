using System;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using IdeasAi.PageForms;
using IdeasAi.pages;
using IdeasAi.modals;
using IdeasAi.db;

namespace IdeasAi
{
    public partial class MainForm : KryptonForm
    {
        // PAGE FORMS
        public frm_home frm_home;
        public frm_workspace frm_workspace;
        public frm_settings frm_settings;
        public frm_notebook frm_notebook;
        public frm_mindmap frm_mindmap;
        //
        // MODALS
        //
        public mdl_saveNotes mdl_save;
        public mdl_saveDocs mdl_saveDocs;
        public mdl_editNotes mdl_editNotes;
        public ModalSetter mdl_setter;

        public DBManager_Note dbManager_Idea = new DBManager_Note();


        Button btn_active;
        Color color_active = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
        Color color_inactive = System.Drawing.Color.Transparent;

        public MainForm()
        {
            InitializeComponent();
            frm_home = new frm_home(this);
            frm_notebook =  new frm_notebook(this);
            frm_settings = new frm_settings(this);
            frm_workspace = new frm_workspace(this);
            frm_mindmap = new frm_mindmap(this);

            mdl_save = new mdl_saveNotes(this);
            mdl_saveDocs = new mdl_saveDocs(this);
            mdl_editNotes = new mdl_editNotes(this);
            mdl_setter = new ModalSetter(this);

            setActiveBtn((object)this.btn_home, pnl_pageTabs);
            loadForm(frm_home, pnl_content);

            btn_active = this.btn_home;
            lbl_currentPage.Text = btn_active.Text;
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

        public void setActiveBtn(object btn, Panel pnl)
        {
            if ((Button)btn != btn_active)
            {
            removeActiveBtn(pnl);
                btn_active = (Button)btn;
                btn_active.BackColor = color_active;
                lbl_currentPage.Text = btn_active.Text;
            }
        }

        private void removeActiveBtn(Panel pnl)
        {
            foreach (var btn in pnl.Controls)
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
            setActiveBtn(sender, pnl_pageTabs);


            loadForm(frm_home, pnl_content);
        }

        private void btn_workspace_Click(object sender, EventArgs e)
        {
            setActiveBtn(sender, pnl_pageTabs);
            loadForm(frm_workspace, pnl_content);
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            setActiveBtn(sender, pnl_pageTabs);
        }

        private void btn_unde_Click(object sender, EventArgs e)
        {

            setActiveBtn(sender, pnl_pageTabs);
            loadForm(frm_settings, pnl_content);

            mdl_setter.OpenModal(this, typeof(mdl_saveDocs), this);
        }

        private void btn_notebook_Click(object sender, EventArgs e)
        {
            setActiveBtn(sender, pnl_pageTabs);
            loadForm(frm_notebook, pnl_content);

            

            frm_notebook.displaySavedIdeas();
        }

        private void btn_mindmap_Click(object sender, EventArgs e)
        {
            setActiveBtn(sender, pnl_pageTabs);
            loadForm(frm_mindmap, pnl_content);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            frm_notebook.displaySavedIdeas();
;        }

        //GETTERS
        public ref Button getBtnNotebook()
        {
            return ref btn_notebook;
        }
        public ref Button getBtnHome()
        {
            return ref btn_home;
        }
        public ref Panel getPnlContent()
        {
            return ref pnl_content;
        }
        public ref FlowLayoutPanel getPnlPageTabs()
        {
            return ref pnl_pageTabs; 
        }
        public ref Button getBtnMindmap()
        {
            return ref btn_mindmap; 
        }


    }
}
