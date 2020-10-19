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

namespace MaterialDesignPractic
{
    /// <summary>
    /// Логика взаимодействия для menu.xaml
    /// </summary>
    public partial class menu : Page
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Login1_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new login1());
        }

        private void Login1_Click2(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new login2());
        }
    }
}
