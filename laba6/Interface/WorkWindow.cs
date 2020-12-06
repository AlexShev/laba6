using System;
using System.Windows.Forms;

namespace laba6
{
    class WorkWindow : StandartForm
    {
        protected readonly StandartForm _startWindow;
        protected readonly Database _database;

        protected System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button1;
        private Panel panel2;
        private Label menuLabel;
        protected System.Windows.Forms.Panel WorkPlace;

        public WorkWindow(StandartForm startWindow, Database database)
        {
            InitializeComponent();

            _startWindow = startWindow;
            _database = database;
        }

        private WorkWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.WorkPlace = new System.Windows.Forms.Panel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menu.Controls.Add(this.menuLabel);
            this.menu.Controls.Add(this.panel2);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 82);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(226, 367);
            this.menu.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 47);
            this.panel2.TabIndex = 18;
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(117, 11);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(87, 24);
            this.exit.TabIndex = 15;
            this.exit.Text = "завершить";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(15, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 24);
            this.button1.TabIndex = 16;
            this.button1.Text = "выйти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // WorkPlace
            // 
            this.WorkPlace.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WorkPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkPlace.Location = new System.Drawing.Point(226, 82);
            this.WorkPlace.Name = "WorkPlace";
            this.WorkPlace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WorkPlace.Size = new System.Drawing.Size(423, 367);
            this.WorkPlace.TabIndex = 5;
            // 
            // menuLabel
            // 
            this.menuLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuLabel.Location = new System.Drawing.Point(0, 0);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(226, 34);
            this.menuLabel.TabIndex = 19;
            this.menuLabel.Text = "МЕНЮ";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkWindow
            // 
            this.ClientSize = new System.Drawing.Size(649, 468);
            this.Controls.Add(this.WorkPlace);
            this.Controls.Add(this.menu);
            this.Name = "WorkWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.menu, 0);
            this.Controls.SetChildIndex(this.WorkPlace, 0);
            this.menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            _startWindow.Show();

            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
