namespace IdeasAi.modals
{
    partial class mdl_error
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdl_error));
            this.lbl_errorInfo = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_okay = new System.Windows.Forms.Button();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_errorInfo
            // 
            this.lbl_errorInfo.AutoEllipsis = true;
            this.lbl_errorInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_errorInfo.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_errorInfo.Location = new System.Drawing.Point(134, 0);
            this.lbl_errorInfo.Name = "lbl_errorInfo";
            this.lbl_errorInfo.Size = new System.Drawing.Size(316, 83);
            this.lbl_errorInfo.TabIndex = 3;
            this.lbl_errorInfo.Text = "lbl_errorInfo";
            this.lbl_errorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_header
            // 
            this.pnl_header.Controls.Add(this.lbl_errorInfo);
            this.pnl_header.Controls.Add(this.pictureBox1);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.pnl_header.Size = new System.Drawing.Size(500, 83);
            this.pnl_header.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_okay
            // 
            this.btn_okay.Location = new System.Drawing.Point(200, 175);
            this.btn_okay.Name = "btn_okay";
            this.btn_okay.Size = new System.Drawing.Size(75, 23);
            this.btn_okay.TabIndex = 5;
            this.btn_okay.Text = "OK";
            this.btn_okay.UseVisualStyleBackColor = true;
            this.btn_okay.Click += new System.EventHandler(this.btn_okay_Click);
            // 
            // mdl_error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(500, 235);
            this.ControlBox = false;
            this.Controls.Add(this.btn_okay);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mdl_error";
            this.Text = "mdl_error";
            this.Load += new System.EventHandler(this.mdl_error_Load);
            this.pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_okay;
        public System.Windows.Forms.Label lbl_errorInfo;
    }
}