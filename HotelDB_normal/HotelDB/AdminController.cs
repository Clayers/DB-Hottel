using Npgsql;

using System;
using System.Collections.Generic;

namespace HotelDB
{
    public static class AdminController //Класс, отвечающий за вспомогательные функции для панели администратора
    {
        public static List<User> GetAllIdUser() //Метод получения всех пользователей
        {
            List<User> ListId = new List<User>();
            var sql = $"SELECT * FROM Users";
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var user = new User();
                        user.ID = Int32.Parse(reader["id"].ToString());
                        user.login = reader["login"].ToString();
                        user.password = reader["password"].ToString();
                        user.first_name = reader["first_name"].ToString();
                        user.middle_name = reader["middle_name"].ToString();
                        user.last_name = reader["last_name"].ToString();
                        user.email = reader["email"].ToString();
                        user.phone_number = reader["phone_number"].ToString();
                        user.access_level = Int32.Parse(reader["access_level"].ToString());
                        ListId.Add(user);
                    }
                }
                if (ListId.Count == 0) return null;

                return ListId;
            }
        }
    }
}