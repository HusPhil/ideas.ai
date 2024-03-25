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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_quickSearchRes = new System.Windows.Forms.Panel();
            this.wb_quickSearchRes = new System.Windows.Forms.WebBrowser();
            this.pnl_quickSearch = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_organizeIdea = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_quickSearchRes.SuspendLayout();
            this.pnl_quickSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(537, 450);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Lorem ipsum";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pnl_quickSearchRes);
            this.panel1.Controls.Add(this.pnl_quickSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(537, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 450);
            this.panel1.TabIndex = 1;
            // 
            // pnl_quickSearchRes
            // 
            this.pnl_quickSearchRes.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnl_quickSearchRes.Controls.Add(this.wb_quickSearchRes);
            this.pnl_quickSearchRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_quickSearchRes.Location = new System.Drawing.Point(0, 40);
            this.pnl_quickSearchRes.Name = "pnl_quickSearchRes";
            this.pnl_quickSearchRes.Padding = new System.Windows.Forms.Padding(5);
            this.pnl_quickSearchRes.Size = new System.Drawing.Size(263, 410);
            this.pnl_quickSearchRes.TabIndex = 2;
            // 
            // wb_quickSearchRes
            // 
            this.wb_quickSearchRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_quickSearchRes.Location = new System.Drawing.Point(5, 5);
            this.wb_quickSearchRes.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_quickSearchRes.Name = "wb_quickSearchRes";
            this.wb_quickSearchRes.Size = new System.Drawing.Size(253, 400);
            this.wb_quickSearchRes.TabIndex = 0;
            // 
            // pnl_quickSearch
            // 
            this.pnl_quickSearch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnl_quickSearch.Controls.Add(this.textBox1);
            this.pnl_quickSearch.Controls.Add(this.button1);
            this.pnl_quickSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_quickSearch.Location = new System.Drawing.Point(0, 0);
            this.pnl_quickSearch.Name = "pnl_quickSearch";
            this.pnl_quickSearch.Padding = new System.Windows.Forms.Padding(5);
            this.pnl_quickSearch.Size = new System.Drawing.Size(263, 40);
            this.pnl_quickSearch.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(5, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 30);
            this.textBox1.TabIndex = 0;
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
            // btn_organizeIdea
            // 
            this.btn_organizeIdea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_organizeIdea.Location = new System.Drawing.Point(0, 411);
            this.btn_organizeIdea.Name = "btn_organizeIdea";
            this.btn_organizeIdea.Size = new System.Drawing.Size(537, 39);
            this.btn_organizeIdea.TabIndex = 2;
            this.btn_organizeIdea.Text = "Organize Your Ideas";
            this.btn_organizeIdea.UseVisualStyleBackColor = true;
            // 
            // frm_workspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_organizeIdea);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_workspace";
            this.Text = "frm_workspace";
            this.panel1.ResumeLayout(false);
            this.pnl_quickSearchRes.ResumeLayout(false);
            this.pnl_quickSearch.ResumeLayout(false);
            this.pnl_quickSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnl_quickSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnl_quickSearchRes;
        private System.Windows.Forms.WebBrowser wb_quickSearchRes;
        private System.Windows.Forms.Button btn_organizeIdea;
    }
}