using System;
using System.Windows.Forms;

namespace laba6
{
    internal class StandartForm : Form
    {
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label programName;

        public StandartForm()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        protected void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandartForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.programName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.programName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "стопроцентный брак";
            // 
            // programName
            // 
            this.programName.AutoSize = true;
            this.programName.Font = new System.Drawing.Font("Arial Narrow", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.programName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.programName.Location = new System.Drawing.Point(12, 9);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(144, 46);
            this.programName.TabIndex = 0;
            this.programName.Text = "ШНЯГА";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Created by AlexShev";
            // 
            // StandartForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(411, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StandartForm";
            this.Text = "Шняга";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        // для будующих окон
        protected void SetTextBox(TextBox textBox, string parametr)
        {
            if (textBox.Text == parametr)
            {
                textBox.Text = string.Empty;

                textBox.ForeColor = System.Drawing.Color.Black;

                textBox.BackColor = System.Drawing.Color.White;
            }
        }
        protected void CorrectTextBox(TextBox textBox, string parametr)
        {
            if (textBox.Text == string.Empty)
            {
                textBox.Text = parametr;

                textBox.ForeColor = System.Drawing.Color.Gray;

                textBox.BackColor = System.Drawing.Color.White;
            }
        }
    }
}