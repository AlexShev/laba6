using System;
using System.Drawing;
using System.Windows.Forms;

namespace laba6
{
    class Registration : StandartForm
    {

        private Panel panel2;
        private Label label3;
        private TextBox password;
        private TextBox login;
        private PictureBox pictureBox2;
        private Button buttonClient;
        private readonly Database _database;
        private readonly string enterLogin = "Введите логин";
        private readonly string enterPassword = "Введите пароль";
        private readonly string enterLastName = "Введите фамилию";
        private readonly string enterFirstName = "Введите имя";
        private readonly string enterCity = "Введите город";

        private Button predicant;
        private PictureBox pictureBox1;
        private MaskedTextBox PhoneNumber;
        private DateTimePicker Birthday;
        private TextBox LastName;
        private TextBox City;
        private Label Sex;
        private CheckBox femal;
        private CheckBox masculine;
        private TextBox FirstName;
        private Panel ErrorDate;
        private readonly StandartForm _startWindow;
        private readonly bool _isNewAdmin;
        private readonly bool _isStartWindow;


        public Registration(StandartForm startWindow, Database database, bool IsNewAdmin = false, bool isStartWindow = false)
        {
            _startWindow = startWindow;

            _database = database;

            _isNewAdmin = IsNewAdmin;

            _isStartWindow = isStartWindow;

            if (IsNewAdmin)
            {
                InitializeComponentForAdmin();
            }
            else
            {
                InitializeComponent();

                CorrectTextBox(LastName, enterLastName);

                CorrectTextBox(FirstName, enterFirstName);

                CorrectTextBox(City, enterCity);
            }

            CorrectTextBox(login, enterLogin);

            CorrectTextBox(password, enterPassword);
        }


