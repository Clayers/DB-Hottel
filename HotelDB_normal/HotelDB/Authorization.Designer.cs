namespace HotelDB
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Open_registration_window_button = new System.Windows.Forms.Button();
            this.authorization_lebal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.authorization_input = new System.Windows.Forms.Button();
            this.password_lable = new System.Windows.Forms.Label();
            this.Login_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Open_registration_window_button
            // 
            this.Open_registration_window_button.Location = new System.Drawing.Point(225, 130);
            this.Open_registration_window_button.Name = "Open_registration_window_button";
            this.Open_registration_window_button.Size = new System.Drawing.Size(90, 23);
            this.Open_registration_window_button.TabIndex = 0;
            this.Open_registration_window_button.Text = "Регистрация";
            this.Open_registration_window_button.UseVisualStyleBackColor = true;
            this.Open_registration_window_button.Click += new System.EventHandler(this.Open_registration_window_button_Click);
            // 
            // authorization_lebal
            // 
            this.authorization_lebal.AutoSize = true;
            this.authorization_lebal.Location = new System.Drawing.Point(126, 0);
            this.authorization_lebal.Name = "authorization_lebal";
            this.authorization_lebal.Size = new System.Drawing.Size(73, 13);
            this.authorization_lebal.TabIndex = 1;
            this.authorization_lebal.Text = "Авторизация";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.password_textBox);
            this.groupBox1.Controls.Add(this.Login_textBox);
            this.groupBox1.Controls.Add(this.authorization_input);
            this.groupBox1.Controls.Add(this.password_lable);
            this.groupBox1.Controls.Add(this.Open_registration_window_button);
            this.groupBox1.Controls.Add(this.authorization_lebal);
            this.groupBox1.Controls.Add(this.Login_label);
            this.groupBox1.Location = new System.Drawing.Point(213, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(86, 51);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(185, 20);
            this.password_textBox.TabIndex = 4;
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(86, 25);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(185, 20);
            this.Login_textBox.TabIndex = 3;
            // 
            // authorization_input
            // 
            this.authorization_input.Location = new System.Drawing.Point(196, 77);
            this.authorization_input.Name = "authorization_input";
            this.authorization_input.Size = new System.Drawing.Size(75, 23);
            this.authorization_input.TabIndex = 2;
            this.authorization_input.Text = "Вход";
            this.authorization_input.UseVisualStyleBackColor = true;
            this.authorization_input.Click += new System.EventHandler(this.authorization_input_Click);
            // 
            // password_lable
            // 
            this.password_lable.AutoSize = true;
            this.password_lable.Location = new System.Drawing.Point(35, 54);
            this.password_lable.Name = "password_lable";
            this.password_lable.Size = new System.Drawing.Size(45, 13);
            this.password_lable.TabIndex = 1;
            this.password_lable.Text = "Пароль";
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Location = new System.Drawing.Point(42, 28);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(38, 13);
            this.Login_label.TabIndex = 0;
            this.Login_label.Text = "Логин";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Open_registration_window_button;
        private System.Windows.Forms.Label authorization_lebal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label password_lable;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Button authorization_input;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox Login_textBox;
    }
}

