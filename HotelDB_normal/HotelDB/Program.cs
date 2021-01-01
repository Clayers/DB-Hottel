using Npgsql;

using System;
using System.Windows.Forms;

namespace HotelDB
{
    internal static class Program
    {
        private const string PasswordDB = "admin";
        private const string NameDB = "HotelDB";
        private const string ConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=" + PasswordDB;
        private const string ConnettionStringDB = "Server=localhost;Port=5432;User Id=postgres;Password=" + PasswordDB + ";Database=" + NameDB;

        public static NpgsqlConnection Connection = new NpgsqlConnection(ConnettionStringDB); //Подключение к Базе Данных

        /// <summary>
        /// Главная точка входа для приложения
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {
                if (chkDBExists(ConnettionStringDB))
                {  //Проверка наличия Базы Данных
                    Program.Connection.Open(); //Открываем соединение
                }
                else //Создание Базы Данных и таблиц
                {
                    Connection = new NpgsqlConnection(ConnectionString);
                    Connection.Open();

                    var Createdb = new NpgsqlCommand($"CREATE DATABASE \"{NameDB}\" " +
                                       "WITH OWNER = \"postgres\" " +
                                       "ENCODING = 'UTF8' " +
                                       "CONNECTION LIMIT = -1;", Connection).ExecuteNonQuery();

                    Connection.Close();

                    Connection = new NpgsqlConnection(ConnettionStringDB);
                    Connection.Open();

                    //////Создание таблиц по умолчанию
                    var command = new NpgsqlCommand();
                    command.Connection = Connection;
                    //Таблица Users
                    command.CommandText = @"CREATE TABLE Users(id SERIAL PRIMARY KEY, login VARCHAR(50) NOT NULL, password VARCHAR(50) NOT NULL,first_name VARCHAR(50) NOT NULL, middle_name VARCHAR(50), last_name VARCHAR(50), email VARCHAR(50) NOT NULL, phone_number VARCHAR(50), access_level INT NOT NULL)";
                    command.ExecuteNonQuery();
                    //Таблица HotelRoom
                    command.CommandText = @"CREATE TABLE Hotelroom(id SERIAL PRIMARY KEY, name_room VARCHAR(50) NOT NULL, id_user_book int, date_reservation VARCHAR(50), date_end_reservation VARCHAR(50), room_price int NOT NULL)";
                    command.ExecuteNonQuery();
                    //Таблица Contact
                    command.CommandText = @"CREATE TABLE Contact ( id SERIAL PRIMARY KEY, user_id integer NOT NULL, topic VARCHAR(255) NOT NULL, message VARCHAR(255))";
                    command.ExecuteNonQuery();
                    //Таблица Messages
                    command.CommandText = @"CREATE TABLE Messages ( id SERIAL PRIMARY KEY, user_id integer NOT NULL, adressed_user_id integer NOT NULL, topic VARCHAR(255), message VARCHAR(255))";
                    command.ExecuteNonQuery();

                    ///////Тестовое заполнение Базы Данных
                    UserController.Add("admin", "admin", "Administrator", "admin@admin.ru", "Скрыто", "Скрыто", "+78889234532", 0); //Администратор
                    UserController.Add("user", "user", "Петя", "peta@mail.com", "Павлович", "Вовкин", "+78889234532 ", 1); //Пользователь
                    UserController.Add("user1", "user1", "Макс", "peta@mail.com", "Андреев", "Галкин", "+78889234532 ", 1); //Пользователь
                    UserController.Add("user2", "user2", "Вася", "vasa@mail.com", "Андреевич", "Бабак", "+78889234532 ", 1); //Пользователь
                    UserController.Add("user3", "user3", "Коля", "kol@mail.com", "Кучьмич", "Кубак", "+78889234532 ", 1); //Пользователь

                    //Заполнение комнат отеля
                    command.CommandText = "INSERT INTO Hotelroom(name_room, id_user_book,date_reservation,date_end_reservation,room_price) VALUES('Стандарт',null,null,null,2000)";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO Hotelroom(name_room, id_user_book,date_reservation,date_end_reservation,room_price) VALUES('Стандарт',null,null,null,2000)";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO Hotelroom(name_room, id_user_book,date_reservation,date_end_reservation,room_price) VALUES('Стандарт плюс',null,null,null,4000)";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO Hotelroom(name_room, id_user_book,date_reservation,date_end_reservation,room_price) VALUES('Стандарт плюс',null,null,null,4000)";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO Hotelroom(name_room, id_user_book,date_reservation,date_end_reservation,room_price) VALUES('Люкс',null,null,null,6000)";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO Hotelroom(name_room, id_user_book,date_reservation,date_end_reservation,room_price) VALUES('Люкс',null,null,null,6000)";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO Hotelroom(name_room, id_user_book,date_reservation,date_end_reservation,room_price) VALUES('Аппартаменты',null,null,null,10000)";
                    command.ExecuteNonQuery();

                    MessageController.PushMessageToAnotherUser(4, 1, "Hello", "Привет юзер!");
                    MessageController.PushMessageToAnotherUser(2, 3, "Вопрос", "Как вас день прошел?");
                    MessageController.PushMessageToAnotherUser(3, 1, "qq", "Привет админ!!!!!!");
                    MessageController.PushMessageToAnotherUser(2, 2, "Как дела?", "как дела, админ?");
                    MessageController.PushMessageToAnotherUser(2, 1, "Ошибка в по", "У меня баг!");

                    ContactController.PushMessage(2, "Оставили ключи в номере, а дверь захлопнулась.", "Я забыл их, что делать?");
                    ContactController.PushMessage(3, "Другое.", "Где обновление?");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось подключиться к PostgresDB. Проверте данные от сервера строку подключения к postgres"); return;
            }

            AdminController.GetAllIdUser();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
        }

        private static bool chkDBExists(string connectionStr) //Проверка наличия Базы Данных
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionStr))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex) { return false; }
        }
    }
}