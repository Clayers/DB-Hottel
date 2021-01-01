using System;
using System.Windows.Forms;

namespace HotelDB
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void authorization_input_Click(object sender, EventArgs e) //Авторизация пользователя
        {
            if (!UserController.CheckAuth(Login_textBox.Text, password_textBox.Text))
            {
                MessageBox.Show("Пользователя с таким сочетанием логина/пароля не найдено");
                return;
            }
            Main_Window Main_Window = new Main_Window();
            Main_Window.Show();
            this.Hide();
        }

        private void Open_registration_window_button_Click(object sender, EventArgs e)
        {
            Registration Reg_Window = new Registration();
            Reg_Window.Show();
            this.Hide();
        }
    }
}