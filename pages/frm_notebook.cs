using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdeasAi.db;

namespace IdeasAi.pages
{
    public partial class frm_notebook: Form
    {

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel pnl_container;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private Panel panel6;
        private Label label6;
        private Panel panel7;
        private Label label7;
        private Panel panel8;
        private Label label8;
        private Panel panel9;
        private Label label9;
        private Panel panel10;
        private Label label10;
        private Panel panel11;
        private Label label11;
        private DBManager_Idea db_manager = new DBManager_Idea();

        public frm_notebook()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.pnl_container = new System.Windows.Forms.FlowLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pnl_container.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_container
            // 
            this.pnl_container.AutoScroll = true;
            this.pnl_container.Controls.Add(this.panel11);
            this.pnl_container.Controls.Add(this.panel1);
            this.pnl_container.Controls.Add(this.panel2);
            this.pnl_container.Controls.Add(this.panel3);
            this.pnl_container.Controls.Add(this.panel4);
            this.pnl_container.Controls.Add(this.panel5);
            this.pnl_container.Controls.Add(this.panel6);
            this.pnl_container.Controls.Add(this.panel7);
            this.pnl_container.Controls.Add(this.panel8);
            this.pnl_container.Controls.Add(this.panel9);
            this.pnl_container.Controls.Add(this.panel10);
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(20, 20);
            this.pnl_container.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(1052, 506);
            this.pnl_container.TabIndex = 0;
            this.pnl_container.AutoSizeChanged += new System.EventHandler(this.pnl_container_AutoSizeChanged);
            this.pnl_container.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel11.Controls.Add(this.label11);
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(198, 234);
            this.panel11.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Notebook ko to";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(207, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 234);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notebook ko to";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(411, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 234);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Notebook ko to";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(615, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 234);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Notebook ko to";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(819, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 234);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Notebook ko to";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(3, 243);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(198, 234);
            this.panel5.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Notebook ko to";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(207, 243);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(198, 234);
            this.panel6.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Notebook ko to";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(411, 243);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(198, 234);
            this.panel7.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Notebook ko to";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(615, 243);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(198, 234);
            this.panel8.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Notebook ko to";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(819, 243);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(198, 234);
            this.panel9.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Notebook ko to";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel10.Controls.Add(this.label10);
            this.panel10.Location = new System.Drawing.Point(3, 483);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(198, 234);
            this.panel10.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Notebook ko to";
            // 
            // frm_notebook
            // 
            this.ClientSize = new System.Drawing.Size(1092, 546);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_notebook";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Load += new System.EventHandler(this.frm_notebook_Load);
            this.pnl_container.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private bool HasScrollBar(Control control)
        {
            // Check if the control's client size is smaller than its display rectangle
            return control.ClientSize.Width < control.DisplayRectangle.Width ||
                   control.ClientSize.Height < control.DisplayRectangle.Height;
        }
        public void displaySavedIdeas()
        {
            pnl_container.Controls.Clear();
            var saved_ideas = db_manager.GetAllIdeas();

            Console.WriteLine($"OLD: {pnl_container.DisplayRectangle.Height}::{pnl_container.VerticalScroll.Visible}");

            bool verticalScrollBarVisible = false;

            foreach (var idea in saved_ideas)
            {
                Panel pnl_idea = new Panel();
                pnl_idea.BorderStyle = BorderStyle.FixedSingle;
                pnl_idea.Size = new Size((pnl_container.Width / 3) - 6, 200);

                Label titleLabel = new Label();
                titleLabel.Text = idea.Title;
                titleLabel.Location = new Point(10, 10);
                titleLabel.Width = pnl_idea.Width; // Adjust location as needed
                pnl_idea.Controls.Add(titleLabel);

                Label dateLabel = new Label();
                dateLabel.Text = Convert.ToString(idea.DateCreated);
                dateLabel.Location = new Point(10, 50); // Adjust location as needed
                pnl_idea.Controls.Add(dateLabel);

                Button printButton = new Button();
                printButton.Text = "View";
                printButton.Location = new Point(10, 70); // Adjust location as needed
                printButton.Click += (sender, e) => displayNote_click(idea.Content);
                pnl_idea.Controls.Add(printButton);

                pnl_container.Controls.Add(pnl_idea);

                // No need to adjust the width here
            }

            // Check if the vertical scrollbar is visible after adding all ideas
            verticalScrollBarVisible = pnl_container.VerticalScroll.Visible;

            // If the vertical scrollbar is visible, adjust the width of each pnl_idea
            if (verticalScrollBarVisible)
            {
                foreach (Control control in pnl_container.Controls)
                {
                    if (control is Panel pnl_idea)
                    {
                        pnl_idea.Size = new Size((pnl_container.Width / 3) - 6 - (SystemInformation.VerticalScrollBarWidth / 3), 200);

                    }
                }
            }

            Console.WriteLine($"NEW: {pnl_container.DisplayRectangle.Height}::{pnl_container.VerticalScroll.Visible}");
        }


        private void displayNote_click(string content)
        {
            MainForm.instance.loadForm(MainForm.instance.frm_home,MainForm.instance.pnl_content);
            MainForm.instance.setActiveBtn(MainForm.instance.btn_home);
            MainForm.instance.frm_home.displayResult(content);
        }
        private void frm_notebook_Load(object sender, EventArgs e)
        {
            displaySavedIdeas();
        }

        private void pnl_container_AutoSizeChanged(object sender, EventArgs e)
        {
        }
    }
}
