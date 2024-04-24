using System.Windows.Forms;

namespace IdeasAi.pages
{
    partial class frm_notebook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_tabSelect = new System.Windows.Forms.Panel();
            this.tbpnl_tabs = new System.Windows.Forms.TableLayoutPanel();
            this.btn_notesTab = new System.Windows.Forms.Button();
            this.btn_docsTab = new System.Windows.Forms.Button();
            this.lbl_currentNotebook = new System.Windows.Forms.Label();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.pnl_noteSettings = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pnl_delDialog = new System.Windows.Forms.Panel();
            this.btn_delConfirm = new System.Windows.Forms.Button();
            this.chb_delFile = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_dbSelector = new System.Windows.Forms.ComboBox();
            this.lbl_noteCurrent = new System.Windows.Forms.Label();
            this.btn_notebookSettings = new System.Windows.Forms.Button();
            this.pnl_container = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_nothingFound = new System.Windows.Forms.Label();
            this.pnl_tabSelect.SuspendLayout();
            this.tbpnl_tabs.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            this.pnl_noteSettings.SuspendLayout();
            this.pnl_delDialog.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.tbpnl_tabs.ColumnCount = 3;
            this.tbpnl_tabs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbpnl_tabs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbpnl_tabs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbpnl_tabs.Controls.Add(this.btn_notesTab, 0, 0);
            this.tbpnl_tabs.Controls.Add(this.btn_docsTab, 2, 0);
            this.tbpnl_tabs.Controls.Add(this.lbl_currentNotebook, 1, 0);
            this.tbpnl_tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpnl_tabs.Location = new System.Drawing.Point(10, 10);
            this.tbpnl_tabs.Name = "tbpnl_tabs";
            this.tbpnl_tabs.RowCount = 1;
            this.tbpnl_tabs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpnl_tabs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbpnl_tabs.Size = new System.Drawing.Size(870, 46);
            this.tbpnl_tabs.TabIndex = 3;
            // 
            // btn_notesTab
            // 
            this.btn_notesTab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_notesTab.BackColor = System.Drawing.Color.Transparent;
            this.btn_notesTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.btn_notesTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_notesTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_notesTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notesTab.Font = new System.Drawing.Font("Cascadia Code Light", 9.5F);
            this.btn_notesTab.ForeColor = System.Drawing.Color.Black;
            this.btn_notesTab.Location = new System.Drawing.Point(68, 3);
            this.btn_notesTab.Name = "btn_notesTab";
            this.btn_notesTab.Size = new System.Drawing.Size(153, 40);
            this.btn_notesTab.TabIndex = 3;
            this.btn_notesTab.Text = "Notes";
            this.btn_notesTab.UseVisualStyleBackColor = false;
            this.btn_notesTab.Click += new System.EventHandler(this.btn_notesTab_Click);
            // 
            // btn_docsTab
            // 
            this.btn_docsTab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_docsTab.BackColor = System.Drawing.Color.Transparent;
            this.btn_docsTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.btn_docsTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_docsTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_docsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_docsTab.Font = new System.Drawing.Font("Cascadia Code Light", 9.5F);
            this.btn_docsTab.ForeColor = System.Drawing.Color.Black;
            this.btn_docsTab.Location = new System.Drawing.Point(648, 3);
            this.btn_docsTab.Name = "btn_docsTab";
            this.btn_docsTab.Size = new System.Drawing.Size(153, 40);
            this.btn_docsTab.TabIndex = 4;
            this.btn_docsTab.Text = "Documents";
            this.btn_docsTab.UseVisualStyleBackColor = false;
            this.btn_docsTab.Click += new System.EventHandler(this.btn_docsTab_Click);
            // 
            // lbl_currentNotebook
            // 
            this.lbl_currentNotebook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_currentNotebook.AutoEllipsis = true;
            this.lbl_currentNotebook.AutoSize = true;
            this.lbl_currentNotebook.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentNotebook.Location = new System.Drawing.Point(389, 8);
            this.lbl_currentNotebook.Name = "lbl_currentNotebook";
            this.lbl_currentNotebook.Size = new System.Drawing.Size(91, 30);
            this.lbl_currentNotebook.TabIndex = 5;
            this.lbl_currentNotebook.Text = "label1";
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_footer.Controls.Add(this.pnl_noteSettings);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(20, 539);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.pnl_footer.Size = new System.Drawing.Size(890, 57);
            this.pnl_footer.TabIndex = 2;
            // 
            // pnl_noteSettings
            // 
            this.pnl_noteSettings.Controls.Add(this.btn_delete);
            this.pnl_noteSettings.Controls.Add(this.pnl_delDialog);
            this.pnl_noteSettings.Controls.Add(this.panel1);
            this.pnl_noteSettings.Controls.Add(this.lbl_noteCurrent);
            this.pnl_noteSettings.Controls.Add(this.btn_notebookSettings);
            this.pnl_noteSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_noteSettings.Location = new System.Drawing.Point(0, 15);
            this.pnl_noteSettings.Name = "pnl_noteSettings";
            this.pnl_noteSettings.Size = new System.Drawing.Size(890, 42);
            this.pnl_noteSettings.TabIndex = 5;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(126)))));
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(576, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(40, 42);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "-";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // pnl_delDialog
            // 
            this.pnl_delDialog.Controls.Add(this.btn_delConfirm);
            this.pnl_delDialog.Controls.Add(this.chb_delFile);
            this.pnl_delDialog.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_delDialog.Location = new System.Drawing.Point(616, 0);
            this.pnl_delDialog.Name = "pnl_delDialog";
            this.pnl_delDialog.Size = new System.Drawing.Size(274, 42);
            this.pnl_delDialog.TabIndex = 5;
            this.pnl_delDialog.Visible = false;
            // 
            // btn_delConfirm
            // 
            this.btn_delConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_delConfirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_delConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_delConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delConfirm.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delConfirm.ForeColor = System.Drawing.Color.Red;
            this.btn_delConfirm.Location = new System.Drawing.Point(20, 0);
            this.btn_delConfirm.Name = "btn_delConfirm";
            this.btn_delConfirm.Size = new System.Drawing.Size(113, 42);
            this.btn_delConfirm.TabIndex = 8;
            this.btn_delConfirm.Text = "Confirm";
            this.btn_delConfirm.UseVisualStyleBackColor = false;
            this.btn_delConfirm.Click += new System.EventHandler(this.btn_delConfirm_Click);
            // 
            // chb_delFile
            // 
            this.chb_delFile.AutoSize = true;
            this.chb_delFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.chb_delFile.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_delFile.Location = new System.Drawing.Point(133, 0);
            this.chb_delFile.Name = "chb_delFile";
            this.chb_delFile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.chb_delFile.Size = new System.Drawing.Size(141, 42);
            this.chb_delFile.TabIndex = 9;
            this.chb_delFile.Text = "Delete file?";
            this.chb_delFile.UseVisualStyleBackColor = true;
            this.chb_delFile.CheckedChanged += new System.EventHandler(this.chb_delFile_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_dbSelector);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(194, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panel1.Size = new System.Drawing.Size(200, 42);
            this.panel1.TabIndex = 3;
            // 
            // cb_dbSelector
            // 
            this.cb_dbSelector.Dock = System.Windows.Forms.DockStyle.Left;
            this.cb_dbSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dbSelector.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dbSelector.FormattingEnabled = true;
            this.cb_dbSelector.Location = new System.Drawing.Point(0, 8);
            this.cb_dbSelector.Name = "cb_dbSelector";
            this.cb_dbSelector.Size = new System.Drawing.Size(121, 25);
            this.cb_dbSelector.TabIndex = 3;
            this.cb_dbSelector.SelectedIndexChanged += new System.EventHandler(this.cb_dbSelector_SelectedIndexChanged);
            // 
            // lbl_noteCurrent
            // 
            this.lbl_noteCurrent.AutoEllipsis = true;
            this.lbl_noteCurrent.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_noteCurrent.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noteCurrent.Location = new System.Drawing.Point(40, 0);
            this.lbl_noteCurrent.Name = "lbl_noteCurrent";
            this.lbl_noteCurrent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_noteCurrent.Size = new System.Drawing.Size(154, 42);
            this.lbl_noteCurrent.TabIndex = 1;
            this.lbl_noteCurrent.Text = "Current Notebook:";
            this.lbl_noteCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_notebookSettings
            // 
            this.btn_notebookSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(126)))));
            this.btn_notebookSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_notebookSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_notebookSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notebookSettings.Location = new System.Drawing.Point(0, 0);
            this.btn_notebookSettings.Name = "btn_notebookSettings";
            this.btn_notebookSettings.Size = new System.Drawing.Size(40, 42);
            this.btn_notebookSettings.TabIndex = 0;
            this.btn_notebookSettings.Text = "+";
            this.btn_notebookSettings.UseVisualStyleBackColor = false;
            this.btn_notebookSettings.Click += new System.EventHandler(this.btn_notebookSettings_Click);
            // 
            // pnl_container
            // 
            this.pnl_container.AutoScroll = true;
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(20, 86);
            this.pnl_container.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnl_container.Size = new System.Drawing.Size(890, 453);
            this.pnl_container.TabIndex = 3;
            // 
            // lbl_nothingFound
            // 
            this.lbl_nothingFound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_nothingFound.Font = new System.Drawing.Font("Cascadia Code", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nothingFound.Location = new System.Drawing.Point(20, 86);
            this.lbl_nothingFound.Name = "lbl_nothingFound";
            this.lbl_nothingFound.Size = new System.Drawing.Size(890, 453);
            this.lbl_nothingFound.TabIndex = 4;
            this.lbl_nothingFound.Text = "There\'s nothing here!";
            this.lbl_nothingFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_nothingFound.Visible = false;
            // 
            // frm_notebook
            // 
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(930, 616);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_nothingFound);
            this.Controls.Add(this.pnl_container);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.pnl_tabSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_notebook";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.SizeChanged += new System.EventHandler(this.frm_notebook_SizeChanged);
            this.pnl_tabSelect.ResumeLayout(false);
            this.tbpnl_tabs.ResumeLayout(false);
            this.tbpnl_tabs.PerformLayout();
            this.pnl_footer.ResumeLayout(false);
            this.pnl_noteSettings.ResumeLayout(false);
            this.pnl_delDialog.ResumeLayout(false);
            this.pnl_delDialog.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnl_tabSelect;
        private TableLayoutPanel tbpnl_tabs;
        private System.Windows.Forms.Button btn_notesTab;
        private System.Windows.Forms.Button btn_docsTab;
        private Panel pnl_footer;
        private Panel pnl_noteSettings;
        private Label lbl_noteCurrent;
        private System.Windows.Forms.Button btn_notebookSettings;
        private FlowLayoutPanel pnl_container;
        private Panel panel1;
        private System.Windows.Forms.ComboBox cb_dbSelector;
        private Label lbl_nothingFound;
        private Button btn_delete;
        private Panel pnl_delDialog;
        private Button btn_delConfirm;
        private CheckBox chb_delFile;
        private Label lbl_currentNotebook;
    }
}