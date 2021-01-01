using Npgsql;

using System;
using System.Collections.Generic;

namespace HotelDB
{
    public static class ContactController //Контроллер "Связь с нами"
    {
        public static bool PushMessage(int UserId, string Topic, string TextMessage) //Метод оправки сообщения в базу данных(соединение с администратором)
        {
            try
            {
                var sql = "INSERT INTO contact(user_id, topic, message) VALUES(@user_id, @topic, @message) RETURNING ID";
                var cmd = new NpgsqlCommand(sql, Program.Connection);
                cmd.Parameters.AddWithValue("user_id", UserId);
                cmd.Parameters.AddWithValue("topic", Topic);
                cmd.Parameters.AddWithValue("message", TextMessage);
                cmd.Prepare();
                var result = cmd.ExecuteScalar();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string GetMessageFromId(int id) //Получение сообщения по ID пользователя(панель администратора)
        {
            var sql = $"SELECT * FROM Contact WHERE id = {id}";
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                string message = "";
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        message = reader["message"].ToString();
                    }

                if (message == null) return null;

                return message;
            }
        }

        public static List<int> GetAllIdPushed() //Получение всех сообщений из базы данных(панель администратора)
        {
            var sql = $"SELECT id FROM Contact";
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                List<int> ListId = new List<int>();
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        ListId.Add(Int32.Parse(reader["id"].ToString()));
                    }

                if (ListId.Count == 0) return null;

                return ListId;
            }
        }

        public static string GetTopicFromId(int UserId) //Получение темы сообщения по ID пользователя(панель администратора)
        {
            var sql = $"SELECT * FROM Contact WHERE id = '{UserId}'";
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                string topic = "";
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        topic = reader["topic"].ToString();
                    }

                if (topic == null) return null;

                return topic;
            }
        }

        public static int GetIdUserFromIdMessage(int IdMessage) //Получение ID пользователя по идентификационному номеру сообщения(панель администратора)
        {
            var sql = $"SELECT * FROM Contact WHERE id = '{IdMessage}'";
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                int IdUser = -1;
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        IdUser = Int32.Parse(reader["user_id"].ToString());
                    }

                return IdUser;
            }
        }
    }
}