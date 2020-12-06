using System;
using System.Linq;
using System.Windows.Forms;

namespace laba6
{
    class ClientWindow : WorkWindow
    {
        private System.Windows.Forms.Button button5;
        private Button button2;
        private Button button4;
        private Button button3;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Client _client;

        public ClientWindow(StandartForm startWindow, Database database, string login, string password)
            : base (startWindow, database)
        {
            _client = database.GetClient(login, password);

            InitializeComponent();

            ClearWorcPlace();
        }

        private void InitializeComponent()
        {
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menu.SuspendLayout();
            this.WorkPlace.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Controls.Add(this.button4);
            this.menu.Controls.Add(this.button3);
            this.menu.Controls.Add(this.button2);
            this.menu.Controls.Add(this.button5);
            this.menu.Size = new System.Drawing.Size(226, 403);
            this.menu.Controls.SetChildIndex(this.button5, 0);
            this.menu.Controls.SetChildIndex(this.button2, 0);
            this.menu.Controls.SetChildIndex(this.button3, 0);
            this.menu.Controls.SetChildIndex(this.button4, 0);
            // 
            // WorkPlace
            // 
            this.WorkPlace.Controls.Add(this.panel4);
            this.WorkPlace.Controls.Add(this.panel3);
            this.WorkPlace.Size = new System.Drawing.Size(600, 403);
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
            this.button5.Location = new System.Drawing.Point(5, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(215, 38);
            this.button5.TabIndex = 22;
            this.button5.Text = "Удалить аккаунт";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            this.button2.Location = new System.Drawing.Point(5, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 38);
            this.button2.TabIndex = 23;
            this.button2.Text = "Поощрить нас";
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
            this.button3.Location = new System.Drawing.Point(5, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 65);
            this.button3.TabIndex = 24;
            this.button3.Text = "Посмотреть профиль";
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
            this.button4.Location = new System.Drawing.Point(5, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 38);
            this.button4.TabIndex = 25;
            this.button4.Text = "Найти пару";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 34);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.MaximumSize = new System.Drawing.Size(0, 34);
            this.label3.MinimumSize = new System.Drawing.Size(0, 34);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(600, 34);
            this.label3.TabIndex = 0;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 369);
            this.panel4.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(600, 369);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(600, 369);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClientWindow
            // 
            this.ClientSize = new System.Drawing.Size(826, 504);
            this.Name = "ClientWindow";
            this.menu.ResumeLayout(false);
            this.WorkPlace.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearWorcPlace();

            DialogResult dialogResult = MessageBox.Show("Вы уверены в своём решении?", "УДАЛИТЬ СВОЙ АККАУНТ", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                _database.DeleteClientByClient(_client);

                _startWindow.Show();

                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearWorcPlace();

            MessageBox.Show("Спасибо нам это очень важно!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearWorcPlace();

            textBox2.Visible = true;

            label3.Text = "Мои данные";

            textBox2.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine +

                "ФИО: " + _client.MyFulName + Environment.NewLine + Environment.NewLine +

                "Дата рождения: " + _client.MyBirthday.ToShortDateString() +Environment.NewLine + Environment.NewLine +

                "Возраст " + _client.MyAge + Environment.NewLine + Environment.NewLine +

                "Мои контакты:" + Environment.NewLine + Environment.NewLine +

                "Логин: " + _client.Login + Environment.NewLine + Environment.NewLine +

                "Номер телефона: " + _client.MyPhoneNumber;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearWorcPlace();

            var counter = 0;

            var temp = _database.FindPiars(_client);

            if (temp.Any())
            {
                textBox1.Visible = true;

                label3.Text = "Чем ближе число к 100, тем больше Вам подходит человек";

                foreach (var c in temp)
                {

                    textBox1.Text += Environment.NewLine + $"================================================={c.Key}=================================================" + Environment.NewLine;

                    foreach (var c1 in c.Value)
                    {

                        textBox1.Text += Environment.NewLine + $"№{++counter} ";

                        PrintClient(c1);
                    }
                }

                textBox1.Text += Environment.NewLine + "============================================КОНЕЦ СПИСКА=============================================" + Environment.NewLine;
            }
            else
            {
                label3.Text = "Мы не смогли подобрать Вам пару, подождите немного, надеемся, что скоро мы сможем это сделать";
            }


        }

        private void PrintClient(Client client)
        {
            textBox1.Text += $"ФИО {client.MyFulName} родил{((client.MySex.MySex == Gender.Sex.masculine) ? "ся" : "ась")} " +
                $"{client.MyBirthday.ToShortDateString()} возраст {client.MyAge} контакты: логин {client.Login} номер телефона {client.MyPhoneNumber}" + Environment.NewLine + Environment.NewLine;
        }

        private void ClearWorcPlace() 
        {
            label3.Text = string.Empty;

            textBox1.Text = string.Empty;

            textBox2.Text = string.Empty;

            textBox1.Visible = false;

            textBox2.Visible = false;
        }
    }
}
