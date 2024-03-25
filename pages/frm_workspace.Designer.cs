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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pnl_btns = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_organizeIdea = new System.Windows.Forms.Button();
            this.pnl_textEditor = new System.Windows.Forms.Panel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_quickSearchRes = new System.Windows.Forms.Panel();
            this.wb_quickSearchRes = new System.Windows.Forms.WebBrowser();
            this.pnl_quickSearch = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_btns.SuspendLayout();
            this.pnl_textEditor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_quickSearchRes.SuspendLayout();
            this.pnl_quickSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonTextBox2.Location = new System.Drawing.Point(0, 0);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(800, 37);
            this.kryptonTextBox2.StateCommon.Back.Color1 = System.Drawing.SystemColors.GrayText;
            this.kryptonTextBox2.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonTextBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox2.StateCommon.Content.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.kryptonTextBox2.TabIndex = 4;
            this.kryptonTextBox2.Text = "Untitled 1";
            this.kryptonTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_btns
            // 
            this.pnl_btns.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnl_btns.Controls.Add(this.button2);
            this.pnl_btns.Controls.Add(this.btn_organizeIdea);
            this.pnl_btns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_btns.Location = new System.Drawing.Point(0, 403);
            this.pnl_btns.Name = "pnl_btns";
            this.pnl_btns.Padding = new System.Windows.Forms.Padding(5, 0, 5, 10);
            this.pnl_btns.Size = new System.Drawing.Size(800, 47);
            this.pnl_btns.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(85, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_organizeIdea
            // 
            this.btn_organizeIdea.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_organizeIdea.Location = new System.Drawing.Point(5, 0);
            this.btn_organizeIdea.Name = "btn_organizeIdea";
            this.btn_organizeIdea.Size = new System.Drawing.Size(80, 37);
            this.btn_organizeIdea.TabIndex = 3;
            this.btn_organizeIdea.Text = "Organize";
            this.btn_organizeIdea.UseVisualStyleBackColor = true;
            // 
            // pnl_textEditor
            // 
            this.pnl_textEditor.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnl_textEditor.Controls.Add(this.kryptonTextBox1);
            this.pnl_textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_textEditor.Location = new System.Drawing.Point(0, 37);
            this.pnl_textEditor.Name = "pnl_textEditor";
            this.pnl_textEditor.Padding = new System.Windows.Forms.Padding(5);
            this.pnl_textEditor.Size = new System.Drawing.Size(537, 366);
            this.pnl_textEditor.TabIndex = 3;
            this.pnl_textEditor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_textEditor_Paint);
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTextBox1.Location = new System.Drawing.Point(5, 5);
            this.kryptonTextBox1.Multiline = true;
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kryptonTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.kryptonTextBox1.Size = new System.Drawing.Size(527, 356);
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Courier New", 11.5F);
            this.kryptonTextBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10);
            this.kryptonTextBox1.StateNormal.Content.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateNormal.Content.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonTextBox1.TabIndex = 5;
            this.kryptonTextBox1.Text = "Lorem Ipsum";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pnl_quickSearchRes);
            this.panel1.Controls.Add(this.pnl_quickSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(537, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 366);
            this.panel1.TabIndex = 8;
            // 
            // pnl_quickSearchRes
            // 
            this.pnl_quickSearchRes.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnl_quickSearchRes.Controls.Add(this.wb_quickSearchRes);
            this.pnl_quickSearchRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_quickSearchRes.Location = new System.Drawing.Point(0, 40);
            this.pnl_quickSearchRes.Name = "pnl_quickSearchRes";
            this.pnl_quickSearchRes.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.pnl_quickSearchRes.Size = new System.Drawing.Size(263, 326);
            this.pnl_quickSearchRes.TabIndex = 2;
            // 
            // wb_quickSearchRes
            // 
            this.wb_quickSearchRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_quickSearchRes.Location = new System.Drawing.Point(0, 0);
            this.wb_quickSearchRes.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_quickSearchRes.Name = "wb_quickSearchRes";
            this.wb_quickSearchRes.Size = new System.Drawing.Size(258, 321);
            this.wb_quickSearchRes.TabIndex = 0;
            // 
            // pnl_quickSearch
            // 
            this.pnl_quickSearch.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnl_quickSearch.Controls.Add(this.textBox1);
            this.pnl_quickSearch.Controls.Add(this.button1);
            this.pnl_quickSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_quickSearch.Location = new System.Drawing.Point(0, 0);
            this.pnl_quickSearch.Name = "pnl_quickSearch";
            this.pnl_quickSearch.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.pnl_quickSearch.Size = new System.Drawing.Size(263, 40);
            this.pnl_quickSearch.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Cascadia Code", 11F);
            this.textBox1.Location = new System.Drawing.Point(0, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Search item";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(183, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_workspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_textEditor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_btns);
            this.Controls.Add(this.kryptonTextBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_workspace";
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private System.Windows.Forms.Panel pnl_btns;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_organizeIdea;
        private System.Windows.Forms.Panel pnl_textEditor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_quickSearchRes;
        private System.Windows.Forms.WebBrowser wb_quickSearchRes;
        private System.Windows.Forms.Panel pnl_quickSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}