using System;
using System.Drawing;
using System.Windows.Forms;
using IdeasAi.db;
using IdeasAi.modals;

namespace IdeasAi.pages
{
    public partial class frm_notebook : Form
    {
        public const string howToUse = @"
        This is how to use the notebook kineme:
        firrst: you have to kineme              E
        ";
        public string currentNotebook;
        public DBObjectManager saver_obj;
        public MainForm mainForm;
        public Button btn_activeTab = new Button();

        public frm_notebook(MainForm _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;

            setNotebookKeys(false);
            cb_dbSelector.SelectedIndex = 0;

            btn_activeTab = btn_notesTab;
            btn_notesTab.BackColor = ColorTranslator.FromHtml((string)mainForm.decors["Themes"]["LightTheme"]["secondary"]);

            showAllIdeas();



        }
        private void frm_notebook_SizeChanged(object sender, EventArgs e)
        {

            if (!mainForm.sliding)
            {
                showAllIdeas();
            }
            else
            {
                pnl_container.Controls.Clear();
            }

        }

        public void setNotebookKeys(bool showLastIndex)
        {

            cb_dbSelector.Items.Clear();
            cb_dbSelector.Items.AddRange(DatabaseManager.GetDatabasePathKeys(mainForm.settings));

            if (showLastIndex)
            {
                cb_dbSelector.SelectedIndex = cb_dbSelector.Items.Count - 1;
            }
        }
        public void displaySavedIdeas(DatabaseManager db)
        {
            try
            {
                lbl_nothingFound.Visible = false;
                pnl_container.Visible = true;

                pnl_container.Controls.Clear();
                var saved_ideas = db.retrieveDBRecords();

                if (saved_ideas.Count == 0)
                {
                    lbl_nothingFound.Visible = true;
                    pnl_container.Visible = false;
                }
                else
                {
                    lbl_nothingFound.Visible = false;
                    pnl_container.Visible = true;

                    bool verticalScrollBarVisible = false;

                    int panelWidth = (pnl_container.Width / 3) - 6;

                    foreach (var idea in saved_ideas)
                    {
                        Panel pnl_idea = new Panel();
                        pnl_idea.BorderStyle = BorderStyle.FixedSingle;
                        pnl_idea.BackColor = ColorTranslator.FromHtml((string)mainForm.decors["Themes"]["LightTheme"]["secondary100"]);
                        pnl_idea.Size = new Size(panelWidth, 200);
                        pnl_idea.Padding = new Padding(0, 10, 0, 10);

                        Panel pnl_header = new Panel();

                        pnl_header.BorderStyle = BorderStyle.None;
                        pnl_header.Dock = DockStyle.Top;
                        pnl_header.Size = new Size(50, 50);
                        pnl_header.Padding = new Padding(0, 0, 20, 0);
                        pnl_header.BringToFront();

                        Button btn_edit = new Button();
                        btn_edit.Image = global::IdeasAi.Properties.Resources.more;
                        btn_edit.BackColor = Color.Transparent;
                        btn_edit.AutoSize = false;
                        btn_edit.Size = new Size(32, 32);
                        btn_edit.Dock = DockStyle.Right;
                        btn_edit.FlatStyle = FlatStyle.Flat;
                        btn_edit.FlatAppearance.BorderSize = 0;
                        btn_edit.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml((string)mainForm.decors["Themes"]["LightTheme"]["accent100"]);
                        btn_edit.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml((string)mainForm.decors["Themes"]["LightTheme"]["accent200"]);
                        btn_edit.Margin = new Padding(0, 0, 20, 0);



                        if (db.GetType() == typeof(DBManager_Note))
                        {
                            btn_edit.Click += (sender, e) => btn_showMoreNotes_click(idea);
                        }
                        else if (db.GetType() == typeof(DBManager_Docs))
                        {
                            btn_edit.Click += (sender, e) => btn_showMoreDocs_click(idea);
                        }

                        pnl_header.Controls.Add(btn_edit);
                        pnl_idea.Controls.Add(pnl_header);

                        Label titleLabel = new Label();
                        titleLabel.Text = idea.Title;
                        titleLabel.Dock = DockStyle.Fill;
                        titleLabel.Padding = new Padding(35, 0, 35, 0);
                        titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                        titleLabel.AutoEllipsis = true;
                        titleLabel.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
                        titleLabel.SendToBack();
                        pnl_header.Controls.Add(titleLabel);

                        Panel pnl_btns = new Panel();
                        pnl_btns.Dock = DockStyle.Bottom;
                        pnl_btns.Height = 10 + (titleLabel.Height / 2);
                        pnl_btns.Margin = new Padding(0, 0, 0, 20);

                        Button btn_view = new Button();
                        btn_view.Text = "View";
                        btn_view.Click += (sender, e) => displayNote_click(idea, db);
                        btn_view.Dock = DockStyle.Fill;
                        btn_view.FlatStyle = FlatStyle.Flat;
                        btn_view.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml((string)mainForm.decors["Themes"]["LightTheme"]["accent200"]);
                        btn_view.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml((string)mainForm.decors["Themes"]["LightTheme"]["accent100"]);
                        btn_view.BackColor = ColorTranslator.FromHtml((string)mainForm.decors["Themes"]["LightTheme"]["accent"]);
                        pnl_btns.Controls.Add(btn_view);
                        pnl_idea.Controls.Add(pnl_btns);
                        pnl_btns.Padding = new Padding(15, 0, 15, 0);

                        int btnSize = (pnl_btns.Width / 3);
                        btn_view.Size = new Size(btnSize, pnl_btns.Height - 8);

                        Label dateLabel = new Label();
                        dateLabel.Text = $"Date Modified: {idea.DateCreated.Date.ToString("yyyy-MM-dd")}";
                        dateLabel.Dock = DockStyle.Bottom;
                        dateLabel.TextAlign = ContentAlignment.MiddleCenter;
                        dateLabel.Location = new Point(10, 50); // Adjust location as needed
                        dateLabel.Font = new Font("Cascadia Code", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
                        pnl_idea.Controls.Add(dateLabel);

                        pnl_container.Controls.Add(pnl_idea);
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
                                pnl_idea.Size = new Size(panelWidth - (SystemInformation.VerticalScrollBarWidth / 3), 200);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mainForm.addNotification("error", "Failed to display ideas!", $"{ex.Message}");
                Console.WriteLine("Failed to display ideas! " + $"{ex.Message}");

                lbl_nothingFound.Visible = true;
                pnl_container.Visible = false;
            }

            mainForm.getBtnNotebook().Enabled = true;
        }
        public void showAllIdeas()
        {
            if (btn_activeTab.Equals(btn_docsTab))
            {
                displaySavedIdeas(mainForm.dbManager_Docs);
            }
            else
            {
                displaySavedIdeas(mainForm.dbManager_Note);
            }
        }

        public void setActiveBtn(object btn, TableLayoutPanel pnl)
        {
            if (btn is Button)
            {
                if ((Button)btn != btn_activeTab)
                {
                    removeActiveBtn(pnl);
                    btn_activeTab = (Button)btn;
                    btn_activeTab.BackColor = ColorTranslator.FromHtml((string)mainForm.decors["Themes"]["LightTheme"]["secondary"]);
                }
            }

        }
        private void removeActiveBtn(TableLayoutPanel pnl)
        {
            if (btn_activeTab != null)
            {
                btn_activeTab.BackColor = Color.Transparent;

            }
        }

        private void btn_showMoreNotes_click(DBObjectManager idea)
        {
            this.saver_obj = idea;
            //mainForm.mdl_setter.OpenModal(this, typeof(mdl_NotesOptions), mainForm);
            ModalManager.ShowModal(mainForm, this, new mdl_NotesOptions(mainForm));

        }
        private void btn_showMoreDocs_click(DBObjectManager idea)
        {
            this.saver_obj = idea;
            //mainForm.mdl_setter.OpenModal(this, typeof(mdl_DocsOptions), mainForm);
            ModalManager.ShowModal(mainForm, this, new mdl_DocsOptions(mainForm));

        }
        private void btn_notebookSettings_Click(object sender, EventArgs e)
        {
            ModalManager.ShowModal(mainForm, this, new mdl_notebookSettings(mainForm));
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
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (pnl_delDialog.Visible)
            {
                pnl_delDialog.Visible = false;
            }
            else
            {
                pnl_delDialog.Visible = true;

            }
        }
        private void btn_delConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_dbSelector.Items.Count > 1)
                {


                    cb_dbSelector.Items.Remove(currentNotebook);
                    DatabaseManager.RemoveDatabasePath(currentNotebook, chb_delFile.Checked, mainForm.settings);

                    setNotebookKeys(true);
                    mainForm.setSettingsConfig();
                    mainForm.addNotification("success", "Notebook removed!", "Notebook successfully removed!");

                }
                else
                {
                    mainForm.addNotification("error", "Deleting notebook failed!", "You can't have no notebook!");
                }
            }
            catch (Exception ex)
            {
                mainForm.addNotification("error", "Deleting notebook failed!", $"{ex.Message}");

            }
            finally
            {
                chb_delFile.Checked = false;
                pnl_delDialog.Visible = false;
            }
        }
        private void displayNote_click(DBObjectManager dom, DatabaseManager db)
        {
            if (db.GetType().Equals(typeof(DBManager_Note)))
            {
                mainForm.frm_consultation.saver_obj.Content = dom.Content;
                mainForm.frm_consultation.saver_obj.Title = dom.Title;

                mainForm.loadForm(mainForm.frm_consultation, mainForm.getPnlContent());
                mainForm.setActiveBtn(mainForm.getBtnConsult(), mainForm.getPnlPageTabs());
                mainForm.frm_consultation.displayResult(dom.Content);
                mainForm.frm_consultation.getSaveBtn().Enabled = false;
                mainForm.frm_consultation.getPrintBtn().Enabled = !false;
                mainForm.frm_consultation.getToWorkspaceBtn().Enabled = !false;



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
        private void cb_dbSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentNotebook = cb_dbSelector.SelectedItem.ToString();
            var newNotebook = (string)mainForm.settings["Database_Path"][currentNotebook];

            mainForm.dbManager_Docs.dbFilePath = newNotebook;
            mainForm.dbManager_Note.dbFilePath = newNotebook;

            lbl_currentNotebook.Text = currentNotebook;

            showAllIdeas();
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
        public ref ComboBox getCbDBSelector()
        {
            return ref cb_dbSelector;
        }
    }
}
