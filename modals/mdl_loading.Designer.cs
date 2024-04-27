namespace IdeasAi.modals
{
    partial class mdl_loading
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
            this.lbl_loadingInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_loadingInfo
            // 
            this.lbl_loadingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.lbl_loadingInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_loadingInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_loadingInfo.Font = new System.Drawing.Font("Cascadia Code", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loadingInfo.ForeColor = System.Drawing.Color.Black;
            this.lbl_loadingInfo.Location = new System.Drawing.Point(10, 10);
            this.lbl_loadingInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_loadingInfo.Name = "lbl_loadingInfo";
            this.lbl_loadingInfo.Size = new System.Drawing.Size(355, 54);
            this.lbl_loadingInfo.TabIndex = 1;
            this.lbl_loadingInfo.Text = "Getting There...";
            this.lbl_loadingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::IdeasAi.Properties.Resources.loaderCat;
            this.pictureBox1.Location = new System.Drawing.Point(10, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mdl_loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 191);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_loadingInfo);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mdl_loading";
            this.Opacity = 0D;
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "mdl_loading";
            this.Load += new System.EventHandler(this.mdl_loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbl_loadingInfo;
    }
}