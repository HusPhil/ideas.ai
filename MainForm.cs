using System;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using IdeasAi.PageForms;
using IdeasAi.pages;
using IdeasAi.modals;
using IdeasAi.db;
using System.Web.UI.Design;
using System.IO;
using Newtonsoft.Json.Linq;

namespace IdeasAi
{
    public partial class MainForm : Form
    {
        //show or hide side pnl
        private bool showMode = true;
        public bool sliding = false;


        //pnl_header configs
        private bool isDragging = false;
        private Point lastCursorPosition;
        private bool isFullScreen = false;
        private FormWindowState normalWindowState;

        // json configs
        public JObject decors;
        public JObject settings;

        //loading states
        public const int state_loadMindmap = 1;
        public const int state_loadConsultation = 2;

        // PAGE FORMS
        public frm_home frm_home;
        public frm_consultation frm_consultation;
        public frm_workspace frm_workspace;
        public frm_notebook frm_notebook;
        public frm_mindmap frm_mindmap;
        //
        // MODALS
        //
        public Form modalBG;
        public mdl_notebookSettings mdl_notebookSettings;
        public mdl_organize mdl_organize;
        public mdl_saveNotes mdl_save;
        public mdl_saveDocs mdl_saveDocs;
        public mdl_NotesOptions mdl_editNotes;
        public mdl_loading mdl_loading;
        public ModalSetter mdl_setter;

        public DBManager_Note dbManager_Note = new DBManager_Note();
        public DBManager_Docs dbManager_Docs = new DBManager_Docs();


        public Button btn_active;
        Color color_active = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
        Color color_inactive = System.Drawing.Color.Transparent;

        public MainForm()
        {

            InitializeComponent();
            frm_home = new frm_home(this);
            frm_consultation = new frm_consultation(this);
            frm_notebook =  new frm_notebook(this);
            frm_mindmap = new frm_mindmap(this);
            frm_workspace = new frm_workspace(this);

            mdl_notebookSettings = new mdl_notebookSettings(this);
            mdl_save = new mdl_saveNotes(this);
            mdl_saveDocs = new mdl_saveDocs(this);
            mdl_editNotes = new mdl_NotesOptions(this);
            mdl_loading = new mdl_loading(this);
            modalBG = new Form();
            mdl_setter = new ModalSetter(this);
            mdl_organize = new mdl_organize(this);
            //modalManager = new ModalManager(this);

            btn_active = btn_mindmap;
            setActiveBtn((object)btn_mindmap, pnl_pageTabs);
            loadForm(frm_home, pnl_content);
            
            lbl_currentPage.Text = btn_active.Text;
            Console.WriteLine(this.Width + "::" + this.Height);

            using (StreamReader reader = File.OpenText("decors.json"))
            {
                string decorsJson = reader.ReadToEnd();
                decors = JObject.Parse(decorsJson);
            }

            using (StreamReader reader = File.OpenText("settings.json"))
            {
                string settingsJson = reader.ReadToEnd();
                settings = JObject.Parse(settingsJson);
            }

            setActiveBtn((object)btn_home, pnl_pageTabs);
        }

        
        public void setModalBackground(Form callerForm)
        {
            modalBG.Owner = this;
            modalBG.StartPosition = FormStartPosition.Manual;
            modalBG.FormBorderStyle = FormBorderStyle.None;
            modalBG.Opacity = .50d;
            modalBG.BackColor = Color.Black;
            modalBG.Size = this.Size;
            modalBG.Location = callerForm.Owner.Location;
            modalBG.ShowInTaskbar = false;
            modalBG.Show();
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
            if ((Button)btn != btn_active && btn_active != null)
            {
                removeActiveBtn();
                btn_active = (Button)btn;
                btn_active.BackColor = ColorTranslator.FromHtml((string)decors["Color"]["secondary100"]);
                btn_active.Parent.Padding = new Padding(15,0,0,0);
                btn_active.Parent.BackColor = ColorTranslator.FromHtml((string)decors["Color"]["accent"]);
                lbl_currentPage.Text = btn_active.Text;
            }
        }

        private void removeActiveBtn()
        {
            if(btn_active != null)
            {
                btn_active.BackColor = ColorTranslator.FromHtml((string)decors["Color"]["primary"]);
                btn_active.Parent.Padding = new Padding(0);
            }

        }

        public void addNotification(string type, string typeTxt, string typeInfo)
        {
            var notif = new mdl_notif(this, type);
            notif.lbl_type.Text = typeTxt;

            if (mdl_notif.instancesCount > 1) notif.lbl_type.Text = typeTxt;

            notif.lbl_info.Text = typeInfo;
            notif.TopLevel = false;
            this.Controls.Add(notif);
            notif.Show();
            notif.BringToFront();
        }

        public mdl_notif addAsyncNotification(string type, string typeTxt, string typeInfo)
        {
            var notif = new mdl_notif(this, type);
            notif.lbl_type.Text = typeTxt;

            if (mdl_notif.instancesCount > 1) notif.lbl_type.Text = typeTxt;

            notif.lbl_info.Text = typeInfo;
            notif.TopLevel = false;
            this.Controls.Add(notif);
      
            return notif;
        }



