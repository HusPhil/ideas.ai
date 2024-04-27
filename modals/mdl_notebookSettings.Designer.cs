namespace IdeasAi.modals
{
    partial class mdl_notebookSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdl_notebookSettings));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_createNew = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_notebookName = new System.Windows.Forms.Label();
            this.txb_noteName = new System.Windows.Forms.TextBox();
            this.btn_browsePath = new System.Windows.Forms.Button();
            this.lbl_savePath = new System.Windows.Forms.Label();
            this.txb_saveDBPath = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_content.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.pnl_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_header.Controls.Add(this.pictureBox1);
            this.pnl_header.Controls.Add(this.btn_exit);
            this.pnl_header.Controls.Add(this.lbl_title);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(10, 10);
            this.pnl_header.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnl_header.Size = new System.Drawing.Size(382, 51);
            this.pnl_header.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(60, 49);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(143)))), ((int)(((byte)(177)))));
            this.btn_exit.CausesValidation = false;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(358, 2);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(22, 21);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_title.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(63, 0);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbl_title.Size = new System.Drawing.Size(317, 49);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Add New Notebook";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_content
            // 
            this.pnl_content.Controls.Add(this.panel7);
            this.pnl_content.Controls.Add(this.panel6);
            this.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_content.Location = new System.Drawing.Point(10, 61);
            this.pnl_content.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(382, 229);
            this.pnl_content.TabIndex = 4;
            this.pnl_content.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_content_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_browse);
            this.panel7.Controls.Add(this.btn_createNew);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 135);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(80, 5, 80, 10);
            this.panel7.Size = new System.Drawing.Size(382, 66);
            this.panel7.TabIndex = 1;
            // 
            // btn_browse
            // 
            this.btn_browse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_browse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Location = new System.Drawing.Point(80, 31);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(2);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(222, 25);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_createNew
            // 
            this.btn_createNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(126)))));
            this.btn_createNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_createNew.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_createNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createNew.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createNew.Location = new System.Drawing.Point(80, 5);
            this.btn_createNew.Margin = new System.Windows.Forms.Padding(2);
            this.btn_createNew.Name = "btn_createNew";
            this.btn_createNew.Size = new System.Drawing.Size(222, 22);
            this.btn_createNew.TabIndex = 0;
            this.btn_createNew.Text = "Create";
            this.btn_createNew.UseVisualStyleBackColor = false;
            this.btn_createNew.Click += new System.EventHandler(this.btn_createNew_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 201);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(100, 10, 100, 30);
            this.panel6.Size = new System.Drawing.Size(382, 28);
            this.panel6.TabIndex = 0;
            // 
            // lbl_notebookName
            // 
            this.lbl_notebookName.AutoSize = true;
            this.lbl_notebookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(126)))));
            this.lbl_notebookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_notebookName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_notebookName.Location = new System.Drawing.Point(80, 0);
            this.lbl_notebookName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_notebookName.Name = "lbl_notebookName";
            this.lbl_notebookName.Size = new System.Drawing.Size(88, 15);
            this.lbl_notebookName.TabIndex = 2;
            this.lbl_notebookName.Text = "Notebook name:";
            // 
            // txb_noteName
            // 
            this.txb_noteName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txb_noteName.Location = new System.Drawing.Point(80, 26);
            this.txb_noteName.Margin = new System.Windows.Forms.Padding(2);
            this.txb_noteName.Name = "txb_noteName";
            this.txb_noteName.Size = new System.Drawing.Size(222, 20);
            this.txb_noteName.TabIndex = 0;
            this.txb_noteName.TextChanged += new System.EventHandler(this.txb_noteName_TextChanged);
            // 
            // btn_browsePath
            // 
            this.btn_browsePath.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_browsePath.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browsePath.Location = new System.Drawing.Point(262, 30);
            this.btn_browsePath.Margin = new System.Windows.Forms.Padding(2);
            this.btn_browsePath.Name = "btn_browsePath";
            this.btn_browsePath.Size = new System.Drawing.Size(40, 20);
            this.btn_browsePath.TabIndex = 5;
            this.btn_browsePath.Text = "...";
            this.btn_browsePath.UseVisualStyleBackColor = true;
            this.btn_browsePath.Click += new System.EventHandler(this.btn_browsePath_Click);
            // 
            // lbl_savePath
            // 
            this.lbl_savePath.AutoSize = true;
            this.lbl_savePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(208)))), ((int)(((byte)(126)))));
            this.lbl_savePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_savePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_savePath.Location = new System.Drawing.Point(80, 5);
            this.lbl_savePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_savePath.Name = "lbl_savePath";
            this.lbl_savePath.Size = new System.Drawing.Size(61, 15);
            this.lbl_savePath.TabIndex = 4;
            this.lbl_savePath.Text = "Save path:";
            // 
            // txb_saveDBPath
            // 
            this.txb_saveDBPath.BackColor = System.Drawing.SystemColors.Window;
            this.txb_saveDBPath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txb_saveDBPath.Location = new System.Drawing.Point(80, 31);
            this.txb_saveDBPath.Margin = new System.Windows.Forms.Padding(2);
            this.txb_saveDBPath.Name = "txb_saveDBPath";
            this.txb_saveDBPath.ReadOnly = true;
            this.txb_saveDBPath.Size = new System.Drawing.Size(182, 20);
            this.txb_saveDBPath.TabIndex = 3;
            this.txb_saveDBPath.TextChanged += new System.EventHandler(this.txb_saveDBPath_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 15);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txb_noteName);
            this.panel1.Controls.Add(this.lbl_notebookName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 76);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(80, 0, 80, 5);
            this.panel1.Size = new System.Drawing.Size(382, 51);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(80, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 10);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_browsePath);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.lbl_savePath);
            this.panel4.Controls.Add(this.txb_saveDBPath);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 127);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(80, 5, 120, 0);
            this.panel4.Size = new System.Drawing.Size(382, 51);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(80, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(182, 10);
            this.panel5.TabIndex = 6;
            // 
            // mdl_notebookSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 300);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_content);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mdl_notebookSettings";
            this.Opacity = 0D;
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.Text = "mdl_noteSettings";
            this.Load += new System.EventHandler(this.mdl_notebookSettings_Load);
            this.pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_content.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Label lbl_notebookName;
        private System.Windows.Forms.TextBox txb_noteName;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_createNew;
        private System.Windows.Forms.Label lbl_savePath;
        private System.Windows.Forms.TextBox txb_saveDBPath;
        private System.Windows.Forms.Button btn_browsePath;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}