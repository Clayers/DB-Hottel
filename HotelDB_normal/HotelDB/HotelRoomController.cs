using Npgsql;

using System;

namespace HotelDB
{
    public static class HotelRoomController //Контроллер бронирования номеров
    {
        static public HotelRoom SelectRoom = new HotelRoom(); //Выбранная комната

        public static void AddHotelroom(string name_room, int id_user_book, string date_reservation, string date_end_reservation, int room_price) //Добавление номера отеля в базу данных
        {
            if (name_room == null) name_room = "null";
            if (date_reservation == null) date_reservation = "null";
            if (date_end_reservation == null) date_end_reservation = "null";
            var sql = $"INSERT INTO Hotelroom(name_room, id_user_book,date_reservation,date_end_reservation,room_price) VALUES('{name_room}',{id_user_book},'{date_reservation}','{date_end_reservation}',{room_price})";
            var cmds = new NpgsqlCommand(sql, Program.Connection);
            cmds.ExecuteNonQuery();
        }

        public static void AddHotelroom(string name_room, string id_user_book, string date_reservation, string date_end_reservation, int room_price) // Перегрузка метода, описанного выше
        {
            if (name_room == null) name_room = "null";
            if (id_user_book == null) id_user_book = "null";
            if (date_reservation == null) date_reservation = "null";
            if (date_end_reservation == null) date_end_reservation = "null";

            var sql = $"INSERT INTO Hotelroom(name_room, id_user_book,date_reservation,date_end_reservation,room_price) VALUES('{name_room}',{id_user_book},'{date_reservation}','{date_end_reservation}',{room_price})";
            var cmds = new NpgsqlCommand(sql, Program.Connection);
            cmds.ExecuteNonQuery();
        }

        public static HotelRoom GetHotelRoom(int id) //Получение информации о номере
        {
            var sql = $"SELECT * FROM Hotelroom WHERE id = '{id}'";
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                var hotel = new HotelRoom();
                hotel.ID = id;
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        if (!String.IsNullOrEmpty(reader["id_user_book"].ToString()))
                            hotel.id_user_book = Int32.Parse(reader["id_user_book"].ToString());

                        hotel.name_room = reader["name_room"].ToString();
                        hotel.room_price = Int32.Parse(reader["room_price"].ToString());

                        if (!String.IsNullOrEmpty(reader["date_reservation"].ToString()))
                            hotel.date_reservation = reader["date_reservation"].ToString();

                        if (!String.IsNullOrEmpty(reader["date_end_reservation"].ToString()))
                            hotel.date_end_reservation = reader["date_end_reservation"].ToString();
                    }
                return hotel;
            }
        }

        public static HotelRoom GetHotelRoomFromIDUser(int id) //Получение номера, забронированного пользователем
        {
            var sql = $"SELECT * FROM Hotelroom WHERE id_user_book = '{id}'";
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                var hotel = new HotelRoom();
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        if (!String.IsNullOrEmpty(reader["id_user_book"].ToString()))
                            hotel.id_user_book = Int32.Parse(reader["id_user_book"].ToString());

                        hotel.ID = Int32.Parse(reader["id"].ToString());
                        hotel.name_room = reader["name_room"].ToString();
                        hotel.room_price = Int32.Parse(reader["room_price"].ToString());

                        if (!String.IsNullOrEmpty(reader["date_reservation"].ToString()))
                            hotel.date_reservation = reader["date_reservation"].ToString();

                        if (!String.IsNullOrEmpty(reader["date_end_reservation"].ToString()))
                            hotel.date_end_reservation = reader["date_end_reservation"].ToString();
                    }
                return hotel;
            }
        }

        public static int Maxid() //Всего номеров в отеле

        {
            var sql = $"select count(*) FROM Hotelroom WHERE id = 1";
            var cmds = new NpgsqlCommand(sql, Program.Connection);
            if (cmds.ExecuteScalar().ToString() == "0")
            { return 0; }
            else
            {
                sql = $"SELECT MAX(id) FROM Hotelroom";
                cmds = new NpgsqlCommand(sql, Program.Connection);
                return Convert.ToInt32(cmds.ExecuteScalar());
            }
        }

        public static void Update(int id, HotelRoom room) //Обновление данных о номерах
        {
            var sql = $"UPDATE Hotelroom Set date_reservation='{room.date_reservation}',date_end_reservation='{room.date_end_reservation}',id_user_book='{UserController.AuthorizationUser.ID}' WHERE id='{id}'";
            var cmd = new NpgsqlCommand(sql, Program.Connection);
            cmd.ExecuteNonQuery();
        }

        public static bool PresenceOfTheUser() //Проверка наличия брони номера у пользователя
        {
            var sql = $"SELECT * FROM Hotelroom WHERE id_user_book = '{UserController.AuthorizationUser.ID}'";
            int id_user = 0;
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        id_user = Int32.Parse(reader["id_user_book"].ToString());
                    }
            }
            if (id_user > 0) return false;
            return true;
        }

        public static bool CheckBook(int select_room) //Проверка наличия забронированного номера конкпретным пользователем
        {
            var sql = $"SELECT * FROM Hotelroom WHERE id = '{select_room}'";
            string id = null;
            using (var command = new NpgsqlCommand(sql, Program.Connection))
            {
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        id = reader["id_user_book"].ToString();
                    }
            }
            if (id == null) return true;
            return false;
        }

        public static void EndBook(int User_id)
        {
            var sql = $"UPDATE Hotelroom Set date_reservation='{0}',date_end_reservation='{0}',id_user_book='{null}' WHERE id_user_book='{User_id}'";
            var cmd = new NpgsqlCommand(sql, Program.Connection);
            cmd.ExecuteNonQuery();
        }
    }
}