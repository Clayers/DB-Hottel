using Npgsql;

using System;
using System.Windows.Forms;

namespace HotelDB
{
    public static class UserController //Контроллер пользователя
    {
        static public User AuthorizationUser = new User(); //Сессия авторизованного пользователя

        /// <summary>
        /// Метод добавления пользователя в Базу Данных
        /// </summary>
        /// <param name="Login">Логин</param>
        /// <param name="Password">Пароль</param>
        /// <param name="First_Name">Имя</param>
        /// <param name="Email">Email</param>
        /// <param name="Middle_Name">Отчетство</param>
        /// <param name="Last_Name">Фамилия</param>
        /// <param name="Phonenumber">Телефон</param>
        /// <param name="AccessLevel">Уровень доступа</param>
        /// <returns></returns>
        public static User Add(string Login, string Password, string First_Name, string Email, string Middle_Name = "null", string Last_Name = "null", string Phonenumber = "null", int AccessLevel = 1)
        {
            try
            {
                Password = SecurityPasswordController.GetMd5Hash(Password);

                var sql = $"INSERT INTO Users(login, password, first_name, middle_name, last_name, email, phone_number, access_level) VALUES('{Login}', '{Password}', '{First_Name}', '{Middle_Name}', '{Last_Name}', '{Email}', '{Phonenumber}', {AccessLevel}) RETURNING ID";
                var user = new User();
                var cmds = new NpgsqlCommand();
                cmds.Connection = Program.Connection;
                cmds.CommandText = sql;

                user.ID = (int)cmds.ExecuteScalar();
                user.login = Login;
                user.password = Password;
                user.first_name = First_Name;
                user.middle_name = Middle_Name;
                user.last_name = Last_Name;
                user.email = Email;
                user.phone_number = Phonenumber;
                user.access_level = AccessLevel;

                return user;
            }
            catch (Exception ex) { MessageBox.Show("Ошибка добавления пользователя"); return null; }
        }

        /// <summary>
        /// Удаление пользователя
        /// </summary>
        /// <param name="id"></param>
        public static void Delate(int id)
        {
            try
            {
                var sql = $"DELETE FROM Users WHERE id = {id}";
                var command = new NpgsqlCommand(sql, Program.Connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка удаления пользователя"); }
        }

        /// <summary>
        /// Получить пользователя из Базы Данных по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static User GetUser(int id)
        {
            try
            {
                var sql = $"SELECT * FROM Users WHERE id = '{id}'";
                using (var command = new NpgsqlCommand(sql, Program.Connection))
                {
                    var user = new User();
                    user.ID = id;
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            user.login = reader["login"].ToString();
                            user.password = reader["password"].ToString();
                            user.first_name = reader["first_name"].ToString();
                            user.middle_name = reader["middle_name"].ToString();
                            user.last_name = reader["last_name"].ToString();
                            user.email = reader["email"].ToString();
                            user.phone_number = reader["phone_number"].ToString();
                            user.access_level = Int32.Parse(reader["access_level"].ToString());
                        }

                    if (user.login == null) return null;

                    return user;
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка получения данных пользователя"); return null; }
        }

        /// <summary>
        /// Получение информации о пользователе по логину
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public static User GetUser(string login)
        {
            try
            {
                var sql = $"SELECT * FROM Users WHERE login = '{login}'";
                using (var command = new NpgsqlCommand(sql, Program.Connection))
                {
                    var user = new User();
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            user.ID = Int32.Parse(reader["id"].ToString());
                            user.login = reader["login"].ToString();
                            user.password = reader["password"].ToString();
                            user.first_name = reader["first_name"].ToString();
                            user.middle_name = reader["middle_name"].ToString();
                            user.last_name = reader["last_name"].ToString();
                            user.email = reader["email"].ToString();
                            user.phone_number = reader["phone_number"].ToString();
                            user.access_level = Int32.Parse(reader["access_level"].ToString());
                        }

                    if (user.login == null) return null;

                    return user;
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка получения данных пользователя"); return null; }
        }

        /// <summary>
        /// Обновление данных пользователя
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        public static void Update(int id, User user)
        {
            try
            {
                var sql = $"UPDATE Users Set login='{user.login}',password='{user.password}',first_name='{user.first_name}',middle_name='{user.middle_name}',last_name='{user.last_name}',email='{user.email}',phone_number='{user.phone_number}',access_level='{user.access_level}'"
                    + $"WHERE id='{id}'";
                var cmd = new NpgsqlCommand(sql, Program.Connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка обновления данных пользователя"); }
        }

        /// <summary>
        /// Проверка авторизации пользователя
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool CheckAuth(string login, string pass)
        {
            try
            {
                pass = SecurityPasswordController.GetMd5Hash(pass);
                var sql = $"SELECT * FROM Users WHERE login = '{login}'";
                using (var command = new NpgsqlCommand(sql, Program.Connection))
                {
                    var user = new User();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.ID = Int32.Parse(reader["id"].ToString());
                            user.login = reader["login"].ToString();
                            user.password = reader["password"].ToString();
                        }
                    }

                    if (user.login == null) return false;
                    if (user.password == pass) { AuthorizationUser = GetUser(user.ID); return true; }
                    return false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка авторизации пользователя"); return false; }
        }

        /// <summary>
        /// Проверка дублирования логина
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public static bool CheckDuplicateLogin(string login)
        {
            try
            {
                var sql = $"SELECT * FROM Users WHERE login = '{login}'";
                var user = new User();
                using (var command = new NpgsqlCommand(sql, Program.Connection))
                {
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            user.login = reader["login"].ToString();
                        }
                }
                if (user.login == null) return false;
                return true;
            }
            catch (Exception ex) { MessageBox.Show("Ошибка в функии CheckDuplicateLogin"); return false; }
        }

        /// <summary>
        /// Проверка дублирования почты
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool CheckDuplicateEmail(string email)
        {
            try
            {
                var sql = $"SELECT * FROM Users WHERE email = '{email}'";
                var user = new User();
                using (var command = new NpgsqlCommand(sql, Program.Connection))
                {
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            user.login = reader["login"].ToString();
                        }
                }
                if (user.login == null) return false;
                return true;
            }
            catch { MessageBox.Show("Ошибка в функии CheckDuplicateLogin"); return false; }
        }
    }
}