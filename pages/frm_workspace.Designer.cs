namespace IdeasAi.pages
{
    partial class frm_workspace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_workspace));
            this.txb_docsTitle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pnl_btns = new System.Windows.Forms.Panel();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_createMindmap = new System.Windows.Forms.Button();
            this.btn_organizeIdea = new System.Windows.Forms.Button();
            this.pnl_textEditor = new System.Windows.Forms.Panel();
            this.txb_textEditor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pln_splitCont = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_quickSearchRes = new System.Windows.Forms.Panel();
            this.txb_qsearchRes = new System.Windows.Forms.TextBox();
            this.pnl_quickSearch = new System.Windows.Forms.Panel();
            this.txb_QSearch = new System.Windows.Forms.TextBox();
            this.btn_QSearch = new System.Windows.Forms.Button();
            this.pbx_loading = new System.Windows.Forms.PictureBox();
            this.pnl_btns.SuspendLayout();
            this.pnl_textEditor.SuspendLayout();
            this.pln_splitCont.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_quickSearchRes.SuspendLayout();
            this.pnl_quickSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_docsTitle
            // 
            this.txb_docsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txb_docsTitle.Location = new System.Drawing.Point(25, 15);
            this.txb_docsTitle.Name = "txb_docsTitle";
            this.txb_docsTitle.Size = new System.Drawing.Size(880, 37);
            this.txb_docsTitle.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.txb_docsTitle.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txb_docsTitle.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txb_docsTitle.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txb_docsTitle.StateCommon.Content.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_docsTitle.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txb_docsTitle.TabIndex = 4;
            this.txb_docsTitle.Text = "Untitled 1";
            this.txb_docsTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_docsTitle.TextChanged += new System.EventHandler(this.txb_textEditor_TextChanged);
            this.txb_docsTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_textEditor_KeyDown);
            // 
            // pnl_btns
            // 
            this.pnl_btns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.pnl_btns.Controls.Add(this.pbx_loading);
            this.pnl_btns.Controls.Add(this.btn_new);
            this.pnl_btns.Controls.Add(this.btn_openFile);
            this.pnl_btns.Controls.Add(this.btn_save);
            this.pnl_btns.Controls.Add(this.btn_createMindmap);
            this.pnl_btns.Controls.Add(this.btn_organizeIdea);
            this.pnl_btns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_btns.Location = new System.Drawing.Point(25, 569);
            this.pnl_btns.Name = "pnl_btns";
            this.pnl_btns.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnl_btns.Size = new System.Drawing.Size(880, 47);
            this.pnl_btns.TabIndex = 7;
            // 
            // btn_new
            // 
            this.btn_new.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_new.Location = new System.Drawing.Point(640, 10);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(80, 27);
            this.btn_new.TabIndex = 8;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_openFile
            // 
            this.btn_openFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_openFile.Location = new System.Drawing.Point(720, 10);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(80, 27);
            this.btn_openFile.TabIndex = 7;
            this.btn_openFile.Text = "Open";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // btn_save
            // 
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_save.Location = new System.Drawing.Point(800, 10);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 27);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_createMindmap
            // 
            this.btn_createMindmap.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_createMindmap.Location = new System.Drawing.Point(80, 10);
            this.btn_createMindmap.Name = "btn_createMindmap";
            this.btn_createMindmap.Size = new System.Drawing.Size(174, 27);
            this.btn_createMindmap.TabIndex = 5;
            this.btn_createMindmap.Text = "Create Mindmap";
            this.btn_createMindmap.UseVisualStyleBackColor = true;
            this.btn_createMindmap.Click += new System.EventHandler(this.btn_createMindmap_Click);
            // 
            // btn_organizeIdea
            // 
            this.btn_organizeIdea.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_organizeIdea.Location = new System.Drawing.Point(0, 10);
            this.btn_organizeIdea.Name = "btn_organizeIdea";
            this.btn_organizeIdea.Size = new System.Drawing.Size(80, 27);
            this.btn_organizeIdea.TabIndex = 3;
            this.btn_organizeIdea.Text = "Organize";
            this.btn_organizeIdea.UseVisualStyleBackColor = true;
            this.btn_organizeIdea.Click += new System.EventHandler(this.btn_organizeIdea_Click);
            // 
            // pnl_textEditor
            // 
            this.pnl_textEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.pnl_textEditor.Controls.Add(this.txb_textEditor);
            this.pnl_textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_textEditor.Location = new System.Drawing.Point(0, 0);
            this.pnl_textEditor.Name = "pnl_textEditor";
            this.pnl_textEditor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnl_textEditor.Size = new System.Drawing.Size(630, 517);
            this.pnl_textEditor.TabIndex = 10;
            // 
            // txb_textEditor
            // 
            this.txb_textEditor.AcceptsReturn = true;
            this.txb_textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_textEditor.Location = new System.Drawing.Point(0, 5);
            this.txb_textEditor.Multiline = true;
            this.txb_textEditor.Name = "txb_textEditor";
            this.txb_textEditor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_textEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_textEditor.Size = new System.Drawing.Size(630, 507);
            this.txb_textEditor.StateCommon.Content.Font = new System.Drawing.Font("Courier New", 11.5F);
            this.txb_textEditor.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.txb_textEditor.StateNormal.Content.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_textEditor.StateNormal.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txb_textEditor.TabIndex = 5;
            this.txb_textEditor.Text = "Type your ideas..";
            this.txb_textEditor.TextChanged += new System.EventHandler(this.txb_textEditor_TextChanged);
            this.txb_textEditor.Click += new System.EventHandler(this.txb_textEditor_Click);
            this.txb_textEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_textEditor_KeyDown);
            // 
            // pln_splitCont
            // 
            this.pln_splitCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.pln_splitCont.Controls.Add(this.pnl_textEditor);
            this.pln_splitCont.Controls.Add(this.splitter2);
            this.pln_splitCont.Controls.Add(this.panel1);
            this.pln_splitCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pln_splitCont.Location = new System.Drawing.Point(25, 52);
            this.pln_splitCont.Name = "pln_splitCont";
            this.pln_splitCont.Size = new System.Drawing.Size(880, 517);
            this.pln_splitCont.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(630, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 517);
            this.splitter2.TabIndex = 12;
            this.splitter2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pnl_quickSearchRes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(640, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 517);
            this.panel1.TabIndex = 11;
            // 
            // pnl_quickSearchRes
            // 
            this.pnl_quickSearchRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.pnl_quickSearchRes.Controls.Add(this.txb_qsearchRes);
            this.pnl_quickSearchRes.Controls.Add(this.pnl_quickSearch);
            this.pnl_quickSearchRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_quickSearchRes.Location = new System.Drawing.Point(0, 0);
            this.pnl_quickSearchRes.Name = "pnl_quickSearchRes";
            this.pnl_quickSearchRes.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnl_quickSearchRes.Size = new System.Drawing.Size(240, 517);
            this.pnl_quickSearchRes.TabIndex = 2;
            // 
            // txb_qsearchRes
            // 
            this.txb_qsearchRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_qsearchRes.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_qsearchRes.Location = new System.Drawing.Point(0, 40);
            this.txb_qsearchRes.Multiline = true;
            this.txb_qsearchRes.Name = "txb_qsearchRes";
            this.txb_qsearchRes.ReadOnly = true;
            this.txb_qsearchRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_qsearchRes.Size = new System.Drawing.Size(240, 472);
            this.txb_qsearchRes.TabIndex = 3;
            // 
            // pnl_quickSearch
            // 
            this.pnl_quickSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.pnl_quickSearch.Controls.Add(this.txb_QSearch);
            this.pnl_quickSearch.Controls.Add(this.btn_QSearch);
            this.pnl_quickSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_quickSearch.Location = new System.Drawing.Point(0, 0);
            this.pnl_quickSearch.Name = "pnl_quickSearch";
            this.pnl_quickSearch.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnl_quickSearch.Size = new System.Drawing.Size(240, 40);
            this.pnl_quickSearch.TabIndex = 2;
            // 
            // txb_QSearch
            // 
            this.txb_QSearch.AcceptsReturn = true;
            this.txb_QSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_QSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_QSearch.Font = new System.Drawing.Font("Cascadia Code SemiLight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_QSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txb_QSearch.Location = new System.Drawing.Point(0, 5);
            this.txb_QSearch.Multiline = true;
            this.txb_QSearch.Name = "txb_QSearch";
            this.txb_QSearch.Size = new System.Drawing.Size(165, 30);
            this.txb_QSearch.TabIndex = 0;
            this.txb_QSearch.Text = "Quick search";
            this.txb_QSearch.Click += new System.EventHandler(this.txb_QSearch_Click);
            // 
            // btn_QSearch
            // 
            this.btn_QSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_QSearch.Location = new System.Drawing.Point(165, 5);
            this.btn_QSearch.Name = "btn_QSearch";
            this.btn_QSearch.Size = new System.Drawing.Size(75, 30);
            this.btn_QSearch.TabIndex = 0;
            this.btn_QSearch.Text = "Search";
            this.btn_QSearch.UseVisualStyleBackColor = true;
            this.btn_QSearch.Click += new System.EventHandler(this.btn_QSearch_Click);
            // 
            // pbx_loading
            // 
            this.pbx_loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_loading.Image = ((System.Drawing.Image)(resources.GetObject("pbx_loading.Image")));
            this.pbx_loading.Location = new System.Drawing.Point(254, 10);
            this.pbx_loading.Name = "pbx_loading";
            this.pbx_loading.Size = new System.Drawing.Size(386, 27);
            this.pbx_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_loading.TabIndex = 9;
            this.pbx_loading.TabStop = false;
            // 
            // frm_workspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(930, 616);
            this.ControlBox = false;
            this.Controls.Add(this.pln_splitCont);
            this.Controls.Add(this.pnl_btns);
            this.Controls.Add(this.txb_docsTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_workspace";
            this.Padding = new System.Windows.Forms.Padding(25, 15, 25, 0);
            this.Text = "frm_workspace";
            this.pnl_btns.ResumeLayout(false);
            this.pnl_textEditor.ResumeLayout(false);
            this.pnl_textEditor.PerformLayout();
            this.pln_splitCont.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_quickSearchRes.ResumeLayout(false);
            this.pnl_quickSearchRes.PerformLayout();
            this.pnl_quickSearch.ResumeLayout(false);
            this.pnl_quickSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_docsTitle;
        private System.Windows.Forms.Panel pnl_btns;
        private System.Windows.Forms.Button btn_organizeIdea;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_createMindmap;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Panel pnl_textEditor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_textEditor;
        private System.Windows.Forms.Panel pln_splitCont;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_quickSearchRes;
        private System.Windows.Forms.Panel pnl_quickSearch;
        private System.Windows.Forms.TextBox txb_QSearch;
        private System.Windows.Forms.Button btn_QSearch;
        private System.Windows.Forms.TextBox txb_qsearchRes;
        private System.Windows.Forms.PictureBox pbx_loading;
    }
}