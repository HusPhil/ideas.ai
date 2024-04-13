using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using IdeasAi.db;
using IdeasAi.Ideas;
using IdeasAi.modals;

namespace IdeasAi.pages
{
    public partial class frm_notebook: Form
    {
        //public string current_title;
        //public Guid current_id;
        public DBObjectManager saver_obj;
        public MainForm mainForm;
        private Panel pnl_tabSelect;
        private TableLayoutPanel tbpnl_tabs;
        private Button btn_docsTab;
        private Button btn_notesTab;
        private FlowLayoutPanel pnl_container;
        public Button btn_activeTab;

        public frm_notebook(MainForm _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;

            this.setActiveBtn(btn_notesTab, tbpnl_tabs);
        }
        private void InitializeComponent()
        {
            this.pnl_container = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_tabSelect = new System.Windows.Forms.Panel();
            this.tbpnl_tabs = new System.Windows.Forms.TableLayoutPanel();
            this.btn_docsTab = new System.Windows.Forms.Button();
            this.btn_notesTab = new System.Windows.Forms.Button();
            this.pnl_tabSelect.SuspendLayout();
            this.tbpnl_tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_container
            // 
            this.pnl_container.AutoScroll = true;
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(20, 86);
            this.pnl_container.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(890, 510);
            this.pnl_container.TabIndex = 0;
            // 
            // pnl_tabSelect
            // 
            this.pnl_tabSelect.BackColor = System.Drawing.Color.Transparent;
            this.pnl_tabSelect.Controls.Add(this.tbpnl_tabs);
            this.pnl_tabSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_tabSelect.Location = new System.Drawing.Point(20, 20);
            this.pnl_tabSelect.Name = "pnl_tabSelect";
            this.pnl_tabSelect.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_tabSelect.Size = new System.Drawing.Size(890, 66);
            this.pnl_tabSelect.TabIndex = 1;
            // 
            // tbpnl_tabs
            // 
            this.tbpnl_tabs.ColumnCount = 2;
            this.tbpnl_tabs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbpnl_tabs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbpnl_tabs.Controls.Add(this.btn_docsTab, 0, 0);
            this.tbpnl_tabs.Controls.Add(this.btn_notesTab, 0, 0);
            this.tbpnl_tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpnl_tabs.Location = new System.Drawing.Point(10, 10);
            this.tbpnl_tabs.Name = "tbpnl_tabs";
            this.tbpnl_tabs.RowCount = 1;
            this.tbpnl_tabs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpnl_tabs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbpnl_tabs.Size = new System.Drawing.Size(870, 46);
            this.tbpnl_tabs.TabIndex = 3;
            // 
            // btn_docsTab
            // 
            this.btn_docsTab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_docsTab.BackColor = System.Drawing.Color.Transparent;
            this.btn_docsTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.btn_docsTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_docsTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btn_docsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_docsTab.Font = new System.Drawing.Font("Cascadia Code Light", 9.5F);
            this.btn_docsTab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_docsTab.Location = new System.Drawing.Point(576, 3);
            this.btn_docsTab.Name = "btn_docsTab";
            this.btn_docsTab.Size = new System.Drawing.Size(153, 40);
            this.btn_docsTab.TabIndex = 4;
            this.btn_docsTab.Text = "Documents";
            this.btn_docsTab.UseVisualStyleBackColor = false;
            this.btn_docsTab.Click += new System.EventHandler(this.btn_docsTab_Click);
            // 
            // btn_notesTab
            // 
            this.btn_notesTab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_notesTab.BackColor = System.Drawing.Color.Transparent;
            this.btn_notesTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.btn_notesTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_notesTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btn_notesTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notesTab.Font = new System.Drawing.Font("Cascadia Code Light", 9.5F);
            this.btn_notesTab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_notesTab.Location = new System.Drawing.Point(141, 3);
            this.btn_notesTab.Name = "btn_notesTab";
            this.btn_notesTab.Size = new System.Drawing.Size(153, 40);
            this.btn_notesTab.TabIndex = 3;
            this.btn_notesTab.Text = "Notes";
            this.btn_notesTab.UseVisualStyleBackColor = false;
            this.btn_notesTab.Click += new System.EventHandler(this.btn_notesTab_Click);
            // 
            // frm_notebook
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(930, 616);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_container);
            this.Controls.Add(this.pnl_tabSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_notebook";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Load += new System.EventHandler(this.frm_notebook_Load);
            this.pnl_tabSelect.ResumeLayout(false);
            this.tbpnl_tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        public void displaySavedIdeas(DatabaseManager db)
        {
            pnl_container.Controls.Clear();
            var saved_ideas = db.retrieveDBRecords();

            Console.WriteLine(saved_ideas);

            bool verticalScrollBarVisible = false;

            foreach (var idea in saved_ideas)
            {
                Panel pnl_idea = new Panel();
                pnl_idea.BorderStyle = BorderStyle.FixedSingle;
                pnl_idea.BackColor = Color.Gray;
                pnl_idea.Size = new Size((pnl_container.Width / 3) - 6, 200);
                pnl_idea.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);

                Panel pnl_header = new Panel();
                pnl_header.BorderStyle = BorderStyle.None;
                pnl_header.Dock = DockStyle.Top;
                pnl_header.Size = new Size(50,50);
                pnl_header.Padding = new Padding(0, 0, 20, 0);


                Button btn_edit = new Button();
                btn_edit.Image = global::IdeasAi.Properties.Resources.more;


                if (db.GetType().Equals(typeof(DBManager_Note)))
                {
                    btn_edit.Click += (sender, e) => btn_showMoreNotes_click(idea);
                }
                else if (db.GetType().Equals(typeof(DBManager_Docs)))
                {
                    btn_edit.Click += (sender, e) => btn_showMoreDocs_click(idea);
                }

                btn_edit.BackColor = Color.Transparent;
                btn_edit.AutoSize = false;
                btn_edit.Size = new Size(32, 32);
                btn_edit.Dock = DockStyle.Right;
                btn_edit.FlatStyle = FlatStyle.Flat;
                btn_edit.FlatAppearance.BorderSize = 0;
                btn_edit.Margin = new Padding(0,0,20,0);

                Label titleLabel = new Label();
                titleLabel.Text = idea.Title;
                titleLabel.Dock = DockStyle.Top;
                titleLabel.Padding = new System.Windows.Forms.Padding(35, 0, 35, 0);
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.AutoEllipsis = true;
                titleLabel.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pnl_idea.Controls.Add(titleLabel);
                pnl_header.Controls.Add(btn_edit);

                pnl_idea.Controls.Add(pnl_header);

                Panel pnl_btns = new Panel();
                pnl_btns.Dock = DockStyle.Bottom;
                pnl_btns.Height = titleLabel.Height + 20;
                pnl_btns.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20); ;


                Button btn_view = new Button();
                btn_view.Text = "View";
                btn_view.Click += (sender, e) => displayNote_click(idea, db);
                btn_view.Dock = DockStyle.Fill;
                btn_view.FlatStyle = FlatStyle.Flat;

                pnl_btns.Controls.Add(btn_view);
                pnl_idea.Controls.Add(pnl_btns);
                pnl_btns.Padding = new System.Windows.Forms.Padding(15,0,15,0);

                int BtnSize = ((pnl_btns.Width) / 3);

                btn_view.Size = new Size(BtnSize, pnl_btns.Height - 8) ;

                Label dateLabel = new Label();
                dateLabel.Text = $"Date Modified: {idea.DateCreated.Date.ToString("yyyy-MM-dd")}";
                dateLabel.Dock = DockStyle.Bottom;
                dateLabel.TextAlign = ContentAlignment.MiddleCenter;
                dateLabel.Location = new Point(10, 50); // Adjust location as needed
                dateLabel.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pnl_idea.Controls.Add(dateLabel);

                pnl_container.Controls.Add(pnl_idea);

                // No need to adjust the width here
            }

