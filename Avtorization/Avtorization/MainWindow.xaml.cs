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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Avtorization
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            RegisterWindow Win2 = new RegisterWindow();
            Win2.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string login = EnterLogin.Text.Trim();
            string Pass = EnterPass.Password.Trim();
           
            if (login == "")
            {
                MessageBox.Show("Имя не может быть пустым");
                EnterLogin.Background = Brushes.DarkRed;
            }
            else if (Pass.Length < 6)
            {
                MessageBox.Show("Пароль не совпадает или введен некоректно");
                EnterPass.Background = Brushes.DarkRed;
                
            }
            else
            {
                EnterLogin.Background = Brushes.Transparent;
                EnterPass.Background = Brushes.Transparent;

                User authUser = null;
                using (AppContext db = new AppContext())
                {
                    try
                    {
                        authUser = db.Users.Where(b => b.login == login && b.pass == Pass).FirstOrDefault();

                        if (authUser != null)
                        {
                            MessageBox.Show("Логин схож");
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }
        }
    }
}
