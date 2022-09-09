﻿using BarberShop.ContentFolder.ClassFolder;
using BarberShop.ViewingFolder.WindowsFolder;
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
            dispatcher.Interval = TimeSpan.FromSeconds(5); // Обновляю раз в 1 секунду
            dispatcher.Tick += Dispatcher_Tick; // Задаю количество раз обновлений
            dispatcher.Start(); // Запускаю DispatcherTimer

        }

        private void Dispatcher_Tick(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            //MainWindows mainWindows = new MainWindows();
            //mainWindows.Show();
            try
            {
                var AutorizationUser = DataBaseFolder.AppConnectClass.DataBase.WorkerTable.FirstOrDefault
                    (data => data.LoginWorker == LoginTextBox.Text && data.PasswordWorker == PasswordPasswordBox.Password ||
                             data.LoginWorker == LoginTextBox.Text && data.PasswordWorker == ViseblePasswordTextBox.Text);
                if (AutorizationUser == null)
                {
                    MessageBox.Show("Данного пользователя не существует в базе данных","Ошибка авторизации");
                }
                else
                {
                    switch (AutorizationUser.PostWorker)
                    {
                        case "Директор":
                            MessageBox.Show("Директор");
                            break;
                        case "Кассир":
                            MessageBox.Show("Кассир");
                            break;
                        case "Охранник":
                            MessageBox.Show("Охранник");
                            break;
                        case "Парикхмахер":
                            MessageBox.Show("Парикхмахер");
                            break;
                        case "Системный администратор":
                            MessageBox.Show("Системный администратор");
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
    }
}
