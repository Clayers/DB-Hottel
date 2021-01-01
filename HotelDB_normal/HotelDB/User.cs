namespace HotelDB
{
    public class User //Описание класса пользователя
    {
        //Конструктор класса
        public User(string Login, string Password, string First_Name, string Email, string Middle_Name, string Last_Name, string Phonenumber, int AccessLevel = 1)
        {
            this.login = Login;
            this.password = Password;
            this.first_name = First_Name;
            this.middle_name = Middle_Name;
            this.last_name = Last_Name;
            this.email = Email;
            this.phone_number = Phonenumber;
            this.access_level = AccessLevel;
        }

        //Конструктор класса
        public User()
        {
            this.login = null;
            this.password = null;
            this.first_name = null;
            this.middle_name = null;
            this.last_name = null;
            this.email = null;
            this.phone_number = null;
            this.access_level = 1;
        }

        public int ID { get; set; } //ID пользователя
        public string login { get; set; } //Логин
        public string password { get; set; } //Пароль
        public string first_name { get; set; } //Имя
        public string middle_name { get; set; } //Отчество
        public string last_name { get; set; } //Фамилия
        public string email { get; set; } //Email
        public string phone_number { get; set; } //Номер телефона
        public int access_level { get; set; } //Уровень доступа (0 - администратор, 1 - пользователь)
    }
}