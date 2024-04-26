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
using IdeasAi.Properties;

namespace IdeasAi
{
    public partial class MainForm : Form
    {
        //show or hide side pnl
        private bool showMode = true;
        public bool sliding = false;
        PictureBox pb_active;

        // json configs
        public JObject decors;
        public JObject settings;

        // database
        public DBManager_Note dbManager_Note;
        public DBManager_Docs dbManager_Docs;

        //pnl_header configs
        private bool isDragging = false;
        private Point lastCursorPosition;
        private bool isFullScreen = false;
        private FormWindowState normalWindowState;

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
        //public mdl_notebookSettings mdl_notebookSettings;
        //public mdl_saveNotes mdl_save;
        //public mdl_saveDocs mdl_saveDocs;
        //public mdl_NotesOptions mdl_editNotes;
        //public mdl_DocsOptions mdl_editDocs;
        public mdl_organize mdl_organize;
        public mdl_loading mdl_loading;
        public ModalManager mdl_setter;

        public Button btn_active;

        public MainForm()
        {

            InitializeComponent();
            InitializeConfigs();

            dbManager_Note = new DBManager_Note(this);
            dbManager_Docs = new DBManager_Docs(this);

            frm_home = new frm_home(this);
            frm_consultation = new frm_consultation(this);
            frm_notebook =  new frm_notebook(this);
            frm_mindmap = new frm_mindmap(this);
            frm_workspace = new frm_workspace(this);

            //mdl_notebookSettings = new mdl_notebookSettings(this);
            //mdl_save = new mdl_saveNotes(this);
            //mdl_saveDocs = new mdl_saveDocs(this);
            //mdl_editNotes = new mdl_NotesOptions(this);
            //mdl_editDocs = new mdl_DocsOptions(this);
            mdl_loading = new mdl_loading(this);
            modalBG = new Form();
            mdl_organize = new mdl_organize(this);
            mdl_setter = new ModalManager(this);

            pb_active = new PictureBox();
            pb_active.BackColor = Color.Transparent;
            pb_active.Image = Resources.activeState;
            pb_active.Dock = DockStyle.Left;
            pb_active.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_active.Size = new Size(37, 48);

            btn_active = btn_mindmap;
            lbl_currentPage.Text = btn_active.Text;

            loadForm(frm_home, pnl_content);
            setActiveBtn((object)btn_home, pnl_pageTabs);
            setThemeMode("light");
        }

        private void InitializeConfigs()
        {
            using (StreamReader reader = File.OpenText("configs/decors.json"))
            {
                string decorsJson = reader.ReadToEnd();
                decors = JObject.Parse(decorsJson);
            }
            setSettingsConfig();
            
        }
        public void setSettingsConfig()
        {
            using (StreamReader reader = File.OpenText("configs/settings.json"))
            {
                string settingsJson = reader.ReadToEnd();
                settings = JObject.Parse(settingsJson);
            }
        }
        
        //CAN BE MODIFIED, ADD TO MODAL SETTER CLASS
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
                        int notifY = (this.Height) - ((notifControl.Height + 5) * offset--);

                        if (notifY > (this.Height) - (notifControl.Height + 5)) notifY = (this.Height - (notifControl.Height)) - (notifControl.Height + 5); 

                        notifControl.Location = new Point(notifX, notifY);
                    }
                }
            }
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
        public void removeForm(Form frm, Control container)
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
                btn_active.Parent.Controls.Add(pb_active);
                btn_active.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["LightTheme"]["accent"]);
                lbl_currentPage.Text = btn_active.Text;
            }
        }
        private void removeActiveBtn()
        {
            if(btn_active != null)
            {
                btn_active.Parent.Controls.Remove(pb_active);
                btn_active.BackColor = Color.Transparent;
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

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            setNotifPosition();

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
            InitializeConfigs();
            frm_notebook.showAllIdeas();
            setActiveBtn(sender, pnl_pageTabs);
            loadForm(frm_notebook, pnl_content);

        }
        private void btn_mindmap_Click(object sender, EventArgs e)
        {
            setActiveBtn(sender, pnl_pageTabs);
            loadForm(frm_mindmap, pnl_content);
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
        private void btn_toggleDarkMode_Click(object sender, EventArgs e)
        {
            if (btn_toggleDarkMode.Dock == DockStyle.Right)
            {
                setThemeMode("dark");
            }
            else
            {
                setThemeMode("light");
            }
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

        public void setThemeMode(string theme)
        {
            switch (theme.ToLower())
            {
                case "light":
                    toggleLightMode();
                    break;
                case "dark":
                    toggleDarkMode();
                    break;
            }
        }
        private void toggleDarkMode()
        {
            btn_toggleDarkMode.Dock = DockStyle.Left;


            this.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["DarkTheme"]["primary"]);
            this.pnl_menuSect.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["DarkTheme"]["primary100"]);
            frm_home.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["DarkTheme"]["primary100"]);
            frm_consultation.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["DarkTheme"]["primary100"]);
            frm_notebook.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["DarkTheme"]["primary100"]);
            frm_workspace.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["DarkTheme"]["primary100"]);
            frm_workspace.spl_workspace.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["DarkTheme"]["primary100"]);
            frm_mindmap.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["DarkTheme"]["primary100"]);
            frm_mindmap.spl_mindmap.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["DarkTheme"]["primary100"]);

            pnl_btnCont.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["DarkTheme"]["primary100"]);
            btn_toggleDarkMode.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["LightTheme"]["primary100"]);
            btn_toggleDarkMode.Image = Resources.darkModeBtn;

        }
        private void toggleLightMode()
        {
            btn_toggleDarkMode.Dock = DockStyle.Right;


            this.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["LightTheme"]["primary"]);
            this.pnl_menuSect.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["LightTheme"]["primary100"]);
            frm_home.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["LightTheme"]["primary100"]);
            frm_consultation.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["LightTheme"]["primary100"]);
            frm_notebook.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["LightTheme"]["primary100"]);
            frm_workspace.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["LightTheme"]["primary100"]);
            frm_workspace.spl_workspace.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["LightTheme"]["primary100"]);
            frm_mindmap.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["LightTheme"]["primary100"]);
            frm_mindmap.spl_mindmap.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["LightTheme"]["primary100"]);

            pnl_btnCont.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["DarkTheme"]["primary"]);
            btn_toggleDarkMode.BackColor = ColorTranslator.FromHtml((string)decors["Themes"]["DarkTheme"]["primary100"]);
            btn_toggleDarkMode.Image = Resources.lightModeBtn;

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

    }
}
