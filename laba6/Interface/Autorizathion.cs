using System;
using System.Drawing;
using System.Windows.Forms;

namespace laba6
{
    class Authorization : StandartForm
    {
        private Panel panel2;
        private Label label3;
        private TextBox password;
        private TextBox login;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button buttonClient;
        private readonly Database _database;
        private readonly bool _isAdmin;
        private readonly string enterLogin = "Введите логин";
        private Button predicant;
        private readonly string enterPassword = "Введите пароль";
        private readonly StartWindow _startWindow;

        public Authorization(StartWindow startWindow, Database database, bool isAdmin = false)
        {
            _startWindow = startWindow;

            _database = database;

            _isAdmin = isAdmin;

            InitializeComponent();

            CorrectTextBox(login, enterLogin);

            CorrectTextBox(password, enterPassword);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.panel2 = new System.Windows.Forms.Panel();
            this.predicant = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClient = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Fuchsia;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.predicant);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.login);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonClient);
            this.panel2.Location = new System.Drawing.Point(57, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 357);
            this.panel2.TabIndex = 2;
            // 
            // predicant
            // 
            this.predicant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.predicant.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.predicant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.predicant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.predicant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.predicant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.predicant.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.predicant.Location = new System.Drawing.Point(122, 309);
            this.predicant.Name = "predicant";
            this.predicant.Size = new System.Drawing.Size(74, 24);
            this.predicant.TabIndex = 13;
            this.predicant.Text = "назад";
            this.predicant.UseVisualStyleBackColor = false;
            this.predicant.Click += new System.EventHandler(this.predicant_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(74, 170);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(213, 35);
            this.password.TabIndex = 10;
            this.password.Enter += new System.EventHandler(this.Password_Enter);
            this.password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(74, 99);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(213, 35);
            this.login.TabIndex = 9;
            this.login.Enter += new System.EventHandler(this.Login_Enter);
            this.login.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "Авторизация";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.buttonClient.Location = new System.Drawing.Point(84, 241);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(148, 47);
            this.buttonClient.TabIndex = 5;
            this.buttonClient.Text = "Войти";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // Authorization
            // 
            this.ClientSize = new System.Drawing.Size(434, 519);
            this.Controls.Add(this.panel2);
            this.Name = "Authorization";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Login_Enter(object sender, EventArgs e)
        {
            login.BackColor = Color.White;

            SetTextBox(login, enterLogin);
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            CorrectTextBox(login, enterLogin);

            if (login.Text == enterLogin ||
                (_isAdmin) ? _database.IsFreeLoginAdmins(login.Text) : _database.IsFreeLoginClients(login.Text))
            {
                login.BackColor = Color.Red;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            password.BackColor = Color.White;

            SetTextBox(password, enterPassword);

            password.UseSystemPasswordChar = true;
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            CorrectTextBox(password, enterPassword);

            if (password.Text == enterPassword)
            {
                password.UseSystemPasswordChar = false;

                password.BackColor = Color.Red;
            }
            else if (!IsMyHuman())
            {
                password.BackColor = Color.Red;
            }
        }

        private bool IsMyHuman() 
        {
            try
            {
                return (_isAdmin) ? _database.IsMyAdmin(new Admin(login.Text, password.Text)) : _database.IsMyClient(login.Text, password.Text);
            }
            catch (Exception)
            {
                return false;
            }
        
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            if (IsMyHuman()) 
            {
                this.Hide();
                if (_isAdmin)
                {
                    var adminWindow = new AdminWindow(_startWindow, _database, login.Text, password.Text);

                    adminWindow.Show();
                }
                else
                {
                    var clientWindow = new ClientWindow(_startWindow, _database, login.Text, password.Text);

                    clientWindow.Show();
                }
            }
            else 
            {
                MessageBox.Show("Ошибка ввода!!!\nОбратите внимание на красные поля");
            }
        }

        private void predicant_Click(object sender, EventArgs e)
        {
            _startWindow.Show();

            this.Hide();
        }
    }
}
