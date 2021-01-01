namespace HotelDB
{
    public class HotelRoom //Класс "Отель"
    {
        public int ID { get; set; } //ID
        public string name_room { get; set; } //Номер
        public int id_user_book { get; set; } //ID Пользователя
        public string date_reservation { get; set; } //Дата начала брони
        public string date_end_reservation { get; set; } //Дата окончания брони
        public int room_price { get; set; } //Стоимость бронирования
    }
}