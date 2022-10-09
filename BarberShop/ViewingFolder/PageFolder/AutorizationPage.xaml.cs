using BarberShop.ViewingFolder.WindowsFolder;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace BarberShop.ViewingFolder.PageFolder
{
    public partial class AutorizationPage : Page
    {
        string Password;

        public AutorizationPage()
        {
            InitializeComponent();
            DataBaseFolder.AppConnectClass.DataBase = new DataBaseFolder.BarberShopDataBaseEntities();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 50;
            doubleAnimation.To = 0;
            doubleAnimation.Duration = TimeSpan.FromSeconds(5);
            doubleAnimation.EasingFunction = new QuadraticEase();

            PasswordPasswordBox.IsEnabled = false;
            ViseblePasswordTextBox.IsEnabled = false;
            LoginTextBox.IsEnabled = false;
            NextButton.IsEnabled = false;

            if (LoginTextBox.Text == "" && PasswordPasswordBox.Password == "" ||
                LoginTextBox.Text == "" && ViseblePasswordTextBox.Text == "")
            {
                InfoErrorBorder.Visibility = Visibility.Visible;
                InfoErrorTextBlock.Visibility = Visibility.Visible;
                InfoErrorBorder.BeginAnimation(HeightProperty, doubleAnimation);
                InfoErrorTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                InfoErrorTextBlock.Text = "ПОЛЕ ЛОГИН ИЛИ ПАРОЛЬ ПУСТОЕ";

            }
            else
            {
                try
                {
                    var AutorizationUser = DataBaseFolder.AppConnectClass.DataBase.WorkerTable.FirstOrDefault
                        (data => data.LoginWorker == LoginTextBox.Text && data.PasswordWorker == PasswordPasswordBox.Password ||
                                 data.LoginWorker == LoginTextBox.Text && data.PasswordWorker == ViseblePasswordTextBox.Text);
                    if (AutorizationUser == null)
                    {
                        InfoErrorBorder.Visibility = Visibility.Visible;
                        InfoErrorTextBlock.Visibility = Visibility.Visible;
                        InfoErrorBorder.BeginAnimation(HeightProperty, doubleAnimation);
                        InfoErrorTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                        InfoErrorTextBlock.Text = "ЛОГИН ИЛИ ПАРОЛЬ ВВЕДЕНЫ НЕВЕРНО";

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
                                InfoErrorBorder.Visibility = Visibility.Visible;
                                InfoErrorTextBlock.Visibility = Visibility.Visible;
                                InfoErrorBorder.BeginAnimation(HeightProperty, doubleAnimation);
                                InfoErrorTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                                InfoErrorTextBlock.Text = "ВАМ ОТКАЗАННО В ДОСТУПЕ";

                                break;
                            case "Парикхмахер":
                                InfoErrorBorder.Visibility = Visibility.Visible;
                                InfoErrorTextBlock.Visibility = Visibility.Visible;
                                InfoErrorBorder.BeginAnimation(HeightProperty, doubleAnimation);
                                InfoErrorTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                                InfoErrorTextBlock.Text = "ВАМ ОТКАЗАННО В ДОСТУПЕ";

                                break;
                            case "Системный администратор":
                                mainWindows.Show();

                                break;
                            case "Уборщик":
                                InfoErrorBorder.Visibility = Visibility.Visible;
                                InfoErrorTextBlock.Visibility = Visibility.Visible;
                                InfoErrorBorder.BeginAnimation(HeightProperty, doubleAnimation);
                                InfoErrorTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                                InfoErrorTextBlock.Text = "ВАМ ОТКАЗАННО В ДОСТУПЕ";

                                break;

                            default:
                                InfoErrorBorder.Visibility = Visibility.Visible;
                                InfoErrorTextBlock.Visibility = Visibility.Visible;
                                InfoErrorBorder.BeginAnimation(HeightProperty, doubleAnimation);
                                InfoErrorTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                                InfoErrorTextBlock.Text = "УПС, У ВАС НЕТ РОЛИ";

                                break;
                        }
                    }

                }
                catch (Exception EX)
                {
                    InfoErrorBorder.Visibility = Visibility.Visible;
                    InfoErrorTextBlock.Visibility = Visibility.Visible;
                    InfoErrorBorder.BeginAnimation(HeightProperty, doubleAnimation);
                    InfoErrorTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                    InfoErrorTextBlock.Text = "ОШИБКА EX";

                }
            }

            PasswordPasswordBox.IsEnabled = true;
            ViseblePasswordTextBox.IsEnabled = true;
            LoginTextBox.IsEnabled = true;
            NextButton.IsEnabled = true;
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
