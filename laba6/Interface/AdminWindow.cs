using System;
using System.Drawing;
using System.Windows.Forms;

namespace laba6
{
    class AdminWindow : WorkWindow
    {
        private Button buttonClient;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button5;
        private Button button4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox _password;
        private TextBox _login;
        private Label label4;
        private Button button6;
        private Button button8;
        private Button button7;
        private readonly Admin _admin;
        private readonly string enterPassword = "Введите пароль";
        private Panel deleteClient;
        private readonly string enterLogin = "Введите логин";


        public AdminWindow(StartWindow startWindow, Database database, string login, string password)
    : base(startWindow, database)
        {
            _admin = new Admin(login, password);

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminWindow));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonClient = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.deleteClient = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._password = new System.Windows.Forms.TextBox();
            this._login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.WorkPlace.SuspendLayout();
            this.deleteClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Controls.Add(this.button5);
            this.menu.Controls.Add(this.button4);
            this.menu.Controls.Add(this.button3);
            this.menu.Controls.Add(this.button2);
            this.menu.Controls.Add(this.buttonClient);
            this.menu.Size = new System.Drawing.Size(226, 513);
            this.menu.Controls.SetChildIndex(this.buttonClient, 0);
            this.menu.Controls.SetChildIndex(this.button2, 0);
            this.menu.Controls.SetChildIndex(this.button3, 0);
            this.menu.Controls.SetChildIndex(this.button4, 0);
            this.menu.Controls.SetChildIndex(this.button5, 0);
            // 
            // WorkPlace
            // 
            this.WorkPlace.Controls.Add(this.deleteClient);
            this.WorkPlace.Size = new System.Drawing.Size(416, 513);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
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
            this.buttonClient.Location = new System.Drawing.Point(5, 62);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(215, 66);
            this.buttonClient.TabIndex = 6;
            this.buttonClient.Text = "Добавить администратора";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(5, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 66);
            this.button2.TabIndex = 18;
            this.button2.Text = "Добавить клиента";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(5, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 38);
            this.button3.TabIndex = 19;
            this.button3.Text = "Удалить базу";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(5, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 66);
            this.button4.TabIndex = 20;
            this.button4.Text = "Удалить свой аккаунт";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(5, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(215, 38);
            this.button5.TabIndex = 21;
            this.button5.Text = "Удалить клиента";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // deleteClient
            // 
            this.deleteClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteClient.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteClient.Controls.Add(this.button8);
            this.deleteClient.Controls.Add(this.button7);
            this.deleteClient.Controls.Add(this.pictureBox2);
            this.deleteClient.Controls.Add(this.pictureBox1);
            this.deleteClient.Controls.Add(this._password);
            this.deleteClient.Controls.Add(this._login);
            this.deleteClient.Controls.Add(this.label4);
            this.deleteClient.Controls.Add(this.button6);
            this.deleteClient.Location = new System.Drawing.Point(52, 62);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(319, 324);
            this.deleteClient.TabIndex = 3;
            this.deleteClient.Visible = false;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(33, 249);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 38);
            this.button8.TabIndex = 23;
            this.button8.Text = "Удалить";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(183, 249);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 38);
            this.button7.TabIndex = 22;
            this.button7.Text = "отмена";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            // _password
            // 
            this._password.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._password.Location = new System.Drawing.Point(74, 170);
            this._password.Name = "_password";
            this._password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._password.Size = new System.Drawing.Size(216, 35);
            this._password.TabIndex = 10;
            this._password.Enter += new System.EventHandler(this._password_Enter);
            this._password.Leave += new System.EventHandler(this._password_Leave);
            // 
            // _login
            // 
            this._login.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._login.Location = new System.Drawing.Point(74, 99);
            this._login.Name = "_login";
            this._login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._login.Size = new System.Drawing.Size(213, 35);
            this._login.TabIndex = 9;
            this._login.Enter += new System.EventHandler(this._login_Enter);
            this._login.Leave += new System.EventHandler(this._login_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Удаление клиента";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(142, 352);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 47);
            this.button6.TabIndex = 5;
            this.button6.Text = "Войти";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // AdminWindow
            // 
            this.ClientSize = new System.Drawing.Size(642, 614);
            this.Name = "AdminWindow";
            this.menu.ResumeLayout(false);
            this.WorkPlace.ResumeLayout(false);
            this.deleteClient.ResumeLayout(false);
            this.deleteClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            ClearWorcPlace();
            this.Hide();
            Registration registration = new Registration(this, _database, true);
            registration.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearWorcPlace();
            this.Hide();
            Registration registration = new Registration(this, _database, false);
            registration.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearWorcPlace();

            DialogResult dialogResult = MessageBox.Show("Вы уверены в своём решении", "УДАЛЕНИЕ БАЗЫ ДАННЫХ", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                _database.DeleteAllClient(_admin);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearWorcPlace();

            deleteClient.Visible = true;

            CorrectTextBox(_login, enterLogin);

            CorrectTextBox(_password, enterPassword);

            if (_password.Text == enterPassword)
            {
                _password.UseSystemPasswordChar = false;
            }
        } 

        private void button4_Click(object sender, EventArgs e)
        {
            ClearWorcPlace();

            DialogResult dialogResult = MessageBox.Show("Вы уверены в своём решении", "УДАЛЕНИЕ АККАУНТА АДМИНИСТРАТОРА", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                _database.DeleteAdmin(_admin);

                _startWindow.Show();

                this.Hide();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClearWorcPlace();
        }

        private void _login_Enter(object sender, EventArgs e)
        {
            _login.BackColor = Color.White;

            SetTextBox(_login, "Введите логин");
        }

        private void _login_Leave(object sender, EventArgs e)
        {
            CorrectTextBox(_login, enterLogin);

            if (_login.Text == enterLogin || _database.IsFreeLoginClients(_login.Text))
            {
                _login.BackColor = Color.Red;
            }
        }

        private void _password_Leave(object sender, EventArgs e)
        {
            CorrectTextBox(_password, enterPassword);

            if (_password.Text == enterPassword)
            {
                _password.UseSystemPasswordChar = false;

                _password.BackColor = Color.Red;
            }
            else if (! _admin.IsMyPassword(_password.Text))
            {
                _password.BackColor = Color.Red;
            }
        }

        private void _password_Enter(object sender, EventArgs e)
        {
            _password.BackColor = Color.White;

            SetTextBox(_password, enterPassword);

            _password.UseSystemPasswordChar = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_admin.IsMyPassword(_password.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены в своём решении", "УДАЛЕНИЕ АККАУНТА КЛИЕНТА", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                    if (_database.DeleteClientByAdmin(_admin, _login.Text))
                    {
                        ClearWorcPlace();

                        MessageBox.Show("Клиент удалён!!!");
                    }
                    else
                    {
                        MessageBox.Show("Такого клиента нет!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Неправильный пароль!");
            }
        }

        private void ClearWorcPlace()
        {
            _login.Text = string.Empty;

            _password.Text = string.Empty;

            deleteClient.Visible = false;
        }
    }
}