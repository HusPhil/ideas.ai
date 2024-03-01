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
        private DBManager_Idea db_manager = new DBManager_Idea();

        public frm_notebook()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnl_container = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_container.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_container
            // 
            this.pnl_container.AutoScroll = true;
            this.pnl_container.Controls.Add(this.panel1);
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(0, 0);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_container.Size = new System.Drawing.Size(1092, 546);
            this.pnl_container.TabIndex = 0;
            this.pnl_container.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 23);
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
            // frm_notebook
            // 
            this.ClientSize = new System.Drawing.Size(1092, 546);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_notebook";
            this.Load += new System.EventHandler(this.frm_notebook_Load);
            this.pnl_container.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public void displaySavedIdeas()
        {
            pnl_container.Controls.Clear();
            var saved_ideas = db_manager.GetAllIdeas();
            foreach (var idea in saved_ideas)
            {
                Panel pnl_idea = new Panel();
                pnl_idea.BorderStyle = BorderStyle.FixedSingle;
                pnl_idea.Size = new System.Drawing.Size((pnl_container.Width / 3) - 20, 100);

                Label titleLabel = new Label();
                titleLabel.Text = idea.Title;
                titleLabel.Location = new System.Drawing.Point(10, 10);
                titleLabel.Width = pnl_idea.Width;// Adjust location as needed
                pnl_idea.Controls.Add(titleLabel);


                Label dateLabel = new Label();
                dateLabel.Text = Convert.ToString(idea.DateCreated);
                dateLabel.Location = new System.Drawing.Point(10, 50); // Adjust location as needed
                pnl_idea.Controls.Add(dateLabel);

                Button printButton = new Button();
                printButton.Text = "View";
                printButton.Location = new System.Drawing.Point(10, 70); // Adjust location as needed
                // Attach event handler for button click
                printButton.Click += (sender, e) => displayNote_click(idea.Content);
                pnl_idea.Controls.Add(printButton);

                pnl_container.Controls.Add(pnl_idea);
            }
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
    }
}
