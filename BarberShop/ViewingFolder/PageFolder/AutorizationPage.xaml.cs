using BarberShop.ViewingFolder.WindowsFolder;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace BarberShop.ViewingFolder.PageFolder
{
    public partial class AutorizationPage : Page
    {
        string Password;
        private DispatcherTimer dispatcher;

        public AutorizationPage()
        {
            InitializeComponent();
            DataBaseFolder.AppConnectClass.DataBase = new DataBaseFolder.BarberShopDataBaseEntities();
            dispatcher = new DispatcherTimer(); // Подключаю DispatcherTimer
            dispatcher.Interval = TimeSpan.FromSeconds(1); // Обновляю раз в 1 секунду
            dispatcher.Tick += Dispatcher_Tick; // Задаю количество раз обновлений
            dispatcher.Stop();
        }

        private void Dispatcher_Tick(object sender, EventArgs e)
        {
            try
            {
                var AutorizationUser = DataBaseFolder.AppConnectClass.DataBase.WorkerTable.FirstOrDefault
                    (data => data.LoginWorker == LoginTextBox.Text && data.PasswordWorker == PasswordPasswordBox.Password ||
                             data.LoginWorker == LoginTextBox.Text && data.PasswordWorker == ViseblePasswordTextBox.Text);
                if (AutorizationUser == null)
                {
                    MessageBox.Show("Данного пользователя не существует в базе данных", "Ошибка авторизации");
                }
                else
                {
                    MainWindows mainWindows = new MainWindows();
                    switch (AutorizationUser.PostWorker)
                    {
                        case "Директор":
                            mainWindows.Show();
                            break;
                        case "Кассир":
                            mainWindows.Show();
                            break;
                        case "Охранник":
                            MessageBox.Show("Охранник");
                            break;
                        case "Парикхмахер":
                            MessageBox.Show("Парикхмахер");
                            break;
                        case "Системный администратор":
                            mainWindows.Show();
                            break;
                        case "Уборщик":
                            MessageBox.Show("Уборщик");
                            break;

                        default:
                            MessageBox.Show("Упс, кажится у вас нет роли");
                            break;
                    }
                }

            }
            catch (Exception EX)
            {
                MessageBox.Show("" + EX, "Error EX");
                dispatcher.Stop();
            }
            dispatcher.Stop();
            PasswordPasswordBox.IsEnabled = true;
            ViseblePasswordTextBox.IsEnabled = true;
            LoginTextBox.IsEnabled = true;
            NextButton.IsEnabled = true;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            dispatcher.Start();
            PasswordPasswordBox.IsEnabled = false;
            ViseblePasswordTextBox.IsEnabled = false;
            LoginTextBox.IsEnabled = false;
            NextButton.IsEnabled = false;
            //ProgressLoadingWindows progressLoadingWindows = new ProgressLoadingWindows();
            //progressLoadingWindows.ShowDialog();
        }

        private void VisebleTruePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            string PasswordInfo;
            PasswordInfo = Convert.ToString(PasswordPasswordBox.Password);
            ViseblePasswordTextBox.Text = PasswordInfo;
            Password = PasswordInfo;
            VisebleFalsePasswordButton.Visibility = Visibility.Visible;
            VisebleTruePasswordButton.Visibility = Visibility.Collapsed;
            ViseblePasswordTextBox.Visibility = Visibility.Visible;
            PasswordPasswordBox.Visibility = Visibility.Collapsed;
        }

        private void VisebleFalsePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            string PasswordInfo;
            PasswordInfo = Convert.ToString(ViseblePasswordTextBox.Text); 
            PasswordPasswordBox.Password = PasswordInfo;
            Password = PasswordInfo;
            VisebleFalsePasswordButton.Visibility = Visibility.Collapsed;
            VisebleTruePasswordButton.Visibility = Visibility.Visible;
            ViseblePasswordTextBox.Visibility = Visibility.Collapsed;
            PasswordPasswordBox.Visibility = Visibility.Visible;
        }

        private void LoginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LoginTextBox.Text.Length == 0)
            {
                LoginText.Visibility = Visibility.Visible;
            }
            else
            {
                LoginText.Visibility = Visibility.Hidden;
            }
        }

        private void PasswordPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PasswordPasswordBox.Password.Length == 0)
            {
                PasswordText.Visibility = Visibility.Visible;
            }
            else
            {
                PasswordText.Visibility = Visibility.Hidden;
            }
        }

        private void ViseblePasswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ViseblePasswordTextBox.Text.Length == 0)
            {
                PasswordText.Visibility = Visibility.Visible;
            }
            else
            {
                PasswordText.Visibility = Visibility.Hidden;
            }
        }
    }
}