        private void InitializeComponentForAdmin()
        { 
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
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
            this.predicant.Click += new System.EventHandler(this.Predicant_Click);
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
            this.label3.Text = "Регистрация";
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
            this.buttonClient.Location = new System.Drawing.Point(55, 240);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(214, 47);
            this.buttonClient.TabIndex = 5;
            this.buttonClient.Text = "Зарегстрировать";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // Authorization
            // 
            this.ClientSize = new System.Drawing.Size(434, 519);
            this.Controls.Add(this.panel2);
            this.Name = "Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.panel2 = new System.Windows.Forms.Panel();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.Label();
            this.femal = new System.Windows.Forms.CheckBox();
            this.masculine = new System.Windows.Forms.CheckBox();
            this.PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.LastName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.predicant = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClient = new System.Windows.Forms.Button();
            this.ErrorDate = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.FirstName);
            this.panel2.Controls.Add(this.City);
            this.panel2.Controls.Add(this.Sex);
            this.panel2.Controls.Add(this.femal);
            this.panel2.Controls.Add(this.masculine);
            this.panel2.Controls.Add(this.PhoneNumber);
            this.panel2.Controls.Add(this.Birthday);
            this.panel2.Controls.Add(this.LastName);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.predicant);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.login);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonClient);
            this.panel2.Controls.Add(this.ErrorDate);
            this.panel2.Location = new System.Drawing.Point(59, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 509);
            this.panel2.TabIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName.Location = new System.Drawing.Point(67, 211);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(213, 35);
            this.FirstName.TabIndex = 22;
            this.FirstName.Enter += new System.EventHandler(this.FerstName_Enter);
            this.FirstName.Leave += new System.EventHandler(this.FerstName_Leave);
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.City.Location = new System.Drawing.Point(67, 305);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(213, 35);
            this.City.TabIndex = 21;
            this.City.Enter += new System.EventHandler(this.City_Enter);
            this.City.Leave += new System.EventHandler(this.City_Leave);
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sex.Location = new System.Drawing.Point(24, 394);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(53, 24);
            this.Sex.TabIndex = 20;
            this.Sex.Text = "Пол:";
            // 
            // femal
            // 
            this.femal.AutoSize = true;
            this.femal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.femal.Location = new System.Drawing.Point(194, 397);
            this.femal.Name = "femal";
            this.femal.Size = new System.Drawing.Size(89, 22);
            this.femal.TabIndex = 19;
            this.femal.Text = "Женский";
            this.femal.UseVisualStyleBackColor = true;
            this.femal.CheckedChanged += new System.EventHandler(this.femal_CheckedChanged);
            // 
            // masculine
            // 
            this.masculine.AutoSize = true;
            this.masculine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.masculine.Location = new System.Drawing.Point(91, 397);
            this.masculine.Name = "masculine";
            this.masculine.Size = new System.Drawing.Size(89, 22);
            this.masculine.TabIndex = 18;
            this.masculine.Text = "Мужской";
            this.masculine.UseVisualStyleBackColor = true;
            this.masculine.CheckedChanged += new System.EventHandler(this.masculine_CheckedChanged);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumber.Location = new System.Drawing.Point(67, 352);
            this.PhoneNumber.Mask = "+7(000)-000-00-00";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(213, 32);
            this.PhoneNumber.TabIndex = 17;
            this.PhoneNumber.Enter += new System.EventHandler(this.Phonenamber_Enter);
            this.PhoneNumber.Leave += new System.EventHandler(this.phonenamber_Leave);
            // 
            // Birthday
            // 
            this.Birthday.AccessibleName = "";
            this.Birthday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Birthday.Location = new System.Drawing.Point(67, 260);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(213, 35);
            this.Birthday.TabIndex = 16;
            this.Birthday.ValueChanged += new System.EventHandler(this.Birthday_ValueChanged);
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName.Location = new System.Drawing.Point(67, 164);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(213, 35);
            this.LastName.TabIndex = 15;
            this.LastName.Enter += new System.EventHandler(this.LastName_Enter);
            this.LastName.Leave += new System.EventHandler(this.LastName_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
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
            this.predicant.Location = new System.Drawing.Point(122, 473);
            this.predicant.Name = "predicant";
            this.predicant.Size = new System.Drawing.Size(74, 24);
            this.predicant.TabIndex = 13;
            this.predicant.Text = "назад";
            this.predicant.UseVisualStyleBackColor = false;
            this.predicant.Click += new System.EventHandler(this.Predicant_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(67, 118);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(213, 35);
            this.password.TabIndex = 10;
            this.password.Enter += new System.EventHandler(this.Password_Enter);
            this.password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(67, 72);
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
            this.label3.Size = new System.Drawing.Size(247, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "Регистрация";
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
            this.buttonClient.Location = new System.Drawing.Point(33, 433);
            this.buttonClient.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(260, 34);
            this.buttonClient.TabIndex = 5;
            this.buttonClient.Text = "Зарегестрироваться";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // ErrorDate
            // 
            this.ErrorDate.Location = new System.Drawing.Point(62, 255);
            this.ErrorDate.Name = "ErrorDate";
            this.ErrorDate.Size = new System.Drawing.Size(223, 44);
            this.ErrorDate.TabIndex = 23;
            // 
            // Registration
            // 
            this.ClientSize = new System.Drawing.Size(434, 650);
            this.Controls.Add(this.panel2);
            this.Name = "Registration";
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

            if (!IsLogin())
            {
                login.BackColor = Color.Red;
            }
        }

        private bool IsLogin() => !(login.Text == enterLogin) && StandartView.IsLogin(login.Text)
            && _database.IsFreeLoginAdmins(login.Text) &&_database.IsFreeLoginClients(login.Text);

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
        }

        private bool IsPassword() => !(password.Text == enterPassword) && !(password.Text == "");

        private bool IsNewClient() => IsLogin() && IsPassword() && IsSex() && IsString(LastName) && IsString(FirstName)
                && IsString(City) && IsPhoneNumber() && IsCorretDate();

        private bool IsNewAdmin() => IsLogin() && IsPassword();

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            if (_isNewAdmin)
            {
                if (IsNewAdmin())
                {
                    _database.AddAdmin(new Admin(login.Text, password.Text));

                    this.Hide();
                    {
                        _startWindow.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка ввода!!!\nОбратите внимание на красные поля");
                }
            }
            else
            {
                if (IsNewClient())
                {
                    _database.AddСlient(new Client(login.Text, password.Text, LastName.Text + " " + FirstName.Text,
                       (femal.Checked) ? "ж" : "м", Birthday.Value.ToShortDateString(), City.Text, PhoneNumber.Text, true));

                    if (_isStartWindow)
                    {
                        this.Hide();
                        {
                            var clientWindow = new ClientWindow(_startWindow, _database, login.Text, password.Text);

                            clientWindow.Show();
                        }
                    }
                    else
                    {
                        this.Hide();
                        {
                            _startWindow.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка ввода!!!\nОбратите внимание на красные поля");
                }
            }

        }

        private void Predicant_Click(object sender, EventArgs e)
        {
            _startWindow.Show();

            this.Hide();
        }

        private void masculine_CheckedChanged(object sender, EventArgs e)
        {
            if (masculine.Checked == true)
            {
                femal.Checked = false;
            }
        }

        private void femal_CheckedChanged(object sender, EventArgs e)
        {
            if (femal.Checked == true)
            {
                masculine.Checked = false;
            }
        }

        private bool IsSex() => femal.Checked || masculine.Checked;

        private void LastName_Enter(object sender, EventArgs e)
        {
            LastName.BackColor = Color.White;

            SetTextBox(LastName, enterLastName);
        }

        private void LastName_Leave(object sender, EventArgs e)
        {
            CorrectTextBox(LastName, enterLastName);
            try
            {
                LastName.Text = StandartView.ConverteToStandartString(LastName.Text);
            }
            catch (Exception)
            {
                LastName.BackColor = Color.Red;
            }
        }

        private void FerstName_Enter(object sender, EventArgs e)
        {
            FirstName.BackColor = Color.White;

            SetTextBox(FirstName, enterFirstName);
        }

        private void FerstName_Leave(object sender, EventArgs e)
        {
            CorrectTextBox(FirstName, enterFirstName);
            try
            {
                FirstName.Text = StandartView.ConverteToStandartString(FirstName.Text);
            }
            catch (Exception)
            {
                FirstName.BackColor = Color.Red;
            }
        }

        private void City_Enter(object sender, EventArgs e)
        {
            City.BackColor = Color.White;

            SetTextBox(City, enterCity);
        }

        private void City_Leave(object sender, EventArgs e)
        {

            CorrectTextBox(City, enterCity);
            try
            {
                City.Text = StandartView.ConverteToStandartString(City.Text);
            }
            catch (Exception)
            {
                City.BackColor = Color.Red;
            }
        }

        private bool IsString(TextBox textBox) 
        {
            try
            {
                StandartView.ConverteToStandartString(textBox.Text);

                return true;
            }
            catch (Exception)
            {
                City.BackColor = Color.Red;

                return false;
            }
        }

        private void Phonenamber_Enter(object sender, EventArgs e)
        {
            PhoneNumber.BackColor = Color.White;
        }

        private void phonenamber_Leave(object sender, EventArgs e)
        {
            if (!IsPhoneNumber())
            {
                PhoneNumber.BackColor = Color.Red;
            }
        }

        private bool IsPhoneNumber() => StandartView.IsPhoneNumber(PhoneNumber.Text);

        private bool IsCorretDate() => Birthday.Value.Date < DateTime.Now.Date;

        private void Birthday_ValueChanged(object sender, EventArgs e)
        {
            if (!IsCorretDate())
            {
                ErrorDate.BackColor = Color.Red;
            }
            else
            {
                ErrorDate.BackColor = panel2.BackColor;
            }
        }
    }
}
