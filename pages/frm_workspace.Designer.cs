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
            this.txb_docsTitle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pnl_btns = new System.Windows.Forms.Panel();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_createMindmap = new System.Windows.Forms.Button();
            this.btn_organizeIdea = new System.Windows.Forms.Button();
            this.pnl_textEditor = new System.Windows.Forms.Panel();
            this.txb_textEditor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_quickSearchRes = new System.Windows.Forms.Panel();
            this.wb_quickSearchRes = new System.Windows.Forms.WebBrowser();
            this.pnl_quickSearch = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.pnl_btns.SuspendLayout();
            this.pnl_textEditor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_quickSearchRes.SuspendLayout();
            this.pnl_quickSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_docsTitle
            // 
            this.txb_docsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txb_docsTitle.Location = new System.Drawing.Point(25, 15);
            this.txb_docsTitle.Name = "txb_docsTitle";
            this.txb_docsTitle.Size = new System.Drawing.Size(750, 37);
            this.txb_docsTitle.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.txb_docsTitle.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txb_docsTitle.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txb_docsTitle.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txb_docsTitle.StateCommon.Content.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_docsTitle.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txb_docsTitle.TabIndex = 4;
            this.txb_docsTitle.Text = "Untitled 1";
            this.txb_docsTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_btns
            // 
            this.pnl_btns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.pnl_btns.Controls.Add(this.btn_new);
            this.pnl_btns.Controls.Add(this.btn_openFile);
            this.pnl_btns.Controls.Add(this.btn_save);
            this.pnl_btns.Controls.Add(this.btn_createMindmap);
            this.pnl_btns.Controls.Add(this.btn_organizeIdea);
            this.pnl_btns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_btns.Location = new System.Drawing.Point(25, 403);
            this.pnl_btns.Name = "pnl_btns";
            this.pnl_btns.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnl_btns.Size = new System.Drawing.Size(750, 47);
            this.pnl_btns.TabIndex = 7;
            // 
            // btn_openFile
            // 
            this.btn_openFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_openFile.Location = new System.Drawing.Point(590, 10);
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
            this.btn_save.Location = new System.Drawing.Point(670, 10);
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
            this.pnl_textEditor.Location = new System.Drawing.Point(25, 52);
            this.pnl_textEditor.Name = "pnl_textEditor";
            this.pnl_textEditor.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.pnl_textEditor.Size = new System.Drawing.Size(487, 351);
            this.pnl_textEditor.TabIndex = 3;
            this.pnl_textEditor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_textEditor_Paint);
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
            this.txb_textEditor.Size = new System.Drawing.Size(482, 341);
            this.txb_textEditor.StateCommon.Content.Font = new System.Drawing.Font("Courier New", 11.5F);
            this.txb_textEditor.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.txb_textEditor.StateNormal.Content.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_textEditor.StateNormal.Content.Padding = new System.Windows.Forms.Padding(5);
            this.txb_textEditor.TabIndex = 5;
            this.txb_textEditor.Text = "Type your ideas..";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.pnl_quickSearchRes);
            this.panel1.Controls.Add(this.pnl_quickSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(512, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 351);
            this.panel1.TabIndex = 8;
            // 
            // pnl_quickSearchRes
            // 
            this.pnl_quickSearchRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.pnl_quickSearchRes.Controls.Add(this.wb_quickSearchRes);
            this.pnl_quickSearchRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_quickSearchRes.Location = new System.Drawing.Point(0, 40);
            this.pnl_quickSearchRes.Name = "pnl_quickSearchRes";
            this.pnl_quickSearchRes.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnl_quickSearchRes.Size = new System.Drawing.Size(263, 311);
            this.pnl_quickSearchRes.TabIndex = 2;
            // 
            // wb_quickSearchRes
            // 
            this.wb_quickSearchRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_quickSearchRes.Location = new System.Drawing.Point(0, 0);
            this.wb_quickSearchRes.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_quickSearchRes.Name = "wb_quickSearchRes";
            this.wb_quickSearchRes.Size = new System.Drawing.Size(263, 306);
            this.wb_quickSearchRes.TabIndex = 0;
            // 
            // pnl_quickSearch
            // 
            this.pnl_quickSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.pnl_quickSearch.Controls.Add(this.textBox1);
            this.pnl_quickSearch.Controls.Add(this.button1);
            this.pnl_quickSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_quickSearch.Location = new System.Drawing.Point(0, 0);
            this.pnl_quickSearch.Name = "pnl_quickSearch";
            this.pnl_quickSearch.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnl_quickSearch.Size = new System.Drawing.Size(263, 40);
            this.pnl_quickSearch.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Cascadia Code SemiLight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Search item";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(188, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_new
            // 
            this.btn_new.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_new.Location = new System.Drawing.Point(510, 10);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(80, 27);
            this.btn_new.TabIndex = 8;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // frm_workspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_textEditor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_btns);
            this.Controls.Add(this.txb_docsTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_workspace";
            this.Padding = new System.Windows.Forms.Padding(25, 15, 25, 0);
            this.Text = "frm_workspace";
            this.pnl_btns.ResumeLayout(false);
            this.pnl_textEditor.ResumeLayout(false);
            this.pnl_textEditor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnl_quickSearchRes.ResumeLayout(false);
            this.pnl_quickSearch.ResumeLayout(false);
            this.pnl_quickSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_docsTitle;
        private System.Windows.Forms.Panel pnl_btns;
        private System.Windows.Forms.Button btn_organizeIdea;
        private System.Windows.Forms.Panel pnl_textEditor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_textEditor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_quickSearchRes;
        private System.Windows.Forms.WebBrowser wb_quickSearchRes;
        private System.Windows.Forms.Panel pnl_quickSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_createMindmap;
        private System.Windows.Forms.Button btn_new;
    }
}