using BarberShop.ViewingFolder.WindowsFolder;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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

        private void GetEnter()
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 50;
            doubleAnimation.To = 0;
            doubleAnimation.Duration = TimeSpan.FromSeconds(5);
            doubleAnimation.EasingFunction = new QuadraticEase();

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
                            case 1:
                                mainWindows.Show();
                                break;

                            case 5:
                                mainWindows.Show();
                                break;

                            default:
                                InfoErrorBorder.Visibility = Visibility.Visible;
                                InfoErrorTextBlock.Visibility = Visibility.Visible;
                                InfoErrorBorder.BeginAnimation(HeightProperty, doubleAnimation);
                                InfoErrorTextBlock.BeginAnimation(HeightProperty, doubleAnimation);
                                InfoErrorTextBlock.Text = "ВАМ ОТКАЗАНО В ДОСТУПЕ";
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
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            GetEnter();
        }

        private void PasswordPasswordBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                GetEnter();
            }    
        }

        private void ViseblePasswordTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                GetEnter();
            }
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
                LoginTextTextBlock.Visibility = Visibility.Visible;
            }
            else
            {
                LoginTextTextBlock.Visibility = Visibility.Hidden;
            }
        }

        private void PasswordPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PasswordPasswordBox.Password.Length == 0)
            {
                PasswordTextTextBlock.Visibility = Visibility.Visible;
            }
            else
            {
                PasswordTextTextBlock.Visibility = Visibility.Hidden;
            }
        }

        private void ViseblePasswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ViseblePasswordTextBox.Text.Length == 0)
            {
                PasswordTextTextBlock.Visibility = Visibility.Visible;
            }
            else
            {
                PasswordTextTextBlock.Visibility = Visibility.Hidden;
            }
        }
    }
}
