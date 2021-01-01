using Npgsql;

using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HotelDB
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
            updateStat();
            update();
            UpdateListBoxHostelRoom();
            UpdateUserProfileRoom();
            if (UserController.AuthorizationUser.access_level == 1) //Проверка на админа
                tabControl1.TabPages.Remove(AdminPan);
            else
            {
                UpdateAdmiListUserALL();
                UpdateContactAdminPanel();
                UpdateAdmiListUser();
                UpdateAdmiListHotelALL();
                UpdateAdmiListMsglALL();
            }
            UpdateIncomingList();
            UpdateUserListMessage();
        }

        private void UpdateAdmiListUserALL() //Обнавление листа в админ панели
        {
            if (UserController.AuthorizationUser.access_level != 0)
                return;

            string sql = ("SELECT * FROM Users");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, Program.Connection);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridViewUser.DataSource = dt;
        }

        private void UpdateAdmiListHotelALL() //Обнавление листа в админ панели
        {
            if (UserController.AuthorizationUser.access_level != 0)
                return;

            string sql = ("SELECT * FROM hotelroom");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, Program.Connection);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView_Hotel.DataSource = dt;
        }

        private void UpdateAdmiListMsglALL() //Обнавление листа в админ панели
        {
            if (UserController.AuthorizationUser.access_level != 0)
                return;

            string sql = ("SELECT * FROM Messages");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, Program.Connection);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView_msg.DataSource = dt;
        }

        private void UpdateAdmiListUser() //Обнавление листа в админ панели
        {
            if (UserController.AuthorizationUser.access_level != 0)
                return;

            UserList1.Items.Clear();
            UserList2.Items.Clear();

            foreach (User user in AdminController.GetAllIdUser())
            {
                UserList1.Items.Add($"{user.login}");
                UserList2.Items.Add($"{user.login}");
            }
        }

        private void book_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(dateTimePicker1.Text) || String.IsNullOrWhiteSpace(day_textBox.Text))
            {
                MessageBox.Show("Данные введены не коректно.");
                return;
            }
            if (hotel_room_listBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберете номер.");
                return;
            }

            if (HotelRoomController.GetHotelRoom(hotel_room_listBox.SelectedIndex + 1).date_reservation != null)
            {
                MessageBox.Show("Номер уже забронирован.");
                return;
            }

            if (HotelRoomController.PresenceOfTheUser() == false)
            {
                MessageBox.Show("Вы можете забронировать лишь 1 номер.");
                return;
            }
            else
            {
                MessageBox.Show("Чек на оплату номера, выслан вам на почту.");
                Book();
                hotel_room_listBox.Items.Clear();
                UpdateListBoxHostelRoom();
            }
            UpdateUserProfileRoom();
        }

        private void Book()
        {
            DateTime date = dateTimePicker1.Value.Date;

            HotelRoomController.SelectRoom.id_user_book = UserController.AuthorizationUser.ID;
            HotelRoomController.SelectRoom.date_reservation = date.ToString("dd/M/yyyy");

            HotelRoomController.SelectRoom.date_end_reservation = (date.AddDays(Convert.ToDouble(day_textBox.Text))).ToString("dd/M/yyyy");
            HotelRoomController.Update(Convert.ToInt32(hotel_room_listBox.SelectedIndex) + 1, HotelRoomController.SelectRoom);
        }

        private void update()
        {
            Name_textBox.Text = UserController.AuthorizationUser.first_name;
            subname_textBox.Text = UserController.AuthorizationUser.last_name;
            Middle_name_textBox.Text = UserController.AuthorizationUser.last_name;
            phone_number_textBox.Text = UserController.AuthorizationUser.phone_number;
            UpdateAdmiListUserALL();
        }

        private void updateStat()
        {
            login_label.Text = "Логин: " + UserController.AuthorizationUser.login;
            Email_label.Text = "Email: " + UserController.AuthorizationUser.email;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (isValid(phone_number_textBox.Text) == false)
            {
                MessageBox.Show("Номер телефона введен не коректно");
                phone_number_textBox.Text = "";
                return;
            }
            if (Name_textBox.Text.Length < 2)
            {
                MessageBox.Show("Количество символов в имени должно превышать 2");
                Name_textBox.Text = "";
                return;
            }
            if (subname_textBox.Text.Length < 2)
            {
                MessageBox.Show("Количество символов в фамилии должно превышать 2");
                subname_textBox.Text = "";
                return;
            }
            if (Middle_name_textBox.Text.Length < 2)
            {
                MessageBox.Show("Количество символов в отчестве должно превышать 2");
                Middle_name_textBox.Text = "";
                return;
            }

            UserController.AuthorizationUser.phone_number = phone_number_textBox.Text;
            UserController.AuthorizationUser.first_name = Name_textBox.Text;
            UserController.AuthorizationUser.last_name = subname_textBox.Text;
            UserController.AuthorizationUser.middle_name = Middle_name_textBox.Text;

            UserController.Update(UserController.AuthorizationUser.ID, UserController.AuthorizationUser);
            update();
            MessageBox.Show("Данные сохранены");
        }

        public static bool isValid(string phonenumber) //Проверка правильности ввода телефона
        {
            string pattern = @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$";
            Match isMatch = Regex.Match(phonenumber, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        public void Bookupdate()
        {
            HotelRoom room = HotelRoomController.GetHotelRoom(hotel_room_listBox.SelectedIndex + 1);
            if (room == null) return;
            Price_day_label.Text = "Цена за день:" + Convert.ToString(room.room_price);
            Price_week_label.Text = "Цена за неделю:" + Convert.ToString(room.room_price * 6);
        }

        private void hotel_room_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HotelRoom room = HotelRoomController.GetHotelRoom(hotel_room_listBox.SelectedIndex + 1);
            if (room == null) return;
            if (day_textBox.Text == "")
            {
                Price_label.Text = "";
            }
            else
            {
                Price_label.Text = "Итоговая цена:" + ((int.Parse(day_textBox.Text) / 7 * room.room_price * 6 + int.Parse(day_textBox.Text) % 7 * room.room_price).ToString());
            }
            Bookupdate();
        }

        private void day_textBox_TextChanged(object sender, EventArgs e)
        {
            HotelRoom room = HotelRoomController.GetHotelRoom(hotel_room_listBox.SelectedIndex + 1);
            if (room == null) return;
            if (day_textBox.Text == "")
            {
                Price_label.Text = "";
            }
            else
            {
                Price_label.Text = "Итоговая цена:" + ((int.Parse(day_textBox.Text) / 7 * room.room_price * 6 + int.Parse(day_textBox.Text) % 7 * room.room_price).ToString());
            }
        }

        private void UpdateUserProfileRoom()
        {
            var room = HotelRoomController.GetHotelRoomFromIDUser(UserController.AuthorizationUser.ID);
            if (room == null || room.date_reservation == null) return;

            label13.Text = "Ваша бронь: Номер комнаты:" +
                room.ID.ToString() + " | Цена:" +
                room.room_price.ToString() + " | Тип:" +
                room.name_room.ToString() + " | Забронировано c: " +
                room.date_reservation + " | До: " + room.date_end_reservation;
        }

        private void UpdateListBoxHostelRoom()
        {
            hotel_room_listBox.BeginUpdate();
            int mxidhr = HotelRoomController.Maxid();
            if (mxidhr == 0) { return; }
            else
            {
                for (int i = 1; i < mxidhr + 1; i++)
                {
                    HotelRoom room = HotelRoomController.GetHotelRoom(i);
                    if (room.date_reservation == null)
                        hotel_room_listBox.Items.Add("Номер комнаты:" + i.ToString() + " | Цена:" + room.room_price.ToString() + " | Тип:" + room.name_room.ToString() + " | СВОБОДНО");
                    else
                        hotel_room_listBox.Items.Add("Номер комнаты:" + i.ToString() + " | Цена:" + room.room_price.ToString() + " | Тип:" + room.name_room.ToString() + " | Забронировано c: " + room.date_reservation + " | До: " + room.date_end_reservation);
                }
                hotel_room_listBox.EndUpdate();
            }
        }

        private void Send_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TopicLane.Text) & !String.IsNullOrWhiteSpace(TextMessage.Text))
            {
                ContactController.PushMessage(UserController.AuthorizationUser.ID, TopicLane.Text, TextMessage.Text);
                MessageBox.Show("Ваше сообщение отправлено");
                UpdateContactAdminPanel();
            }
            else
            {
                MessageBox.Show("Заполните все поля");//TODO Доебашить ошибку в выводе хуеты
            }
        }

        private void UpdateContactAdminPanel() //Обновление данных в админ панели
        {
            AdminMessages.Rows.Clear();
            List<int> ListId = ContactController.GetAllIdPushed();
            if (ListId == null) return;
            foreach (var IdMessage in ListId)
            {
                var IdUser = ContactController.GetIdUserFromIdMessage(IdMessage);
                var user = UserController.GetUser(IdUser);
                var Topic = ContactController.GetTopicFromId(IdMessage);
                var Message = ContactController.GetMessageFromId(IdMessage);
                if (user == null)
                {
                    continue;
                }
                tb_Ct_Name.Text = $"{user.first_name} {user.last_name}";
                tb_Ct_iduser.Text = user.ID.ToString();
                tb_email_admin.Text = user.email;
                topic_admin_contact.Text = Topic;
                tb_msg_admin.Text = Message;
                var index = AdminMessages.Rows.Add();
                AdminMessages.Rows[index].Cells["idMsg"].Value = IdMessage;
                AdminMessages.Rows[index].Cells["UserName"].Value = user.first_name + " " + user.last_name;
                AdminMessages.Rows[index].Cells["Topic"].Value = Topic;
                AdminMessages.Rows[index].Cells["Message"].Value = Message;
            }
        }

        private void day_textBox_number(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void UserList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            User user = UserController.GetUser(UserList1.Text);
            if (user == null) return;

            if (user.access_level == 0)
            {
                UserRole.SelectedIndex = 1; //Админ
            }
            else
            {
                UserRole.SelectedIndex = 0; //пользователь
            }
        }

        private void UserList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            User user = UserController.GetUser(UserList2.Text);
            if (user == null) return;

            tbAdmin_login.Text = user.login;
            tbAdmin_name.Text = user.first_name;
            tbAdmin_subname.Text = user.last_name;
            tbAdmin_mName.Text = user.middle_name;
            tbAdmin_phone.Text = user.phone_number;
            tbAdmin_email.Text = user.email;
        }

        private void btnSetadmin_Click(object sender, EventArgs e)
        {
            User user = UserController.GetUser(UserList1.Text);
            if (user == null) return;

            if (UserRole.SelectedItem.ToString() == "Администратор")
            {
                user.access_level = 0;
            }
            else
            {
                user.access_level = 1;
            }

            UserController.Update(user.ID, user);
            UpdateAdmiListUserALL();

            if (user.access_level == 0)
            {
                UserRole.SelectedIndex = 1; //Админ
            }
            else
            {
                UserRole.SelectedIndex = 0; //пользователь
            }

            MessageBox.Show("Успешно!");
        }

        private void btnSetUser_Click(object sender, EventArgs e)
        {
            User user = UserController.GetUser(UserList2.Text);
            if (user == null) return;
            user.login = tbAdmin_login.Text;
            user.first_name = tbAdmin_name.Text;
            user.last_name = tbAdmin_subname.Text;
            user.middle_name = tbAdmin_mName.Text;
            user.phone_number = tbAdmin_phone.Text;
            user.email = tbAdmin_email.Text;

            UserController.Update(user.ID, user);
            UpdateAdmiListUserALL();
            MessageBox.Show("Успешно!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HotelRoomController.AddHotelroom(textBox5.Text, null, null, null, Int32.Parse(textBox6.Text));
            UpdateAdmiListHotelALL();
            hotel_room_listBox.Items.Clear();
            UpdateListBoxHostelRoom();

        }

        private void AdminMessages_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int IdMessage = Int32.Parse(AdminMessages.Rows[AdminMessages.CurrentRow.Index].Cells["idMsg"].Value.ToString());
            int IdUser = ContactController.GetIdUserFromIdMessage(IdMessage);
            User user = UserController.GetUser(IdUser);
            string Topic = ContactController.GetTopicFromId(IdMessage);
            string Message = ContactController.GetMessageFromId(IdMessage);
            if (user == null) return;
            tb_Ct_Name.Text = $"{user.first_name} {user.last_name}";
            tb_Ct_iduser.Text = user.ID.ToString();
            tb_email_admin.Text = user.email;
            topic_admin_contact.Text = Topic;
            tb_msg_admin.Text = Message;
        }

        private void SendMessU_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TopicLaneU.Text) & !String.IsNullOrWhiteSpace(TextU.Text))
            {
                User user = UserController.GetUser(UserList.Text);
                if (user == null) { MessageBox.Show("Пользователь не найден"); return; }
                MessageController.PushMessageToAnotherUser(UserController.AuthorizationUser.ID, user.ID, TopicLaneU.Text, TextU.Text);
                MessageBox.Show("Ваше сообщение отправлено");
                UpdateIncomingList();
            }
            else
            {
                MessageBox.Show("Заполните все поля");//TODO Доебашить ошибку в выводе хуеты
            }
        }

        private void UpdateUserListMessage()
        {
            UserList.Items.Clear();

            foreach (User user in AdminController.GetAllIdUser())
            {
                UserList.Items.Add($"{user.login}");
            }
        }

        private void UpdateIncomingList()
        {
            List<Message> MSG = MessageController.GetAllMessage();
            if (MSG == null) return;
            IncomMessages.Items.Clear();
            foreach (var item in MSG)
            {
                if (item.Adressee_ID == UserController.AuthorizationUser.ID)
                {
                    User user = UserController.GetUser(item.Adresser_ID);
                    item.Name = user.first_name + " " + user.last_name;
                    IncomMessages.Items.Add(item);
                }
            }
        }

        private void IncomMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.IncomMessages.SelectedItems.Count != 0)
                SendMessU.Enabled = false;
            else
            {
                SendMessU.Enabled = true;
                return;
            }
            Message msg = (Message)IncomMessages.Items[IncomMessages.SelectedIndex];
            TopicLaneU.Text = msg.Topic;
            TextU.Text = msg.Text;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }

        private void Messege_tabPage_Click(object sender, EventArgs e)
        {
            IncomMessages.ClearSelected();
        }

        private void TextU_Click(object sender, EventArgs e)
        {
            IncomMessages.ClearSelected();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var user = UserController.GetUser(UserList2.Text);
            UserController.Delate(user.ID);
            tbAdmin_login.Text = "";
            tbAdmin_name.Text = "";
            tbAdmin_subname.Text = "";
            tbAdmin_mName.Text = "";
            tbAdmin_phone.Text = "";
            tbAdmin_email.Text = "";
            MessageBox.Show("Пользователь удален");
            updateStat();
            update();
            UpdateListBoxHostelRoom();
            UpdateUserProfileRoom();
            UpdateAdmiListUserALL();
            UpdateContactAdminPanel();
            UpdateAdmiListUser();
            UpdateAdmiListHotelALL();
            UpdateAdmiListMsglALL();
            UpdateIncomingList();
            UpdateUserListMessage();
        }

        private void Main_Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}