namespace IdeasAi.pages
{
    partial class frm_mindmap
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
            this.pnl_viewerSide = new System.Windows.Forms.Panel();
            this.pnl_mindmapViewer = new System.Windows.Forms.Panel();
            this.pbx_mindmap = new System.Windows.Forms.PictureBox();
            this.pnl_viewSettings = new System.Windows.Forms.Panel();
            this.lbl_errorIndicator = new System.Windows.Forms.Label();
            this.cb_viewSelector = new System.Windows.Forms.ComboBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_zoomIn = new System.Windows.Forms.Button();
            this.btn_zoomOut = new System.Windows.Forms.Button();
            this.pnl_inputSide = new System.Windows.Forms.Panel();
            this.txb_markdownInput = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.btn_generateMindmap = new System.Windows.Forms.Button();
            this.spl_mindmap = new System.Windows.Forms.Splitter();
            this.pnl_viewerSide.SuspendLayout();
            this.pnl_mindmapViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_mindmap)).BeginInit();
            this.pnl_viewSettings.SuspendLayout();
            this.pnl_inputSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_viewerSide
            // 
            this.pnl_viewerSide.AutoScroll = true;
            this.pnl_viewerSide.BackColor = System.Drawing.Color.White;
            this.pnl_viewerSide.Controls.Add(this.pnl_mindmapViewer);
            this.pnl_viewerSide.Controls.Add(this.pnl_viewSettings);
            this.pnl_viewerSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_viewerSide.Location = new System.Drawing.Point(20, 0);
            this.pnl_viewerSide.Name = "pnl_viewerSide";
            this.pnl_viewerSide.Size = new System.Drawing.Size(910, 616);
            this.pnl_viewerSide.TabIndex = 3;
            // 
            // pnl_mindmapViewer
            // 
            this.pnl_mindmapViewer.AutoScroll = true;
            this.pnl_mindmapViewer.Controls.Add(this.pbx_mindmap);
            this.pnl_mindmapViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_mindmapViewer.Location = new System.Drawing.Point(0, 0);
            this.pnl_mindmapViewer.Name = "pnl_mindmapViewer";
            this.pnl_mindmapViewer.Size = new System.Drawing.Size(910, 557);
            this.pnl_mindmapViewer.TabIndex = 2;
            // 
            // pbx_mindmap
            // 
            this.pbx_mindmap.Image = global::IdeasAi.Properties.Resources.send;
            this.pbx_mindmap.ImageLocation = "";
            this.pbx_mindmap.Location = new System.Drawing.Point(0, 0);
            this.pbx_mindmap.Name = "pbx_mindmap";
            this.pbx_mindmap.Size = new System.Drawing.Size(14, 16);
            this.pbx_mindmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_mindmap.TabIndex = 0;
            this.pbx_mindmap.TabStop = false;
            // 
            // pnl_viewSettings
            // 
            this.pnl_viewSettings.BackColor = System.Drawing.Color.Wheat;
            this.pnl_viewSettings.Controls.Add(this.lbl_errorIndicator);
            this.pnl_viewSettings.Controls.Add(this.cb_viewSelector);
            this.pnl_viewSettings.Controls.Add(this.btn_reset);
            this.pnl_viewSettings.Controls.Add(this.btn_zoomIn);
            this.pnl_viewSettings.Controls.Add(this.btn_zoomOut);
            this.pnl_viewSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_viewSettings.Location = new System.Drawing.Point(0, 557);
            this.pnl_viewSettings.Name = "pnl_viewSettings";
            this.pnl_viewSettings.Size = new System.Drawing.Size(910, 59);
            this.pnl_viewSettings.TabIndex = 1;
            // 
            // lbl_errorIndicator
            // 
            this.lbl_errorIndicator.AutoSize = true;
            this.lbl_errorIndicator.Location = new System.Drawing.Point(516, 23);
            this.lbl_errorIndicator.Name = "lbl_errorIndicator";
            this.lbl_errorIndicator.Size = new System.Drawing.Size(98, 16);
            this.lbl_errorIndicator.TabIndex = 4;
            this.lbl_errorIndicator.Text = "No Error Found";
            // 
            // cb_viewSelector
            // 
            this.cb_viewSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_viewSelector.FormattingEnabled = true;
            this.cb_viewSelector.Items.AddRange(new object[] {
            "Zoom",
            "Stretch",
            "Center"});
            this.cb_viewSelector.Location = new System.Drawing.Point(351, 16);
            this.cb_viewSelector.Name = "cb_viewSelector";
            this.cb_viewSelector.Size = new System.Drawing.Size(121, 24);
            this.cb_viewSelector.TabIndex = 3;
            this.cb_viewSelector.SelectedIndexChanged += new System.EventHandler(this.cb_viewSelector_SelectedIndexChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(238, 16);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_zoomIn
            // 
            this.btn_zoomIn.Location = new System.Drawing.Point(138, 16);
            this.btn_zoomIn.Name = "btn_zoomIn";
            this.btn_zoomIn.Size = new System.Drawing.Size(75, 23);
            this.btn_zoomIn.TabIndex = 1;
            this.btn_zoomIn.Text = "+";
            this.btn_zoomIn.UseVisualStyleBackColor = true;
            this.btn_zoomIn.Click += new System.EventHandler(this.btn_zoomIn_Click);
            // 
            // btn_zoomOut
            // 
            this.btn_zoomOut.Location = new System.Drawing.Point(27, 16);
            this.btn_zoomOut.Name = "btn_zoomOut";
            this.btn_zoomOut.Size = new System.Drawing.Size(75, 23);
            this.btn_zoomOut.TabIndex = 0;
            this.btn_zoomOut.Text = "-";
            this.btn_zoomOut.UseVisualStyleBackColor = true;
            this.btn_zoomOut.Click += new System.EventHandler(this.btn_zoomOut_Click);
            // 
            // pnl_inputSide
            // 
            this.pnl_inputSide.BackColor = System.Drawing.Color.Chocolate;
            this.pnl_inputSide.Controls.Add(this.txb_markdownInput);
            this.pnl_inputSide.Controls.Add(this.btn_generateMindmap);
            this.pnl_inputSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_inputSide.Location = new System.Drawing.Point(0, 0);
            this.pnl_inputSide.Name = "pnl_inputSide";
            this.pnl_inputSide.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_inputSide.Size = new System.Drawing.Size(10, 616);
            this.pnl_inputSide.TabIndex = 4;
            // 
            // txb_markdownInput
            // 
            this.txb_markdownInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_markdownInput.Location = new System.Drawing.Point(10, 10);
            this.txb_markdownInput.Name = "txb_markdownInput";
            this.txb_markdownInput.Size = new System.Drawing.Size(0, 563);
            this.txb_markdownInput.TabIndex = 0;
            this.txb_markdownInput.Text = "";
            // 
            // btn_generateMindmap
            // 
            this.btn_generateMindmap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_generateMindmap.Location = new System.Drawing.Point(10, 573);
            this.btn_generateMindmap.Name = "btn_generateMindmap";
            this.btn_generateMindmap.Size = new System.Drawing.Size(0, 33);
            this.btn_generateMindmap.TabIndex = 2;
            this.btn_generateMindmap.Text = "Generate";
            this.btn_generateMindmap.UseVisualStyleBackColor = true;
            this.btn_generateMindmap.Click += new System.EventHandler(this.btn_generateMindmap_Click);
            // 
            // spl_mindmap
            // 
            this.spl_mindmap.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.spl_mindmap.Location = new System.Drawing.Point(10, 0);
            this.spl_mindmap.Name = "spl_mindmap";
            this.spl_mindmap.Size = new System.Drawing.Size(10, 616);
            this.spl_mindmap.TabIndex = 6;
            this.spl_mindmap.TabStop = false;
            // 
            // frm_mindmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 616);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_viewerSide);
            this.Controls.Add(this.spl_mindmap);
            this.Controls.Add(this.pnl_inputSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_mindmap";
            this.Text = "frm_mindmap";
            this.Load += new System.EventHandler(this.frm_mindmap_Load);
            this.pnl_viewerSide.ResumeLayout(false);
            this.pnl_mindmapViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_mindmap)).EndInit();
            this.pnl_viewSettings.ResumeLayout(false);
            this.pnl_viewSettings.PerformLayout();
            this.pnl_inputSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_viewerSide;
        private System.Windows.Forms.Panel pnl_mindmapViewer;
        private System.Windows.Forms.PictureBox pbx_mindmap;
        private System.Windows.Forms.Panel pnl_viewSettings;
        private System.Windows.Forms.ComboBox cb_viewSelector;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_zoomIn;
        private System.Windows.Forms.Button btn_zoomOut;
        private System.Windows.Forms.Panel pnl_inputSide;
        private System.Windows.Forms.Splitter spl_mindmap;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txb_markdownInput;
        private System.Windows.Forms.Label lbl_errorIndicator;
        private System.Windows.Forms.Button btn_generateMindmap;
    }
}