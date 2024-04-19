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
            this.pnl_textEditor = new System.Windows.Forms.Panel();
            this.pnl_textEditCont = new System.Windows.Forms.Panel();
            this.txb_textEditor = new System.Windows.Forms.RichTextBox();
            this.pnl_btns = new System.Windows.Forms.Panel();
            this.lbl_lastDateSaved = new System.Windows.Forms.Label();
            this.btn_docOptions = new System.Windows.Forms.Button();
            this.pnl_docConts = new System.Windows.Forms.Panel();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.btn_docsDel = new System.Windows.Forms.Button();
            this.pnl_confirmDel = new System.Windows.Forms.Panel();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_createMindmap = new System.Windows.Forms.Button();
            this.btn_organizeIdea = new System.Windows.Forms.Button();
            this.pln_splitCont = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_quickSearchRes = new System.Windows.Forms.Panel();
            this.txb_qsearchRes = new System.Windows.Forms.TextBox();
            this.pbx_loading = new System.Windows.Forms.PictureBox();
            this.pnl_quickSearch = new System.Windows.Forms.Panel();
            this.pnl_txbCont = new System.Windows.Forms.Panel();
            this.txb_QSearch = new System.Windows.Forms.RichTextBox();
            this.btn_QSearch = new System.Windows.Forms.Button();
            this.pnl_textEditor.SuspendLayout();
            this.pnl_textEditCont.SuspendLayout();
            this.pnl_btns.SuspendLayout();
            this.pnl_docConts.SuspendLayout();
            this.pnl_confirmDel.SuspendLayout();
            this.pln_splitCont.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_quickSearchRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loading)).BeginInit();
            this.pnl_quickSearch.SuspendLayout();
            this.pnl_txbCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_docsTitle
            // 
            this.txb_docsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txb_docsTitle.Location = new System.Drawing.Point(19, 12);
            this.txb_docsTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_docsTitle.Name = "txb_docsTitle";
            this.txb_docsTitle.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.txb_docsTitle.Size = new System.Drawing.Size(947, 34);
            this.txb_docsTitle.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(126)))));
            this.txb_docsTitle.StateCommon.Border.Color1 = System.Drawing.Color.Black;
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
            // pnl_textEditor
            // 
            this.pnl_textEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnl_textEditor.Controls.Add(this.pnl_textEditCont);
            this.pnl_textEditor.Controls.Add(this.pnl_btns);
            this.pnl_textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_textEditor.Location = new System.Drawing.Point(0, 0);
            this.pnl_textEditor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_textEditor.Name = "pnl_textEditor";
            this.pnl_textEditor.Padding = new System.Windows.Forms.Padding(0, 10, 0, 4);
            this.pnl_textEditor.Size = new System.Drawing.Size(759, 442);
            this.pnl_textEditor.TabIndex = 10;
            // 
            // pnl_textEditCont
            // 
            this.pnl_textEditCont.BackColor = System.Drawing.Color.White;
            this.pnl_textEditCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_textEditCont.Controls.Add(this.txb_textEditor);
            this.pnl_textEditCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_textEditCont.Location = new System.Drawing.Point(0, 10);
            this.pnl_textEditCont.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_textEditCont.Name = "pnl_textEditCont";
            this.pnl_textEditCont.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_textEditCont.Size = new System.Drawing.Size(759, 386);
            this.pnl_textEditCont.TabIndex = 9;
            // 
            // txb_textEditor
            // 
            this.txb_textEditor.AcceptsTab = true;
            this.txb_textEditor.BackColor = System.Drawing.Color.White;
            this.txb_textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_textEditor.Font = new System.Drawing.Font("Cascadia Code Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_textEditor.Location = new System.Drawing.Point(8, 8);
            this.txb_textEditor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_textEditor.Name = "txb_textEditor";
            this.txb_textEditor.Size = new System.Drawing.Size(741, 368);
            this.txb_textEditor.TabIndex = 8;
            this.txb_textEditor.Text = "Type your ideas..";
            this.txb_textEditor.TextChanged += new System.EventHandler(this.txb_textEditor_TextChanged);
            this.txb_textEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_textEditor_KeyDown);
            // 
            // pnl_btns
            // 
            this.pnl_btns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnl_btns.Controls.Add(this.lbl_lastDateSaved);
            this.pnl_btns.Controls.Add(this.btn_docOptions);
            this.pnl_btns.Controls.Add(this.pnl_docConts);
            this.pnl_btns.Controls.Add(this.btn_docsDel);
            this.pnl_btns.Controls.Add(this.pnl_confirmDel);
            this.pnl_btns.Controls.Add(this.btn_createMindmap);
            this.pnl_btns.Controls.Add(this.btn_organizeIdea);
            this.pnl_btns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_btns.Location = new System.Drawing.Point(0, 396);
            this.pnl_btns.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_btns.Name = "pnl_btns";
            this.pnl_btns.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnl_btns.Size = new System.Drawing.Size(759, 42);
            this.pnl_btns.TabIndex = 7;
            // 
            // lbl_lastDateSaved
            // 
            this.lbl_lastDateSaved.AutoEllipsis = true;
            this.lbl_lastDateSaved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(126)))));
            this.lbl_lastDateSaved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_lastDateSaved.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastDateSaved.ForeColor = System.Drawing.Color.White;
            this.lbl_lastDateSaved.Location = new System.Drawing.Point(194, 8);
            this.lbl_lastDateSaved.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lastDateSaved.Name = "lbl_lastDateSaved";
            this.lbl_lastDateSaved.Size = new System.Drawing.Size(233, 34);
            this.lbl_lastDateSaved.TabIndex = 13;
            this.lbl_lastDateSaved.Text = "Last Modified: N/A";
            this.lbl_lastDateSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_docOptions
            // 
            this.btn_docOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(254)))), ((int)(((byte)(214)))));
            this.btn_docOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_docOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_docOptions.Image = global::IdeasAi.Properties.Resources.docOptions;
            this.btn_docOptions.Location = new System.Drawing.Point(427, 8);
            this.btn_docOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_docOptions.Name = "btn_docOptions";
            this.btn_docOptions.Size = new System.Drawing.Size(28, 34);
            this.btn_docOptions.TabIndex = 18;
            this.btn_docOptions.UseVisualStyleBackColor = false;
            this.btn_docOptions.Click += new System.EventHandler(this.btn_docOptions_Click);
            // 
            // pnl_docConts
            // 
            this.pnl_docConts.Controls.Add(this.btn_new);
            this.pnl_docConts.Controls.Add(this.btn_save);
            this.pnl_docConts.Controls.Add(this.btn_openFile);
            this.pnl_docConts.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_docConts.Location = new System.Drawing.Point(455, 8);
            this.pnl_docConts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_docConts.Name = "pnl_docConts";
            this.pnl_docConts.Padding = new System.Windows.Forms.Padding(0, 4, 8, 4);
            this.pnl_docConts.Size = new System.Drawing.Size(184, 34);
            this.pnl_docConts.TabIndex = 17;
            this.pnl_docConts.Visible = false;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(254)))), ((int)(((byte)(214)))));
            this.btn_new.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(8, 4);
            this.btn_new.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(56, 26);
            this.btn_new.TabIndex = 14;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(254)))), ((int)(((byte)(214)))));
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(64, 4);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 26);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_openFile
            // 
            this.btn_openFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(254)))), ((int)(((byte)(214)))));
            this.btn_openFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openFile.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openFile.Location = new System.Drawing.Point(120, 4);
            this.btn_openFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(56, 26);
            this.btn_openFile.TabIndex = 13;
            this.btn_openFile.Text = "Open";
            this.btn_openFile.UseVisualStyleBackColor = false;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // btn_docsDel
            // 
            this.btn_docsDel.BackColor = System.Drawing.Color.White;
            this.btn_docsDel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_docsDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_docsDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_docsDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_docsDel.Image = global::IdeasAi.Properties.Resources.delete;
            this.btn_docsDel.Location = new System.Drawing.Point(639, 8);
            this.btn_docsDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_docsDel.Name = "btn_docsDel";
            this.btn_docsDel.Size = new System.Drawing.Size(28, 34);
            this.btn_docsDel.TabIndex = 16;
            this.btn_docsDel.UseVisualStyleBackColor = false;
            this.btn_docsDel.Click += new System.EventHandler(this.btn_docsDel_Click);
            // 
            // pnl_confirmDel
            // 
            this.pnl_confirmDel.Controls.Add(this.btn_confirm);
            this.pnl_confirmDel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_confirmDel.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_confirmDel.Location = new System.Drawing.Point(667, 8);
            this.pnl_confirmDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_confirmDel.Name = "pnl_confirmDel";
            this.pnl_confirmDel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.pnl_confirmDel.Size = new System.Drawing.Size(92, 34);
            this.pnl_confirmDel.TabIndex = 15;
            this.pnl_confirmDel.Visible = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(254)))), ((int)(((byte)(214)))));
            this.btn_confirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_confirm.Location = new System.Drawing.Point(12, 4);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(80, 26);
            this.btn_confirm.TabIndex = 13;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_createMindmap
            // 
            this.btn_createMindmap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(254)))), ((int)(((byte)(214)))));
            this.btn_createMindmap.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_createMindmap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createMindmap.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createMindmap.ForeColor = System.Drawing.Color.Black;
            this.btn_createMindmap.Image = global::IdeasAi.Properties.Resources.mindmap;
            this.btn_createMindmap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_createMindmap.Location = new System.Drawing.Point(101, 8);
            this.btn_createMindmap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_createMindmap.Name = "btn_createMindmap";
            this.btn_createMindmap.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_createMindmap.Size = new System.Drawing.Size(93, 34);
            this.btn_createMindmap.TabIndex = 5;
            this.btn_createMindmap.Text = "Mindmap";
            this.btn_createMindmap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_createMindmap.UseVisualStyleBackColor = false;
            this.btn_createMindmap.Click += new System.EventHandler(this.btn_createMindmap_Click);
            // 
            // btn_organizeIdea
            // 
            this.btn_organizeIdea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(254)))), ((int)(((byte)(214)))));
            this.btn_organizeIdea.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_organizeIdea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_organizeIdea.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_organizeIdea.ForeColor = System.Drawing.Color.Black;
            this.btn_organizeIdea.Image = global::IdeasAi.Properties.Resources.organize;
            this.btn_organizeIdea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_organizeIdea.Location = new System.Drawing.Point(0, 8);
            this.btn_organizeIdea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_organizeIdea.Name = "btn_organizeIdea";
            this.btn_organizeIdea.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_organizeIdea.Size = new System.Drawing.Size(101, 34);
            this.btn_organizeIdea.TabIndex = 3;
            this.btn_organizeIdea.Text = "Organize";
            this.btn_organizeIdea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_organizeIdea.UseVisualStyleBackColor = false;
            this.btn_organizeIdea.Click += new System.EventHandler(this.btn_organizeIdea_Click);
            // 
            // pln_splitCont
            // 
            this.pln_splitCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.pln_splitCont.Controls.Add(this.pnl_textEditor);
            this.pln_splitCont.Controls.Add(this.splitter2);
            this.pln_splitCont.Controls.Add(this.panel1);
            this.pln_splitCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pln_splitCont.Location = new System.Drawing.Point(19, 46);
            this.pln_splitCont.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pln_splitCont.Name = "pln_splitCont";
            this.pln_splitCont.Size = new System.Drawing.Size(947, 442);
            this.pln_splitCont.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(759, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(8, 442);
            this.splitter2.TabIndex = 12;
            this.splitter2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pnl_quickSearchRes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(767, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 442);
            this.panel1.TabIndex = 11;
            // 
            // pnl_quickSearchRes
            // 
            this.pnl_quickSearchRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnl_quickSearchRes.Controls.Add(this.txb_qsearchRes);
            this.pnl_quickSearchRes.Controls.Add(this.pbx_loading);
            this.pnl_quickSearchRes.Controls.Add(this.pnl_quickSearch);
            this.pnl_quickSearchRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_quickSearchRes.Location = new System.Drawing.Point(0, 0);
            this.pnl_quickSearchRes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_quickSearchRes.Name = "pnl_quickSearchRes";
            this.pnl_quickSearchRes.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.pnl_quickSearchRes.Size = new System.Drawing.Size(180, 442);
            this.pnl_quickSearchRes.TabIndex = 2;
            // 
            // txb_qsearchRes
            // 
            this.txb_qsearchRes.BackColor = System.Drawing.Color.White;
            this.txb_qsearchRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_qsearchRes.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_qsearchRes.Location = new System.Drawing.Point(0, 70);
            this.txb_qsearchRes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_qsearchRes.Multiline = true;
            this.txb_qsearchRes.Name = "txb_qsearchRes";
            this.txb_qsearchRes.ReadOnly = true;
            this.txb_qsearchRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_qsearchRes.Size = new System.Drawing.Size(180, 368);
            this.txb_qsearchRes.TabIndex = 3;
            // 
            // pbx_loading
            // 
            this.pbx_loading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.pbx_loading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbx_loading.Image = ((System.Drawing.Image)(resources.GetObject("pbx_loading.Image")));
            this.pbx_loading.Location = new System.Drawing.Point(0, 48);
            this.pbx_loading.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbx_loading.Name = "pbx_loading";
            this.pbx_loading.Size = new System.Drawing.Size(180, 22);
            this.pbx_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_loading.TabIndex = 9;
            this.pbx_loading.TabStop = false;
            this.pbx_loading.Visible = false;
            // 
            // pnl_quickSearch
            // 
            this.pnl_quickSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnl_quickSearch.Controls.Add(this.pnl_txbCont);
            this.pnl_quickSearch.Controls.Add(this.btn_QSearch);
            this.pnl_quickSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_quickSearch.Location = new System.Drawing.Point(0, 0);
            this.pnl_quickSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_quickSearch.Name = "pnl_quickSearch";
            this.pnl_quickSearch.Padding = new System.Windows.Forms.Padding(0, 10, 0, 4);
            this.pnl_quickSearch.Size = new System.Drawing.Size(180, 48);
            this.pnl_quickSearch.TabIndex = 2;
            // 
            // pnl_txbCont
            // 
            this.pnl_txbCont.BackColor = System.Drawing.Color.White;
            this.pnl_txbCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_txbCont.Controls.Add(this.txb_QSearch);
            this.pnl_txbCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_txbCont.Location = new System.Drawing.Point(0, 10);
            this.pnl_txbCont.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_txbCont.Name = "pnl_txbCont";
            this.pnl_txbCont.Padding = new System.Windows.Forms.Padding(8, 10, 8, 0);
            this.pnl_txbCont.Size = new System.Drawing.Size(142, 34);
            this.pnl_txbCont.TabIndex = 6;
            this.pnl_txbCont.Click += new System.EventHandler(this.txb_QSearch_Click);
            // 
            // txb_QSearch
            // 
            this.txb_QSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_QSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_QSearch.Font = new System.Drawing.Font("Cascadia Code SemiLight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_QSearch.ForeColor = System.Drawing.Color.Silver;
            this.txb_QSearch.Location = new System.Drawing.Point(8, 10);
            this.txb_QSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_QSearch.Multiline = false;
            this.txb_QSearch.Name = "txb_QSearch";
            this.txb_QSearch.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txb_QSearch.Size = new System.Drawing.Size(124, 22);
            this.txb_QSearch.TabIndex = 2;
            this.txb_QSearch.Tag = "";
            this.txb_QSearch.Text = "Quick search";
            this.txb_QSearch.Click += new System.EventHandler(this.txb_QSearch_Click);
            this.txb_QSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_QSearch_KeyDown);
            // 
            // btn_QSearch
            // 
            this.btn_QSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_QSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_QSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_QSearch.FlatAppearance.BorderSize = 3;
            this.btn_QSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_QSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_QSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QSearch.Image = global::IdeasAi.Properties.Resources.quickSearch;
            this.btn_QSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QSearch.Location = new System.Drawing.Point(142, 10);
            this.btn_QSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_QSearch.Name = "btn_QSearch";
            this.btn_QSearch.Size = new System.Drawing.Size(38, 34);
            this.btn_QSearch.TabIndex = 0;
            this.btn_QSearch.UseVisualStyleBackColor = false;
            this.btn_QSearch.Click += new System.EventHandler(this.btn_QSearch_Click);
            // 
            // frm_workspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(985, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pln_splitCont);
            this.Controls.Add(this.txb_docsTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_workspace";
            this.Padding = new System.Windows.Forms.Padding(19, 12, 19, 12);
            this.Text = "frm_workspace";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_workspace_Paint);
            this.pnl_textEditor.ResumeLayout(false);
            this.pnl_textEditCont.ResumeLayout(false);
            this.pnl_btns.ResumeLayout(false);
            this.pnl_docConts.ResumeLayout(false);
            this.pnl_confirmDel.ResumeLayout(false);
            this.pln_splitCont.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_quickSearchRes.ResumeLayout(false);
            this.pnl_quickSearchRes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loading)).EndInit();
            this.pnl_quickSearch.ResumeLayout(false);
            this.pnl_txbCont.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_docsTitle;
        private System.Windows.Forms.Panel pnl_textEditor;
        private System.Windows.Forms.Panel pln_splitCont;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_quickSearchRes;
        private System.Windows.Forms.Panel pnl_quickSearch;
        private System.Windows.Forms.Button btn_QSearch;
        private System.Windows.Forms.PictureBox pbx_loading;
        private System.Windows.Forms.TextBox txb_qsearchRes;
        private System.Windows.Forms.Panel pnl_txbCont;
        private System.Windows.Forms.RichTextBox txb_QSearch;
        private System.Windows.Forms.Panel pnl_btns;
        private System.Windows.Forms.Button btn_createMindmap;
        private System.Windows.Forms.Button btn_organizeIdea;
        private System.Windows.Forms.Label lbl_lastDateSaved;
        private System.Windows.Forms.Button btn_docsDel;
        private System.Windows.Forms.Panel pnl_confirmDel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_docOptions;
        private System.Windows.Forms.Panel pnl_docConts;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.Panel pnl_textEditCont;
        private System.Windows.Forms.RichTextBox txb_textEditor;
    }
}