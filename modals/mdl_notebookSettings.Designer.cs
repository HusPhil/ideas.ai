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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.btn_browsePath = new System.Windows.Forms.Button();
            this.lbl_savePath = new System.Windows.Forms.Label();
            this.txb_saveDBPath = new System.Windows.Forms.TextBox();
            this.lbl_notebookName = new System.Windows.Forms.Label();
            this.txb_noteName = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_createNew = new System.Windows.Forms.Button();
            this.pnl_header.SuspendLayout();
            this.pnl_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.Controls.Add(this.btn_exit);
            this.pnl_header.Controls.Add(this.lbl_title);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(536, 63);
            this.pnl_header.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(486, 24);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(38, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(536, 63);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Add New Notebook";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_content
            // 
            this.pnl_content.Controls.Add(this.btn_browsePath);
            this.pnl_content.Controls.Add(this.lbl_savePath);
            this.pnl_content.Controls.Add(this.txb_saveDBPath);
            this.pnl_content.Controls.Add(this.lbl_notebookName);
            this.pnl_content.Controls.Add(this.txb_noteName);
            this.pnl_content.Controls.Add(this.btn_browse);
            this.pnl_content.Controls.Add(this.btn_createNew);
            this.pnl_content.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_content.Location = new System.Drawing.Point(-264, 63);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(800, 272);
            this.pnl_content.TabIndex = 4;
            this.pnl_content.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_content_Paint);
            // 
            // btn_browsePath
            // 
            this.btn_browsePath.Location = new System.Drawing.Point(579, 114);
            this.btn_browsePath.Name = "btn_browsePath";
            this.btn_browsePath.Size = new System.Drawing.Size(38, 23);
            this.btn_browsePath.TabIndex = 5;
            this.btn_browsePath.Text = "...";
            this.btn_browsePath.UseVisualStyleBackColor = true;
            this.btn_browsePath.Click += new System.EventHandler(this.btn_browsePath_Click);
            // 
            // lbl_savePath
            // 
            this.lbl_savePath.AutoSize = true;
            this.lbl_savePath.Location = new System.Drawing.Point(482, 95);
            this.lbl_savePath.Name = "lbl_savePath";
            this.lbl_savePath.Size = new System.Drawing.Size(71, 16);
            this.lbl_savePath.TabIndex = 4;
            this.lbl_savePath.Text = "Save path:";
            // 
            // txb_saveDBPath
            // 
            this.txb_saveDBPath.Location = new System.Drawing.Point(429, 114);
            this.txb_saveDBPath.Name = "txb_saveDBPath";
            this.txb_saveDBPath.ReadOnly = true;
            this.txb_saveDBPath.Size = new System.Drawing.Size(144, 22);
            this.txb_saveDBPath.TabIndex = 3;
            this.txb_saveDBPath.TextChanged += new System.EventHandler(this.txb_saveDBPath_TextChanged);
            // 
            // lbl_notebookName
            // 
            this.lbl_notebookName.AutoSize = true;
            this.lbl_notebookName.Location = new System.Drawing.Point(466, 49);
            this.lbl_notebookName.Name = "lbl_notebookName";
            this.lbl_notebookName.Size = new System.Drawing.Size(107, 16);
            this.lbl_notebookName.TabIndex = 2;
            this.lbl_notebookName.Text = "Notebook name:";
            // 
            // txb_noteName
            // 
            this.txb_noteName.Location = new System.Drawing.Point(428, 68);
            this.txb_noteName.Name = "txb_noteName";
            this.txb_noteName.Size = new System.Drawing.Size(189, 22);
            this.txb_noteName.TabIndex = 0;
            this.txb_noteName.TextChanged += new System.EventHandler(this.txb_noteName_TextChanged);
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(429, 183);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(190, 23);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_createNew
            // 
            this.btn_createNew.Enabled = false;
            this.btn_createNew.Location = new System.Drawing.Point(429, 154);
            this.btn_createNew.Name = "btn_createNew";
            this.btn_createNew.Size = new System.Drawing.Size(190, 23);
            this.btn_createNew.TabIndex = 0;
            this.btn_createNew.Text = "Create";
            this.btn_createNew.UseVisualStyleBackColor = true;
            this.btn_createNew.Click += new System.EventHandler(this.btn_createNew_Click);
            // 
            // mdl_notebookSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 335);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_content);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mdl_notebookSettings";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "mdl_noteSettings";
            this.Load += new System.EventHandler(this.mdl_notebookSettings_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_content.ResumeLayout(false);
            this.pnl_content.PerformLayout();
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
    }
}