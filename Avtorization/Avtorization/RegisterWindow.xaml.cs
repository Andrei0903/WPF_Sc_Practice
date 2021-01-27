using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Avtorization
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {

        AppContext db;
        public RegisterWindow()
        {
            InitializeComponent();

            db = new AppContext();

          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = EnterLogin.Text.Trim();
            string pass = EnterPassword.Password.Trim();
            string Password2 = EnterPassword2.Password.Trim();
            string email = EnterEmail.Text.Trim();
            string name = EnterName.Text.Trim();

            if (login == "")
            {
                MessageBox.Show("Имя не может быть пустым");
                EnterLogin.Background = Brushes.DarkRed;
            }
            else if (pass != Password2 || pass == "" || Password2 == "" || pass.Length < 6)
            {
                MessageBox.Show("Пароль не совпадает или введен некоректно");
                EnterPassword.Background = Brushes.DarkRed;
                EnterPassword2.Background = Brushes.DarkRed;
            }
            else if (email == "" || !email.Contains("@") || !email.Contains(".") || email.Length < 6)
            {
                MessageBox.Show("Некоректные данные Email");
                EnterEmail.Background = Brushes.DarkRed;

            }
            else
            {
                MessageBox.Show("Все хорошо");
                EnterLogin.Background = Brushes.Transparent;
                EnterPassword.Background = Brushes.Transparent;
                EnterPassword2.Background = Brushes.Transparent;
                EnterEmail.Background = Brushes.Transparent;

                User user = new User(login, pass, email);
                try { 
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow winm = new MainWindow();
            winm.Show();

        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
