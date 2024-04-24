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
            this.components = new System.ComponentModel.Container();
            this.lbl_loadingInfo = new System.Windows.Forms.Label();
            this.tmr_animation = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_loadingInfo
            // 
            this.lbl_loadingInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_loadingInfo.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loadingInfo.Location = new System.Drawing.Point(0, 0);
            this.lbl_loadingInfo.Name = "lbl_loadingInfo";
            this.lbl_loadingInfo.Size = new System.Drawing.Size(500, 66);
            this.lbl_loadingInfo.TabIndex = 1;
            this.lbl_loadingInfo.Text = "lbl_loadingInfo";
            this.lbl_loadingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr_animation
            // 
            this.tmr_animation.Enabled = true;
            this.tmr_animation.Interval = 1;
            this.tmr_animation.Tick += new System.EventHandler(this.tmr_animation_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::IdeasAi.Properties.Resources.loaderCat;
            this.pictureBox1.Location = new System.Drawing.Point(0, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mdl_loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(500, 235);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_loadingInfo);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mdl_loading";
            this.Opacity = 0D;
            this.Text = "mdl_loading";
            this.Load += new System.EventHandler(this.mdl_loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbl_loadingInfo;
        private System.Windows.Forms.Timer tmr_animation;
    }
}