namespace HotelDB
{
    public class Message //Класс "Сообщения"
    {
        public override string ToString() //Переопределение для ListBox
        {
            return Name;
        }

        public int IdMessage { get; set; } //ID Message
        public string Topic { get; set; } //Тема сообщения

        public string Text { get; set; } //Сообщение

        public int Adresser_ID { get; set; } //iD отправителя

        public int Adressee_ID { get; set; } //ID получателя

        public string Name { get; set; } //Имя отправителя
    }
}