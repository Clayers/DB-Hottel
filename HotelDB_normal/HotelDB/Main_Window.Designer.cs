using System;
using System.Windows.Forms;

namespace HotelDB
{
    partial class Main_Window
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.logout = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_reservation = new System.Windows.Forms.Button();
            this.Price_label = new System.Windows.Forms.Label();
            this.day_textBox = new System.Windows.Forms.TextBox();
            this.date_of_settlement_label = new System.Windows.Forms.Label();
            this.Residence_time_label = new System.Windows.Forms.Label();
            this.Price_week_label = new System.Windows.Forms.Label();
            this.Price_day_label = new System.Windows.Forms.Label();
            this.hotel_room_listBox = new System.Windows.Forms.ListBox();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Send_button = new System.Windows.Forms.Button();
            this.TextMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TopicLane = new System.Windows.Forms.ComboBox();
            this.Profile_tabPage = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.phone_number_textBox = new System.Windows.Forms.TextBox();
            this.subname_textBox = new System.Windows.Forms.TextBox();
            this.Middle_name_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Email_label = new System.Windows.Forms.Label();
            this.phone_number_label = new System.Windows.Forms.Label();
            this.Middle_name_label = new System.Windows.Forms.Label();
            this.surname_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.Messege_tabPage = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TextU = new System.Windows.Forms.TextBox();
            this.TopicLaneU = new System.Windows.Forms.TextBox();
            this.SendMessU = new System.Windows.Forms.Button();
            this.UserList = new System.Windows.Forms.ComboBox();
            this.IncomMessages = new System.Windows.Forms.ListBox();
            this.AdminPan = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDel = new System.Windows.Forms.Button();
            this.tbAdmin_email = new System.Windows.Forms.TextBox();
            this.tbAdmin_login = new System.Windows.Forms.TextBox();
            this.btnSetUser = new System.Windows.Forms.Button();
            this.tbAdmin_phone = new System.Windows.Forms.TextBox();
            this.tbAdmin_subname = new System.Windows.Forms.TextBox();
            this.tbAdmin_mName = new System.Windows.Forms.TextBox();
            this.tbAdmin_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserList2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserRole = new System.Windows.Forms.ComboBox();
            this.UserList1 = new System.Windows.Forms.ComboBox();
            this.btnSetadmin = new System.Windows.Forms.Button();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.tb_email_admin = new System.Windows.Forms.TextBox();
            this.tb_Ct_iduser = new System.Windows.Forms.TextBox();
            this.tb_Ct_Name = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.tb_msg_admin = new System.Windows.Forms.TextBox();
            this.topic_admin_contact = new System.Windows.Forms.TextBox();
            this.AdminMessages = new System.Windows.Forms.DataGridView();
            this.idMsg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView_Hotel = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView_msg = new System.Windows.Forms.DataGridView();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.Profile_tabPage.SuspendLayout();
            this.Messege_tabPage.SuspendLayout();
            this.AdminPan.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminMessages)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Hotel)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_msg)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage);
            this.tabControl1.Controls.Add(this.Profile_tabPage);
            this.tabControl1.Controls.Add(this.Messege_tabPage);
            this.tabControl1.Controls.Add(this.AdminPan);
            this.tabControl1.Location = new System.Drawing.Point(-2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.logout);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.btn_reservation);
            this.tabPage2.Controls.Add(this.Price_label);
            this.tabPage2.Controls.Add(this.day_textBox);
            this.tabPage2.Controls.Add(this.date_of_settlement_label);
            this.tabPage2.Controls.Add(this.Residence_time_label);
            this.tabPage2.Controls.Add(this.Price_week_label);
            this.tabPage2.Controls.Add(this.Price_day_label);
            this.tabPage2.Controls.Add(this.hotel_room_listBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(798, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Забронировать";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(45, 390);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(210, 23);
            this.logout.TabIndex = 11;
            this.logout.Text = "Сменить пользователя";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btn_reservation
            // 
            this.btn_reservation.Location = new System.Drawing.Point(126, 116);
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.Size = new System.Drawing.Size(129, 23);
            this.btn_reservation.TabIndex = 9;
            this.btn_reservation.Text = "Забронировать";
            this.btn_reservation.UseVisualStyleBackColor = true;
            this.btn_reservation.Click += new System.EventHandler(this.book_button_Click);
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Location = new System.Drawing.Point(123, 142);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(0, 13);
            this.Price_label.TabIndex = 8;
            // 
            // day_textBox
            // 
            this.day_textBox.Location = new System.Drawing.Point(126, 27);
            this.day_textBox.Name = "day_textBox";
            this.day_textBox.Size = new System.Drawing.Size(129, 20);
            this.day_textBox.TabIndex = 7;
            this.day_textBox.TextChanged += new System.EventHandler(this.day_textBox_TextChanged);
            this.day_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.day_textBox_number);
            // 
            // date_of_settlement_label
            // 
            this.date_of_settlement_label.AutoSize = true;
            this.date_of_settlement_label.Location = new System.Drawing.Point(30, 82);
            this.date_of_settlement_label.Name = "date_of_settlement_label";
            this.date_of_settlement_label.Size = new System.Drawing.Size(90, 13);
            this.date_of_settlement_label.TabIndex = 5;
            this.date_of_settlement_label.Text = "Дата заселения";
            // 
            // Residence_time_label
            // 
            this.Residence_time_label.AutoSize = true;
            this.Residence_time_label.Location = new System.Drawing.Point(15, 30);
            this.Residence_time_label.Name = "Residence_time_label";
            this.Residence_time_label.Size = new System.Drawing.Size(105, 13);
            this.Residence_time_label.TabIndex = 4;
            this.Residence_time_label.Text = "Время пребывания";
            // 
            // Price_week_label
            // 
            this.Price_week_label.AutoSize = true;
            this.Price_week_label.Location = new System.Drawing.Point(15, 184);
            this.Price_week_label.Name = "Price_week_label";
            this.Price_week_label.Size = new System.Drawing.Size(0, 13);
            this.Price_week_label.TabIndex = 3;
            // 
            // Price_day_label
            // 
            this.Price_day_label.AutoSize = true;
            this.Price_day_label.Location = new System.Drawing.Point(15, 159);
            this.Price_day_label.Name = "Price_day_label";
            this.Price_day_label.Size = new System.Drawing.Size(0, 13);
            this.Price_day_label.TabIndex = 2;
            // 
            // hotel_room_listBox
            // 
            this.hotel_room_listBox.FormattingEnabled = true;
            this.hotel_room_listBox.Location = new System.Drawing.Point(261, 6);
            this.hotel_room_listBox.Name = "hotel_room_listBox";
            this.hotel_room_listBox.Size = new System.Drawing.Size(525, 407);
            this.hotel_room_listBox.TabIndex = 1;
            this.hotel_room_listBox.SelectedIndexChanged += new System.EventHandler(this.hotel_room_listBox_SelectedIndexChanged);
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.label17);
            this.tabPage.Controls.Add(this.label1);
            this.tabPage.Controls.Add(this.Send_button);
            this.tabPage.Controls.Add(this.TextMessage);
            this.tabPage.Controls.Add(this.label2);
            this.tabPage.Controls.Add(this.TopicLane);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(798, 429);
            this.tabPage.TabIndex = 2;
            this.tabPage.Text = "Связь с нами";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Сообщение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Связь с администрацией";
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(683, 382);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(75, 23);
            this.Send_button.TabIndex = 3;
            this.Send_button.Text = "Отправить";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(32, 113);
            this.TextMessage.Multiline = true;
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(726, 263);
            this.TextMessage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тема обращения ";
            // 
            // TopicLane
            // 
            this.TopicLane.FormattingEnabled = true;
            this.TopicLane.Items.AddRange(new object[] {
            "Оставили ключи в номере, а дверь захлопнулась.",
            "Не убранно в номере.",
            "Оплатили бронь, но не можем приехать.",
            "Другое."});
            this.TopicLane.Location = new System.Drawing.Point(32, 59);
            this.TopicLane.Name = "TopicLane";
            this.TopicLane.Size = new System.Drawing.Size(726, 21);
            this.TopicLane.TabIndex = 0;
            // 
            // Profile_tabPage
            // 
            this.Profile_tabPage.Controls.Add(this.label13);
            this.Profile_tabPage.Controls.Add(this.Save_button);
            this.Profile_tabPage.Controls.Add(this.phone_number_textBox);
            this.Profile_tabPage.Controls.Add(this.subname_textBox);
            this.Profile_tabPage.Controls.Add(this.Middle_name_textBox);
            this.Profile_tabPage.Controls.Add(this.Name_textBox);
            this.Profile_tabPage.Controls.Add(this.Email_label);
            this.Profile_tabPage.Controls.Add(this.phone_number_label);
            this.Profile_tabPage.Controls.Add(this.Middle_name_label);
            this.Profile_tabPage.Controls.Add(this.surname_label);
            this.Profile_tabPage.Controls.Add(this.Name_label);
            this.Profile_tabPage.Controls.Add(this.login_label);
            this.Profile_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Profile_tabPage.Name = "Profile_tabPage";
            this.Profile_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Profile_tabPage.Size = new System.Drawing.Size(798, 429);
            this.Profile_tabPage.TabIndex = 3;
            this.Profile_tabPage.Text = "Профиль";
            this.Profile_tabPage.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 13;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(151, 167);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(153, 23);
            this.Save_button.TabIndex = 12;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // phone_number_textBox
            // 
            this.phone_number_textBox.Location = new System.Drawing.Point(126, 141);
            this.phone_number_textBox.Name = "phone_number_textBox";
            this.phone_number_textBox.Size = new System.Drawing.Size(178, 20);
            this.phone_number_textBox.TabIndex = 11;
            // 
            // subname_textBox
            // 
            this.subname_textBox.Location = new System.Drawing.Point(126, 89);
            this.subname_textBox.Name = "subname_textBox";
            this.subname_textBox.Size = new System.Drawing.Size(178, 20);
            this.subname_textBox.TabIndex = 10;
            // 
            // Middle_name_textBox
            // 
            this.Middle_name_textBox.Location = new System.Drawing.Point(126, 115);
            this.Middle_name_textBox.Name = "Middle_name_textBox";
            this.Middle_name_textBox.Size = new System.Drawing.Size(178, 20);
            this.Middle_name_textBox.TabIndex = 9;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(126, 63);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(178, 20);
            this.Name_textBox.TabIndex = 8;
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Location = new System.Drawing.Point(91, 41);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(35, 13);
            this.Email_label.TabIndex = 7;
            this.Email_label.Text = "E-mail";
            // 
            // phone_number_label
            // 
            this.phone_number_label.AutoSize = true;
            this.phone_number_label.Location = new System.Drawing.Point(33, 144);
            this.phone_number_label.Name = "phone_number_label";
            this.phone_number_label.Size = new System.Drawing.Size(93, 13);
            this.phone_number_label.TabIndex = 6;
            this.phone_number_label.Text = "Номер телефона";
            // 
            // Middle_name_label
            // 
            this.Middle_name_label.AutoSize = true;
            this.Middle_name_label.Location = new System.Drawing.Point(66, 118);
            this.Middle_name_label.Name = "Middle_name_label";
            this.Middle_name_label.Size = new System.Drawing.Size(54, 13);
            this.Middle_name_label.TabIndex = 5;
            this.Middle_name_label.Text = "Отчество";
            // 
            // surname_label
            // 
            this.surname_label.AutoSize = true;
            this.surname_label.Location = new System.Drawing.Point(64, 92);
            this.surname_label.Name = "surname_label";
            this.surname_label.Size = new System.Drawing.Size(56, 13);
            this.surname_label.TabIndex = 4;
            this.surname_label.Text = "Фамилия";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(91, 66);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(29, 13);
            this.Name_label.TabIndex = 3;
            this.Name_label.Text = "Имя";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(91, 23);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(38, 13);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Логин";
            // 
            // Messege_tabPage
            // 
            this.Messege_tabPage.Controls.Add(this.label18);
            this.Messege_tabPage.Controls.Add(this.label16);
            this.Messege_tabPage.Controls.Add(this.label15);
            this.Messege_tabPage.Controls.Add(this.label14);
            this.Messege_tabPage.Controls.Add(this.TextU);
            this.Messege_tabPage.Controls.Add(this.TopicLaneU);
            this.Messege_tabPage.Controls.Add(this.SendMessU);
            this.Messege_tabPage.Controls.Add(this.UserList);
            this.Messege_tabPage.Controls.Add(this.IncomMessages);
            this.Messege_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Messege_tabPage.Name = "Messege_tabPage";
            this.Messege_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Messege_tabPage.Size = new System.Drawing.Size(798, 429);
            this.Messege_tabPage.TabIndex = 4;
            this.Messege_tabPage.Text = "Сообщения";
            this.Messege_tabPage.UseVisualStyleBackColor = true;
            this.Messege_tabPage.Click += new System.EventHandler(this.Messege_tabPage_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(389, 358);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Отправить пользователю:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Входящие сообщения";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(147, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Тема";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(144, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Сообщение";
            // 
            // TextU
            // 
            this.TextU.Location = new System.Drawing.Point(144, 109);
            this.TextU.Multiline = true;
            this.TextU.Name = "TextU";
            this.TextU.Size = new System.Drawing.Size(639, 239);
            this.TextU.TabIndex = 4;
            this.TextU.Click += new System.EventHandler(this.TextU_Click);
            // 
            // TopicLaneU
            // 
            this.TopicLaneU.Location = new System.Drawing.Point(147, 55);
            this.TopicLaneU.Name = "TopicLaneU";
            this.TopicLaneU.Size = new System.Drawing.Size(622, 20);
            this.TopicLaneU.TabIndex = 3;
            // 
            // SendMessU
            // 
            this.SendMessU.Location = new System.Drawing.Point(708, 355);
            this.SendMessU.Name = "SendMessU";
            this.SendMessU.Size = new System.Drawing.Size(75, 23);
            this.SendMessU.TabIndex = 2;
            this.SendMessU.Text = "Отправить";
            this.SendMessU.UseMnemonic = false;
            this.SendMessU.UseVisualStyleBackColor = true;
            this.SendMessU.Click += new System.EventHandler(this.SendMessU_Click);
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(535, 355);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(167, 21);
            this.UserList.TabIndex = 1;
            // 
            // IncomMessages
            // 
            this.IncomMessages.FormattingEnabled = true;
            this.IncomMessages.Location = new System.Drawing.Point(11, 33);
            this.IncomMessages.Name = "IncomMessages";
            this.IncomMessages.Size = new System.Drawing.Size(127, 342);
            this.IncomMessages.TabIndex = 0;
            this.IncomMessages.SelectedIndexChanged += new System.EventHandler(this.IncomMessages_SelectedIndexChanged);
            // 
            // AdminPan
            // 
            this.AdminPan.Controls.Add(this.tabControl2);
            this.AdminPan.Location = new System.Drawing.Point(4, 22);
            this.AdminPan.Name = "AdminPan";
            this.AdminPan.Size = new System.Drawing.Size(798, 429);
            this.AdminPan.TabIndex = 5;
            this.AdminPan.Text = "Админ панель";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(795, 423);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDel);
            this.tabPage3.Controls.Add(this.tbAdmin_email);
            this.tabPage3.Controls.Add(this.tbAdmin_login);
            this.tabPage3.Controls.Add(this.btnSetUser);
            this.tabPage3.Controls.Add(this.tbAdmin_phone);
            this.tabPage3.Controls.Add(this.tbAdmin_subname);
            this.tabPage3.Controls.Add(this.tbAdmin_mName);
            this.tabPage3.Controls.Add(this.tbAdmin_name);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.UserList2);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.UserRole);
            this.tabPage3.Controls.Add(this.UserList1);
            this.tabPage3.Controls.Add(this.btnSetadmin);
            this.tabPage3.Controls.Add(this.dataGridViewUser);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(787, 397);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Пользователи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(608, 355);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(158, 23);
            this.btnDel.TabIndex = 25;
            this.btnDel.Text = "Удалить пользователя";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tbAdmin_email
            // 
            this.tbAdmin_email.Location = new System.Drawing.Point(588, 292);
            this.tbAdmin_email.Name = "tbAdmin_email";
            this.tbAdmin_email.Size = new System.Drawing.Size(178, 20);
            this.tbAdmin_email.TabIndex = 24;
            // 
            // tbAdmin_login
            // 
            this.tbAdmin_login.Location = new System.Drawing.Point(297, 271);
            this.tbAdmin_login.Name = "tbAdmin_login";
            this.tbAdmin_login.Size = new System.Drawing.Size(178, 20);
            this.tbAdmin_login.TabIndex = 23;
            // 
            // btnSetUser
            // 
            this.btnSetUser.Location = new System.Drawing.Point(684, 318);
            this.btnSetUser.Name = "btnSetUser";
            this.btnSetUser.Size = new System.Drawing.Size(82, 23);
            this.btnSetUser.TabIndex = 22;
            this.btnSetUser.Text = "Сохранить пользователя";
            this.btnSetUser.UseVisualStyleBackColor = true;
            this.btnSetUser.Click += new System.EventHandler(this.btnSetUser_Click);
            // 
            // tbAdmin_phone
            // 
            this.tbAdmin_phone.Location = new System.Drawing.Point(588, 269);
            this.tbAdmin_phone.Name = "tbAdmin_phone";
            this.tbAdmin_phone.Size = new System.Drawing.Size(178, 20);
            this.tbAdmin_phone.TabIndex = 21;
            // 
            // tbAdmin_subname
            // 
            this.tbAdmin_subname.Location = new System.Drawing.Point(297, 322);
            this.tbAdmin_subname.Name = "tbAdmin_subname";
            this.tbAdmin_subname.Size = new System.Drawing.Size(178, 20);
            this.tbAdmin_subname.TabIndex = 20;
            // 
            // tbAdmin_mName
            // 
            this.tbAdmin_mName.Location = new System.Drawing.Point(297, 348);
            this.tbAdmin_mName.Name = "tbAdmin_mName";
            this.tbAdmin_mName.Size = new System.Drawing.Size(178, 20);
            this.tbAdmin_mName.TabIndex = 19;
            // 
            // tbAdmin_name
            // 
            this.tbAdmin_name.Location = new System.Drawing.Point(297, 296);
            this.tbAdmin_name.Name = "tbAdmin_name";
            this.tbAdmin_name.Size = new System.Drawing.Size(178, 20);
            this.tbAdmin_name.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(491, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Номер телефона";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Отчество";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Фамилия";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Имя";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(249, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Логин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Изменить данные пользователя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Пользователь";
            // 
            // UserList2
            // 
            this.UserList2.FormattingEnabled = true;
            this.UserList2.Location = new System.Drawing.Point(9, 308);
            this.UserList2.Name = "UserList2";
            this.UserList2.Size = new System.Drawing.Size(208, 21);
            this.UserList2.TabIndex = 6;
            this.UserList2.SelectedIndexChanged += new System.EventHandler(this.UserList2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Права";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пользователь";
            // 
            // UserRole
            // 
            this.UserRole.FormattingEnabled = true;
            this.UserRole.Items.AddRange(new object[] {
            "Пользователь",
            "Администратор"});
            this.UserRole.Location = new System.Drawing.Point(234, 217);
            this.UserRole.Name = "UserRole";
            this.UserRole.Size = new System.Drawing.Size(208, 21);
            this.UserRole.TabIndex = 3;
            // 
            // UserList1
            // 
            this.UserList1.FormattingEnabled = true;
            this.UserList1.Location = new System.Drawing.Point(6, 217);
            this.UserList1.Name = "UserList1";
            this.UserList1.Size = new System.Drawing.Size(208, 21);
            this.UserList1.TabIndex = 2;
            this.UserList1.SelectedIndexChanged += new System.EventHandler(this.UserList1_SelectedIndexChanged);
            // 
            // btnSetadmin
            // 
            this.btnSetadmin.Location = new System.Drawing.Point(448, 215);
            this.btnSetadmin.Name = "btnSetadmin";
            this.btnSetadmin.Size = new System.Drawing.Size(166, 23);
            this.btnSetadmin.TabIndex = 1;
            this.btnSetadmin.Text = "Устоновить права";
            this.btnSetadmin.UseVisualStyleBackColor = true;
            this.btnSetadmin.Click += new System.EventHandler(this.btnSetadmin_Click);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.Size = new System.Drawing.Size(773, 190);
            this.dataGridViewUser.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox20);
            this.tabPage4.Controls.Add(this.textBox19);
            this.tabPage4.Controls.Add(this.textBox18);
            this.tabPage4.Controls.Add(this.textBox17);
            this.tabPage4.Controls.Add(this.tb_email_admin);
            this.tabPage4.Controls.Add(this.tb_Ct_iduser);
            this.tabPage4.Controls.Add(this.tb_Ct_Name);
            this.tabPage4.Controls.Add(this.textBox14);
            this.tabPage4.Controls.Add(this.tb_msg_admin);
            this.tabPage4.Controls.Add(this.topic_admin_contact);
            this.tabPage4.Controls.Add(this.AdminMessages);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(787, 397);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Обратная связь";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox20
            // 
            this.textBox20.AccessibleName = "";
            this.textBox20.Location = new System.Drawing.Point(17, 220);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(114, 20);
            this.textBox20.TabIndex = 28;
            this.textBox20.Text = "Сообщение";
            // 
            // textBox19
            // 
            this.textBox19.AccessibleName = "";
            this.textBox19.Location = new System.Drawing.Point(17, 168);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(114, 20);
            this.textBox19.TabIndex = 27;
            this.textBox19.Text = "Тема";
            // 
            // textBox18
            // 
            this.textBox18.AccessibleName = "";
            this.textBox18.Location = new System.Drawing.Point(571, 116);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(109, 20);
            this.textBox18.TabIndex = 26;
            this.textBox18.Text = "Почта отправителя:";
            // 
            // textBox17
            // 
            this.textBox17.AccessibleName = "";
            this.textBox17.Location = new System.Drawing.Point(284, 116);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(86, 20);
            this.textBox17.TabIndex = 25;
            this.textBox17.Text = "ID отправителя:";
            // 
            // tb_email_admin
            // 
            this.tb_email_admin.Location = new System.Drawing.Point(571, 142);
            this.tb_email_admin.Name = "tb_email_admin";
            this.tb_email_admin.ReadOnly = true;
            this.tb_email_admin.Size = new System.Drawing.Size(150, 20);
            this.tb_email_admin.TabIndex = 24;
            // 
            // tb_Ct_iduser
            // 
            this.tb_Ct_iduser.Location = new System.Drawing.Point(284, 142);
            this.tb_Ct_iduser.Name = "tb_Ct_iduser";
            this.tb_Ct_iduser.ReadOnly = true;
            this.tb_Ct_iduser.Size = new System.Drawing.Size(150, 20);
            this.tb_Ct_iduser.TabIndex = 23;
            // 
            // tb_Ct_Name
            // 
            this.tb_Ct_Name.Location = new System.Drawing.Point(17, 142);
            this.tb_Ct_Name.Name = "tb_Ct_Name";
            this.tb_Ct_Name.ReadOnly = true;
            this.tb_Ct_Name.Size = new System.Drawing.Size(150, 20);
            this.tb_Ct_Name.TabIndex = 22;
            // 
            // textBox14
            // 
            this.textBox14.AccessibleName = "";
            this.textBox14.Location = new System.Drawing.Point(17, 116);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(86, 20);
            this.textBox14.TabIndex = 21;
            this.textBox14.Text = "Отправитель:";
            // 
            // tb_msg_admin
            // 
            this.tb_msg_admin.Location = new System.Drawing.Point(17, 246);
            this.tb_msg_admin.Multiline = true;
            this.tb_msg_admin.Name = "tb_msg_admin";
            this.tb_msg_admin.ReadOnly = true;
            this.tb_msg_admin.Size = new System.Drawing.Size(704, 114);
            this.tb_msg_admin.TabIndex = 20;
            // 
            // topic_admin_contact
            // 
            this.topic_admin_contact.Location = new System.Drawing.Point(17, 194);
            this.topic_admin_contact.Name = "topic_admin_contact";
            this.topic_admin_contact.ReadOnly = true;
            this.topic_admin_contact.Size = new System.Drawing.Size(704, 20);
            this.topic_admin_contact.TabIndex = 19;
            // 
            // AdminMessages
            // 
            this.AdminMessages.AllowUserToAddRows = false;
            this.AdminMessages.AllowUserToDeleteRows = false;
            this.AdminMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdminMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMsg,
            this.UserName,
            this.Topic,
            this.Message});
            this.AdminMessages.Location = new System.Drawing.Point(3, 6);
            this.AdminMessages.Name = "AdminMessages";
            this.AdminMessages.ReadOnly = true;
            this.AdminMessages.Size = new System.Drawing.Size(773, 104);
            this.AdminMessages.TabIndex = 1;
            this.AdminMessages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminMessages_CellContentClick_1);
            // 
            // idMsg
            // 
            this.idMsg.HeaderText = "id";
            this.idMsg.Name = "idMsg";
            this.idMsg.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Пользователь";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Topic
            // 
            this.Topic.HeaderText = "Тема";
            this.Topic.Name = "Topic";
            this.Topic.ReadOnly = true;
            // 
            // Message
            // 
            this.Message.HeaderText = "Сообщение";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.textBox8);
            this.tabPage5.Controls.Add(this.textBox7);
            this.tabPage5.Controls.Add(this.textBox6);
            this.tabPage5.Controls.Add(this.textBox5);
            this.tabPage5.Controls.Add(this.dataGridView_Hotel);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(787, 397);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Отель";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Создать";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox8
            // 
            this.textBox8.AccessibleName = "";
            this.textBox8.Location = new System.Drawing.Point(10, 276);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(128, 20);
            this.textBox8.TabIndex = 26;
            this.textBox8.Text = "Цена";
            // 
            // textBox7
            // 
            this.textBox7.AccessibleName = "";
            this.textBox7.Location = new System.Drawing.Point(10, 250);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(128, 20);
            this.textBox7.TabIndex = 25;
            this.textBox7.Text = "Название комнаты";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(144, 276);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 20);
            this.textBox6.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(144, 250);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 20);
            this.textBox5.TabIndex = 23;
            // 
            // dataGridView_Hotel
            // 
            this.dataGridView_Hotel.AllowUserToAddRows = false;
            this.dataGridView_Hotel.AllowUserToDeleteRows = false;
            this.dataGridView_Hotel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Hotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Hotel.Location = new System.Drawing.Point(6, 12);
            this.dataGridView_Hotel.Name = "dataGridView_Hotel";
            this.dataGridView_Hotel.ReadOnly = true;
            this.dataGridView_Hotel.Size = new System.Drawing.Size(773, 232);
            this.dataGridView_Hotel.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridView_msg);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(787, 397);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Сообщения";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView_msg
            // 
            this.dataGridView_msg.AllowUserToAddRows = false;
            this.dataGridView_msg.AllowUserToDeleteRows = false;
            this.dataGridView_msg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_msg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_msg.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_msg.Name = "dataGridView_msg";
            this.dataGridView_msg.ReadOnly = true;
            this.dataGridView_msg.Size = new System.Drawing.Size(773, 385);
            this.dataGridView_msg.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.Location = new System.Drawing.Point(0, 0);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Пользователь",
            "Администратор"});
            this.comboBox2.Location = new System.Drawing.Point(267, 170);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(208, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel DB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Window_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            this.Profile_tabPage.ResumeLayout(false);
            this.Profile_tabPage.PerformLayout();
            this.Messege_tabPage.ResumeLayout(false);
            this.Messege_tabPage.PerformLayout();
            this.AdminPan.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminMessages)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Hotel)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_msg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TabPage Profile_tabPage;
        private System.Windows.Forms.ListBox hotel_room_listBox;
        private System.Windows.Forms.Label date_of_settlement_label;
        private System.Windows.Forms.Label Residence_time_label;
        private System.Windows.Forms.Label Price_week_label;
        private System.Windows.Forms.Label Price_day_label;
        private System.Windows.Forms.Button btn_reservation;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.TextBox day_textBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TopicLane;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.TextBox TextMessage;
        private System.Windows.Forms.TextBox subname_textBox;
        private System.Windows.Forms.TextBox Middle_name_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.Label phone_number_label;
        private System.Windows.Forms.Label Middle_name_label;
        private System.Windows.Forms.Label surname_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.TabPage Messege_tabPage;
        private System.Windows.Forms.TextBox phone_number_textBox;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.ListBox IncomMessages;
        private System.Windows.Forms.TabPage AdminPan;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tbAdmin_email;
        private System.Windows.Forms.TextBox tbAdmin_login;
        private System.Windows.Forms.Button btnSetUser;
        private System.Windows.Forms.TextBox tbAdmin_phone;
        private System.Windows.Forms.TextBox tbAdmin_subname;
        private System.Windows.Forms.TextBox tbAdmin_mName;
        private System.Windows.Forms.TextBox tbAdmin_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private ComboBox comboBox3;
        private System.Windows.Forms.ComboBox UserList2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private System.Windows.Forms.ComboBox UserRole;
        private System.Windows.Forms.ComboBox UserList1;
        private System.Windows.Forms.Button btnSetadmin;
        private System.Windows.Forms.Button SendMessU;
        private System.Windows.Forms.ComboBox UserList;
        private System.Windows.Forms.TextBox TopicLaneU;
        private System.Windows.Forms.TextBox TextU;
        private DataGridView AdminMessages;
        private DataGridView dataGridView_Hotel;
        private TabPage tabPage6;
        private DataGridView dataGridView_msg;
        private TextBox tb_email_admin;
        private TextBox tb_Ct_iduser;
        private TextBox tb_Ct_Name;
        private TextBox textBox14;
        private TextBox tb_msg_admin;
        private TextBox topic_admin_contact;
        private DataGridViewTextBoxColumn id;
        private Button button1;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private DataGridViewTextBoxColumn idMsg;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Topic;
        private DataGridViewTextBoxColumn Message;
        private Label label1;
        private TextBox textBox17;
        private TextBox textBox20;
        private TextBox textBox19;
        private TextBox textBox18;
        private Button logout;
        private Label label13;
        private Label label16;
        private Label label15;
        private Label label14;
        private Button btnDel;
        private Label label17;
        private Label label18;
    }
}