            // Check if the vertical scrollbar is visible after adding all ideas
            verticalScrollBarVisible = pnl_container.VerticalScroll.Visible;

            // If the vertical scrollbar is visible, adjust the width of each pnl_idea
            if (verticalScrollBarVisible)
            {
                foreach (Control control in pnl_container.Controls)
                {
                    if (control is Panel pnl_idea)
                    {
                        pnl_idea.Size = new Size((pnl_container.Width / 3) - 6 - (SystemInformation.VerticalScrollBarWidth / 3), 200);

                    }
                }
            }

        }
        public void setActiveBtn(object btn, TableLayoutPanel pnl)
        {
            if ((Button)btn != btn_activeTab)
            {
                removeActiveBtn(pnl);
                btn_activeTab = (Button)btn;
                btn_activeTab.BackColor = btn_notesTab.FlatAppearance.MouseOverBackColor;
            }
        }
        private void removeActiveBtn(TableLayoutPanel pnl)
        {
            foreach (var btn in pnl.Controls)
            {
                if ((Button)btn == btn_activeTab)
                {
                    btn_activeTab.BackColor = btn_notesTab.FlatAppearance.MouseDownBackColor;
                    break;
                }
            }
        }
        private void btn_showMoreNotes_click(DBObjectManager idea)
        {
            this.saver_obj = idea;
            mainForm.mdl_setter.OpenModal(this, typeof(mdl_NotesOptions), mainForm);

        }
        private void btn_showMoreDocs_click(DBObjectManager idea)
        {
            this.saver_obj = idea;
            mainForm.mdl_setter.OpenModal(this, typeof(mdl_DocsOptions), mainForm);

        }
        private void displayNote_click(DBObjectManager dom, DatabaseManager db)
        {
            if (db.GetType().Equals(typeof(DBManager_Note)))
            {
            mainForm.loadForm(mainForm.frm_consultation,mainForm.getPnlContent());
            mainForm.setActiveBtn(mainForm.getBtnHome(), mainForm.getPnlPageTabs());
            mainForm.frm_consultation.displayResult(dom.Content);
            mainForm.frm_consultation.getSaveBtn().Enabled = false;
            mainForm.frm_consultation.getPrintBtn().Enabled = !false;
            mainForm.frm_consultation.getToWorkspaceBtn().Enabled = !false;
            
            mainForm.frm_consultation.content_holder = dom.Content;
            mainForm.frm_consultation.input_holder = dom.Title;
            

            }
            else if (db.GetType().Equals(typeof(DBManager_Docs)))
            {
                mainForm.loadForm(mainForm.frm_workspace, mainForm.getPnlContent());
                mainForm.setActiveBtn(mainForm.getBtnWorkspace(), mainForm.getPnlPageTabs());
                mainForm.frm_workspace.getSaverObj().UUID = dom.UUID;
                mainForm.frm_workspace.getTxbEditor().Text = dom.Content;
                mainForm.frm_workspace.getTxbDocsTitle().Text = dom.Title; 
                mainForm.frm_workspace.getLblLastDateSaved().Text = $"Last Modified: {dom.DateCreated.ToString("yyyy-MM-dd hh:mm tt")}"; ;
            }
        }
        private void frm_notebook_Load(object sender, EventArgs e)
        {
            displaySavedIdeas(mainForm.dbManager_Note);
        }
        private void btn_notesTab_Click(object sender, EventArgs e)
        {
            mainForm.frm_notebook.displaySavedIdeas(mainForm.dbManager_Note);
            this.setActiveBtn(sender, tbpnl_tabs);
        }
        private void btn_docsTab_Click(object sender, EventArgs e)
        {
            mainForm.frm_notebook.displaySavedIdeas(mainForm.dbManager_Docs);
            this.setActiveBtn(sender, tbpnl_tabs); 

        }

        //GETTERS
        public ref TableLayoutPanel getTbpnlTabs()
        {
            return ref tbpnl_tabs;
        }
        public ref Button getBtnNotesTab()
        {
            return ref btn_notesTab;
        }
        public ref Button getBtnDocsTab()
        {
            return ref btn_docsTab;
        }
    }
}
