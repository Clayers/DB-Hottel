using Npgsql;

using System;
using System.Collections.Generic;

namespace HotelDB
{
    public static class MessageController //Контроллер сообщений
    {
        /// <summary>
        /// Метод добавления нового сообщения в базу данных
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="AdressedUserId"></param>
        /// <param name="Topic"></param>
        /// <param name="TextMessage"></param>
        /// <returns></returns>
        public static bool PushMessageToAnotherUser(int UserId, int AdressedUserId, string Topic, string TextMessage)
        {
            try
            {
                var sql = "INSERT INTO messages(user_id, adressed_user_id, topic, message) VALUES(@user_id, @adressed_user_id, @topic, @message) RETURNING ID";
                var cmd = new NpgsqlCommand(sql, Program.Connection);
                cmd.Parameters.AddWithValue("user_id", UserId);
                cmd.Parameters.AddWithValue("adressed_user_id", AdressedUserId);
                cmd.Parameters.AddWithValue("topic", Topic);
                cmd.Parameters.AddWithValue("message", TextMessage);
                cmd.Prepare();
                var result = cmd.ExecuteScalar();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Получение заголовка по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetTopicFromId(int id)
        {
            var sql = $"SELECT * FROM messages WHERE id = '{id}'";
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

        /// <summary>
        /// Получение сообщения по ID
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public static string GetMessageFromId(int UserId)
        {
            var sql = $"SELECT * FROM message WHERE id = '{UserId}'";
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

        /// <summary>
        /// Получение ID отправителя по ID сообщения
        /// </summary>
        /// <param name="IdMessage"></param>
        /// <returns></returns>
        public static int GetIdUserFromIdMessage(int IdMessage)
        {
            var sql = $"SELECT * FROM messages WHERE id = '{IdMessage}'";
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

        /// <summary>
        /// Получить все сообщения
        /// </summary>
        /// <returns></returns>
        public static List<Message> GetAllMessage()
        {
            List<Message> ListId = new List<Message>();
            var sql = $"SELECT * FROM Messages";
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var msg = new Message();
                        msg.Adresser_ID = Int32.Parse(reader["user_id"].ToString());
                        msg.Adressee_ID = Int32.Parse(reader["adressed_user_id"].ToString());

                        msg.Topic = reader["topic"].ToString();
                        msg.Text = reader["message"].ToString();
                        ListId.Add(msg);
                    }
                }
                if (ListId.Count == 0) return null;

                return ListId;
            }
        }
    }
}