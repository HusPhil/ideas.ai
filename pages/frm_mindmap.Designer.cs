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
            this.pnl_titleCont = new System.Windows.Forms.Panel();
            this.txb_title = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_viewSelector = new System.Windows.Forms.ComboBox();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_zoomOut = new System.Windows.Forms.Button();
            this.btn_zoomIn = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_saveAsImage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_themeSelector = new System.Windows.Forms.ComboBox();
            this.pnl_error = new System.Windows.Forms.Panel();
            this.btn_generateMindmap = new System.Windows.Forms.Button();
            this.pnl_inputSide = new System.Windows.Forms.Panel();
            this.txb_markdownInput = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.spl_mindmap = new System.Windows.Forms.Splitter();
            this.pnl_viewerSide.SuspendLayout();
            this.pnl_mindmapViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_mindmap)).BeginInit();
            this.pnl_viewSettings.SuspendLayout();
            this.pnl_titleCont.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_error.SuspendLayout();
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
            this.pnl_viewerSide.Location = new System.Drawing.Point(240, 25);
            this.pnl_viewerSide.Name = "pnl_viewerSide";
            this.pnl_viewerSide.Size = new System.Drawing.Size(1008, 566);
            this.pnl_viewerSide.TabIndex = 3;
            // 
            // pnl_mindmapViewer
            // 
            this.pnl_mindmapViewer.AutoScroll = true;
            this.pnl_mindmapViewer.Controls.Add(this.pbx_mindmap);
            this.pnl_mindmapViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_mindmapViewer.Location = new System.Drawing.Point(0, 0);
            this.pnl_mindmapViewer.Name = "pnl_mindmapViewer";
            this.pnl_mindmapViewer.Size = new System.Drawing.Size(1008, 481);
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
            this.pbx_mindmap.BackgroundImageChanged += new System.EventHandler(this.pbx_mindmap_BackgroundImageChanged);
            // 
            // pnl_viewSettings
            // 
            this.pnl_viewSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(28)))));
            this.pnl_viewSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_viewSettings.Controls.Add(this.pnl_titleCont);
            this.pnl_viewSettings.Controls.Add(this.panel1);
            this.pnl_viewSettings.Controls.Add(this.pnl_buttons);
            this.pnl_viewSettings.Controls.Add(this.panel3);
            this.pnl_viewSettings.Controls.Add(this.panel2);
            this.pnl_viewSettings.Controls.Add(this.pnl_error);
            this.pnl_viewSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_viewSettings.ForeColor = System.Drawing.Color.White;
            this.pnl_viewSettings.Location = new System.Drawing.Point(0, 481);
            this.pnl_viewSettings.Name = "pnl_viewSettings";
            this.pnl_viewSettings.Size = new System.Drawing.Size(1008, 85);
            this.pnl_viewSettings.TabIndex = 1;
            // 
            // pnl_titleCont
            // 
            this.pnl_titleCont.Controls.Add(this.txb_title);
            this.pnl_titleCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_titleCont.Location = new System.Drawing.Point(250, 0);
            this.pnl_titleCont.Name = "pnl_titleCont";
            this.pnl_titleCont.Padding = new System.Windows.Forms.Padding(25, 30, 25, 0);
            this.pnl_titleCont.Size = new System.Drawing.Size(457, 83);
            this.pnl_titleCont.TabIndex = 18;
            // 
            // txb_title
            // 
            this.txb_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(28)))));
            this.txb_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_title.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_title.ForeColor = System.Drawing.Color.White;
            this.txb_title.Location = new System.Drawing.Point(25, 30);
            this.txb_title.Name = "txb_title";
            this.txb_title.Size = new System.Drawing.Size(407, 28);
            this.txb_title.TabIndex = 0;
            this.txb_title.Text = "myMindmap";
            this.txb_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_viewSelector);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(707, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 15, 10, 22);
            this.panel1.Size = new System.Drawing.Size(118, 83);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "VIEW:";
            // 
            // cb_viewSelector
            // 
            this.cb_viewSelector.BackColor = System.Drawing.Color.White;
            this.cb_viewSelector.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cb_viewSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_viewSelector.FormattingEnabled = true;
            this.cb_viewSelector.Items.AddRange(new object[] {
            "Zoom",
            "Stretch",
            "Center"});
            this.cb_viewSelector.Location = new System.Drawing.Point(0, 37);
            this.cb_viewSelector.Name = "cb_viewSelector";
            this.cb_viewSelector.Size = new System.Drawing.Size(108, 24);
            this.cb_viewSelector.TabIndex = 3;
            this.cb_viewSelector.SelectedIndexChanged += new System.EventHandler(this.cb_viewSelector_SelectedIndexChanged);
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.btn_zoomOut);
            this.pnl_buttons.Controls.Add(this.btn_zoomIn);
            this.pnl_buttons.Controls.Add(this.btn_reset);
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_buttons.Location = new System.Drawing.Point(825, 0);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Padding = new System.Windows.Forms.Padding(0, 22, 10, 22);
            this.pnl_buttons.Size = new System.Drawing.Size(126, 83);
            this.pnl_buttons.TabIndex = 16;
            // 
            // btn_zoomOut
            // 
            this.btn_zoomOut.BackColor = System.Drawing.Color.White;
            this.btn_zoomOut.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_zoomOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(28)))));
            this.btn_zoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zoomOut.Image = global::IdeasAi.Properties.Resources.zoomout;
            this.btn_zoomOut.Location = new System.Drawing.Point(80, 22);
            this.btn_zoomOut.Name = "btn_zoomOut";
            this.btn_zoomOut.Size = new System.Drawing.Size(40, 39);
            this.btn_zoomOut.TabIndex = 0;
            this.btn_zoomOut.UseVisualStyleBackColor = false;
            this.btn_zoomOut.Click += new System.EventHandler(this.btn_zoomOut_Click);
            // 
            // btn_zoomIn
            // 
            this.btn_zoomIn.BackColor = System.Drawing.Color.White;
            this.btn_zoomIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_zoomIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(28)))));
            this.btn_zoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zoomIn.Image = global::IdeasAi.Properties.Resources.zoomin;
            this.btn_zoomIn.Location = new System.Drawing.Point(40, 22);
            this.btn_zoomIn.Name = "btn_zoomIn";
            this.btn_zoomIn.Size = new System.Drawing.Size(40, 39);
            this.btn_zoomIn.TabIndex = 1;
            this.btn_zoomIn.UseVisualStyleBackColor = false;
            this.btn_zoomIn.Click += new System.EventHandler(this.btn_zoomIn_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.White;
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(28)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reset.Image = global::IdeasAi.Properties.Resources.resetZoom;
            this.btn_reset.Location = new System.Drawing.Point(0, 22);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(40, 39);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_saveAsImage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(951, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 22, 10, 22);
            this.panel3.Size = new System.Drawing.Size(55, 83);
            this.panel3.TabIndex = 14;
            // 
            // btn_saveAsImage
            // 
            this.btn_saveAsImage.BackColor = System.Drawing.Color.White;
            this.btn_saveAsImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_saveAsImage.Enabled = false;
            this.btn_saveAsImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(28)))));
            this.btn_saveAsImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_saveAsImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveAsImage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_saveAsImage.Image = global::IdeasAi.Properties.Resources.saveAsFile;
            this.btn_saveAsImage.Location = new System.Drawing.Point(5, 22);
            this.btn_saveAsImage.Name = "btn_saveAsImage";
            this.btn_saveAsImage.Size = new System.Drawing.Size(40, 39);
            this.btn_saveAsImage.TabIndex = 7;
            this.btn_saveAsImage.UseVisualStyleBackColor = false;
            this.btn_saveAsImage.Click += new System.EventHandler(this.btn_saveAsImage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cb_themeSelector);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(132, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 15, 10, 22);
            this.panel2.Size = new System.Drawing.Size(118, 83);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "THEME:";
            // 
            // cb_themeSelector
            // 
            this.cb_themeSelector.BackColor = System.Drawing.Color.White;
            this.cb_themeSelector.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cb_themeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_themeSelector.FormattingEnabled = true;
            this.cb_themeSelector.Items.AddRange(new object[] {
            "None",
            "Amiga",
            "Aws-orange",
            "Black-knight",
            "Bluegray",
            "Blueprint",
            "Cerulean-outline",
            "Cerulean",
            "Crt-amber",
            "Crt-green",
            "Cyborg-outline",
            "Cyborg",
            "Hacker",
            "Lightgray",
            "Mars",
            "Materia-outline",
            "Materia",
            "Metal",
            "Mimeograph",
            "Minty",
            "Plain",
            "Reddress-darkblue",
            "Reddress-darkgreen",
            "Reddress-darkorange",
            "Reddress-darkred",
            "Reddress-lightblue",
            "Reddress-lightgreen",
            "Reddress-lightorange",
            "Reddress-lightred",
            "Sandstone",
            "Silver",
            "Sketchy-outline",
            "Sketchy",
            "Spacelab",
            "Spacelab-white",
            "Superhero-outline",
            "Superhero",
            "Toy",
            "United",
            "Vibrant"});
            this.cb_themeSelector.Location = new System.Drawing.Point(0, 37);
            this.cb_themeSelector.Name = "cb_themeSelector";
            this.cb_themeSelector.Size = new System.Drawing.Size(108, 24);
            this.cb_themeSelector.TabIndex = 3;
            this.cb_themeSelector.SelectedIndexChanged += new System.EventHandler(this.cb_themeSelector_SelectedIndexChanged);
            // 
            // pnl_error
            // 
            this.pnl_error.Controls.Add(this.btn_generateMindmap);
            this.pnl_error.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_error.Location = new System.Drawing.Point(0, 0);
            this.pnl_error.Name = "pnl_error";
            this.pnl_error.Padding = new System.Windows.Forms.Padding(8, 20, 8, 22);
            this.pnl_error.Size = new System.Drawing.Size(132, 83);
            this.pnl_error.TabIndex = 7;
            // 
            // btn_generateMindmap
            // 
            this.btn_generateMindmap.BackColor = System.Drawing.Color.White;
            this.btn_generateMindmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_generateMindmap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generateMindmap.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generateMindmap.ForeColor = System.Drawing.Color.Black;
            this.btn_generateMindmap.Location = new System.Drawing.Point(8, 20);
            this.btn_generateMindmap.Name = "btn_generateMindmap";
            this.btn_generateMindmap.Size = new System.Drawing.Size(116, 41);
            this.btn_generateMindmap.TabIndex = 3;
            this.btn_generateMindmap.Text = "Generate";
            this.btn_generateMindmap.UseVisualStyleBackColor = false;
            this.btn_generateMindmap.Click += new System.EventHandler(this.btn_generateMindmap_Click);
            // 
            // pnl_inputSide
            // 
            this.pnl_inputSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.pnl_inputSide.Controls.Add(this.txb_markdownInput);
            this.pnl_inputSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_inputSide.Location = new System.Drawing.Point(25, 25);
            this.pnl_inputSide.Name = "pnl_inputSide";
            this.pnl_inputSide.Size = new System.Drawing.Size(205, 566);
            this.pnl_inputSide.TabIndex = 4;
            // 
            // txb_markdownInput
            // 
            this.txb_markdownInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_markdownInput.Location = new System.Drawing.Point(0, 0);
            this.txb_markdownInput.Name = "txb_markdownInput";
            this.txb_markdownInput.Size = new System.Drawing.Size(205, 566);
            this.txb_markdownInput.TabIndex = 0;
            this.txb_markdownInput.Text = "";
            // 
            // spl_mindmap
            // 
            this.spl_mindmap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.spl_mindmap.Location = new System.Drawing.Point(230, 25);
            this.spl_mindmap.Name = "spl_mindmap";
            this.spl_mindmap.Size = new System.Drawing.Size(10, 566);
            this.spl_mindmap.TabIndex = 6;
            this.spl_mindmap.TabStop = false;
            // 
            // frm_mindmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1273, 616);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_viewerSide);
            this.Controls.Add(this.spl_mindmap);
            this.Controls.Add(this.pnl_inputSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_mindmap";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Text = "frm_mindmap";
            this.Load += new System.EventHandler(this.frm_mindmap_Load);
            this.pnl_viewerSide.ResumeLayout(false);
            this.pnl_mindmapViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_mindmap)).EndInit();
            this.pnl_viewSettings.ResumeLayout(false);
            this.pnl_titleCont.ResumeLayout(false);
            this.pnl_titleCont.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_buttons.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_error.ResumeLayout(false);
            this.pnl_inputSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_viewerSide;
        private System.Windows.Forms.Panel pnl_mindmapViewer;
        private System.Windows.Forms.PictureBox pbx_mindmap;
        private System.Windows.Forms.Panel pnl_viewSettings;
        private System.Windows.Forms.Panel pnl_inputSide;
        private System.Windows.Forms.Splitter spl_mindmap;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txb_markdownInput;
        private System.Windows.Forms.Panel pnl_error;
        private System.Windows.Forms.Button btn_generateMindmap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_themeSelector;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_viewSelector;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Button btn_zoomOut;
        private System.Windows.Forms.Button btn_zoomIn;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_saveAsImage;
        private System.Windows.Forms.Panel pnl_titleCont;
        private System.Windows.Forms.TextBox txb_title;
    }
}