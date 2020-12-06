using System;
using System.Windows.Forms;

namespace laba6
{
    class StartWindow : StandartForm
    {
        private Panel panel2;
        private Button buttonAdmin;
        private Button buttonNewClient;
        private Label label3;
        private Button buttonClient;
        private Button exit;

        // не придумал как иначе, не нравиться
        private readonly Database _database;

        public StartWindow(Database database)
        {
            _database = database;

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Fuchsia;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonAdmin);
            this.panel2.Controls.Add(this.buttonNewClient);
            this.panel2.Controls.Add(this.buttonClient);
            this.panel2.Location = new System.Drawing.Point(57, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 357);
            this.panel2.TabIndex = 2;
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
            this.exit.Location = new System.Drawing.Point(121, 316);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(74, 24);
            this.exit.TabIndex = 14;
            this.exit.Text = "выйти";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Выберете действие";
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdmin.Location = new System.Drawing.Point(26, 244);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(265, 47);
            this.buttonAdmin.TabIndex = 7;
            this.buttonAdmin.Text = "Для администраторов";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.ButtonAdmin_Click);
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonNewClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewClient.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNewClient.Location = new System.Drawing.Point(26, 175);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(265, 47);
            this.buttonNewClient.TabIndex = 6;
            this.buttonNewClient.Text = "Зарегестрироватья";
            this.buttonNewClient.UseVisualStyleBackColor = false;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClient.Location = new System.Drawing.Point(26, 105);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(265, 47);
            this.buttonClient.TabIndex = 5;
            this.buttonClient.Text = "Войти";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.ButtonClient_Click);
            // 
            // StartWindow
            // 
            this.ClientSize = new System.Drawing.Size(434, 519);
            this.Controls.Add(this.panel2);
            this.Name = "StartWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ButtonClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization(this, _database, false);
            authorization.Show();
        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization(this, _database, true);
            authorization.Show();
        }

        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration(this, _database);
            registration.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
