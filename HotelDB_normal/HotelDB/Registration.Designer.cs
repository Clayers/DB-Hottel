namespace HotelDB
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registration_button = new System.Windows.Forms.Button();
            this.registration_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Login_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.authorization_button = new System.Windows.Forms.Button();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.Second_Password_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Email_label = new System.Windows.Forms.Label();
            this.Second_Password_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registration_button
            // 
            this.registration_button.Location = new System.Drawing.Point(210, 172);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(99, 23);
            this.registration_button.TabIndex = 0;
            this.registration_button.Text = "Регистрация";
            this.registration_button.UseVisualStyleBackColor = true;
            this.registration_button.Click += new System.EventHandler(this.registration_button_Click);
            // 
            // registration_label
            // 
            this.registration_label.AutoSize = true;
            this.registration_label.Location = new System.Drawing.Point(128, 0);
            this.registration_label.Name = "registration_label";
            this.registration_label.Size = new System.Drawing.Size(72, 13);
            this.registration_label.TabIndex = 1;
            this.registration_label.Text = "Регистрация";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(120, 49);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(29, 13);
            this.Name_label.TabIndex = 2;
            this.Name_label.Text = "Имя";
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Location = new System.Drawing.Point(111, 71);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(38, 13);
            this.Login_label.TabIndex = 3;
            this.Login_label.Text = "Логин";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.authorization_button);
            this.groupBox1.Controls.Add(this.Login_textBox);
            this.groupBox1.Controls.Add(this.registration_button);
            this.groupBox1.Controls.Add(this.Password_textBox);
            this.groupBox1.Controls.Add(this.Email_textBox);
            this.groupBox1.Controls.Add(this.Second_Password_textBox);
            this.groupBox1.Controls.Add(this.Name_textBox);
            this.groupBox1.Controls.Add(this.Email_label);
            this.groupBox1.Controls.Add(this.Second_Password_label);
            this.groupBox1.Controls.Add(this.Password_label);
            this.groupBox1.Controls.Add(this.registration_label);
            this.groupBox1.Controls.Add(this.Login_label);
            this.groupBox1.Controls.Add(this.Name_label);
            this.groupBox1.Location = new System.Drawing.Point(197, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 331);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // authorization_button
            // 
            this.authorization_button.Location = new System.Drawing.Point(6, 302);
            this.authorization_button.Name = "authorization_button";
            this.authorization_button.Size = new System.Drawing.Size(145, 23);
            this.authorization_button.TabIndex = 12;
            this.authorization_button.Text = "Назад к авторизации";
            this.authorization_button.UseVisualStyleBackColor = true;
            this.authorization_button.Click += new System.EventHandler(this.authorization_button_Click);
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(160, 68);
            this.Login_textBox.MaxLength = 50;
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(182, 20);
            this.Login_textBox.TabIndex = 11;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(160, 94);
            this.Password_textBox.MaxLength = 50;
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(182, 20);
            this.Password_textBox.TabIndex = 10;
            // 
            // Email_textBox
            // 
            this.Email_textBox.Location = new System.Drawing.Point(160, 146);
            this.Email_textBox.MaxLength = 50;
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(182, 20);
            this.Email_textBox.TabIndex = 9;
            // 
            // Second_Password_textBox
            // 
            this.Second_Password_textBox.Location = new System.Drawing.Point(160, 120);
            this.Second_Password_textBox.MaxLength = 50;
            this.Second_Password_textBox.Name = "Second_Password_textBox";
            this.Second_Password_textBox.Size = new System.Drawing.Size(182, 20);
            this.Second_Password_textBox.TabIndex = 8;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(160, 42);
            this.Name_textBox.MaxLength = 50;
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(182, 20);
            this.Name_textBox.TabIndex = 7;
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Location = new System.Drawing.Point(111, 149);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(35, 13);
            this.Email_label.TabIndex = 6;
            this.Email_label.Text = "E-mail";
            // 
            // Second_Password_label
            // 
            this.Second_Password_label.AutoSize = true;
            this.Second_Password_label.Location = new System.Drawing.Point(37, 120);
            this.Second_Password_label.Name = "Second_Password_label";
            this.Second_Password_label.Size = new System.Drawing.Size(112, 13);
            this.Second_Password_label.TabIndex = 5;
            this.Second_Password_label.Text = "Подтвердите пароль";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(106, 94);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(45, 13);
            this.Password_label.TabIndex = 4;
            this.Password_label.Text = "Пароль";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registration_button;
        private System.Windows.Forms.Label registration_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.Label Second_Password_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.TextBox Second_Password_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Button authorization_button;
    }
}