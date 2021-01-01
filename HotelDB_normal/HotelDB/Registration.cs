using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Text.RegularExpressions;
using System.Configuration;

namespace HotelDB
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void registration_button_Click(object sender, EventArgs e) //Метод регистрации пользователя
        {
            if (Login_textBox.Text.Length < 4)
            {
                MessageBox.Show("Количество символов в логине пользователя должно превышать 4");
                return;
            }
            if (Password_textBox.Text.Length < 4)
            {
                MessageBox.Show("Количество символов в пароле должно превышать 4");
                return;
            }
            if (Password_textBox.Text != Second_Password_textBox.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            if (Name_textBox.Text.Length < 2)
            {
                MessageBox.Show("Количество символов в пароле должно превышать 2");
                return;
            }
            if (isValid(Email_textBox.Text) == false)
            {
                MessageBox.Show("Почта введена некорректно.");
                return;
            }

            if (UserController.CheckDuplicateLogin(Login_textBox.Text) == true)
            {
                MessageBox.Show("Данный логин уже используется");
                return;
            }
            if (UserController.CheckDuplicateEmail(Email_textBox.Text) == true)
            {
                MessageBox.Show("Данная почта уже зарегестрирована");
                return;
            }
            UserController.AuthorizationUser = UserController.Add(Login_textBox.Text, Password_textBox.Text, Name_textBox.Text, Email_textBox.Text);
            Main_Window Mai_Window = new Main_Window();
            Mai_Window.Show();
            this.Hide();
        }

        public static bool isValid(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        private void authorization_button_Click(object sender, EventArgs e)
        {
            Authorization Aut_Window = new Authorization();
            Aut_Window.Show();
            this.Hide();
        }
    }
}