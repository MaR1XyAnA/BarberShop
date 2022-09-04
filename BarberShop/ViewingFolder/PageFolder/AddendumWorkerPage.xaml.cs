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

namespace BarberShop.ViewingFolder.PageFolder
{
    /// <summary>
    /// Логика взаимодействия для AddendumWorkerPage.xaml
    /// </summary>
    public partial class AddendumWorkerPage : Page
    {
        public AddendumWorkerPage()
        {
            InitializeComponent();
        }

        private void PasswordPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PasswordTextBox.Text != PasswordPasswordBox.Password || PasswordPasswordBox.Password != PasswordPasswordBox.Password)
            {
                ErrorPasswordTextBlock.Text = "пароли не совподают";
                ErrorPasswordTextBlock.Visibility = Visibility.Visible;
                NewWorkerButton.IsEnabled = false;
            }

            else
            {
                ErrorPasswordTextBlock.Visibility = Visibility.Collapsed;
            }
        }

        private void NewWorkerButton_Click(object sender, RoutedEventArgs e)
        {

        }    
    }
}