        private void btn_home_Click(object sender, EventArgs e)
        {
            setActiveBtn(sender, pnl_pageTabs);


            loadForm(frm_home, pnl_content);
        }
        private void btn_consultation_Click(object sender, EventArgs e)
        {
            setActiveBtn(sender, pnl_pageTabs);


            loadForm(frm_consultation, pnl_content);
        }

        private void btn_workspace_Click(object sender, EventArgs e)
        {
            setActiveBtn(sender, pnl_pageTabs);
            loadForm(frm_workspace, pnl_content);
        }        

        private void btn_notebook_Click(object sender, EventArgs e)
        {
            btn_notebook.Enabled = false;
            setActiveBtn(sender, pnl_pageTabs);
            loadForm(frm_notebook, pnl_content);

            if (frm_notebook.btn_activeTab == frm_notebook.getBtnNotesTab())
            {
                frm_notebook.displaySavedIdeas(dbManager_Note);
            }
            else if (frm_notebook.btn_activeTab == frm_notebook.getBtnDocsTab())
            {
                frm_notebook.displaySavedIdeas(dbManager_Docs);
            }
            


        }

        private void btn_mindmap_Click(object sender, EventArgs e)
        {
            setActiveBtn(sender, pnl_pageTabs);
            loadForm(frm_mindmap, pnl_content);
        }
        public void setNotifPosition()
        {
            int offset = mdl_notif.instancesCount;
            foreach (var c in this.Controls)
            {
                if (c is mdl_notif)
                {
                    mdl_notif notifControl = c as mdl_notif;
                    if (notifControl != null)
                    {
                        int notifX = (this.Width - notifControl.Width) - 34;
                        int notifY = (this.Height - (notifControl.Height)) - ((notifControl.Height + 5) * offset--);

                        if (notifY > (this.Height - (notifControl.Height)) - (notifControl.Height + 5)) notifY = (this.Height - (notifControl.Height)) - (notifControl.Height + 5); 
                        //Console.WriteLine(notifControl.lbl_type);
                        //Console.WriteLine(notifY);

                        notifControl.Location = new Point(notifX, notifY);
                    }
                }
            }
        }
        
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            setNotifPosition();

        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_howToUse_Click(object sender, EventArgs e)
        {
            setModalBackground(frm_home);
            mdl_howToUse mdl_HowToUse = new mdl_howToUse(this);
            mdl_HowToUse.ShowDialog();
        }

        private void pnl_formHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPosition = e.Location;
            }
        }

        private void pnl_formHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - lastCursorPosition.X;
                int deltaY = e.Y - lastCursorPosition.Y;
                this.Location = new Point(this.Left + deltaX, this.Top + deltaY);
            }
        }

        private void pnl_formHeader_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void pnl_formHeader_DoubleClick(object sender, EventArgs e)
        {
            ToggleFullScreen();
        }
        private void ToggleFullScreen()
        {
            if (isFullScreen)
            {
                this.WindowState = normalWindowState;
                isFullScreen = false;
            }
            else
            {
                normalWindowState = this.WindowState;
                this.WindowState = FormWindowState.Maximized;
                isFullScreen = true;
            }
        }

        private void btn_showOrHide_Click(object sender, EventArgs e)
        {
            if (showMode)
            {
                showMode = false;
            }
            else
            {
                showMode = true;
            }
            tmr_animation.Start();
            sliding = true;
        }

        private void tmr_animation_Tick(object sender, EventArgs e)
        {
            if(showMode)
            {
                if (pnl_sideContent.Width >= 320)
                {
                    tmr_animation.Stop();
                    pnl_sideContent.Width = 320;
                    pnl_sideContent.Width += 1;
                    sliding = false;
                    pnl_sideContent.Width -= 1;
                }
                else
                {
                    pnl_sideContent.Width += 20;
                }
            }
            else
            {
                if (pnl_sideContent.Width <= 170)
                {
                    tmr_animation.Stop();
                    pnl_sideContent.Width = 150;
                    pnl_sideContent.Width += 1;
                    sliding = false;
                    pnl_sideContent.Width -= 1;
                }
                else
                {
                    pnl_sideContent.Width -= 20;
                }
            }
            
        }
        
        //GETTERS
        public ref Button getBtnNotebook()
        {
            return ref btn_notebook;
        }
        public ref Button getBtnWorkspace()
        {
            return ref btn_workspace;
        }
        public ref Button getBtnHome()
        {
            return ref btn_home;
        }
        public ref Button getBtnConsult()
        {
            return ref btn_consultation;
        }
        public ref Panel getPnlContent()
        {
            return ref pnl_content;
        }
        public ref Panel getPnlPageTabs()
        {
            return ref pnl_pageTabs; 
        }
        public ref Button getBtnMindmap()
        {
            return ref btn_mindmap; 
        }
        public ref Timer getTmrAnim()
        {
            return ref tmr_animation;
        }
    }
}
