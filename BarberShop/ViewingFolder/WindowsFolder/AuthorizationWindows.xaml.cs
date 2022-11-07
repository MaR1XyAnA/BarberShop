using BarberShop.ContentFolder.ClassFolder;
using BarberShop.ViewingFolder.PageFolder;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace BarberShop.ViewingFolder.WindowsFolder
{
    public partial class AuthorizationWindows : Window
    {
        private DispatcherTimer dispatcher;

        public AuthorizationWindows()
        {
            InitializeComponent();
            MainFrame.Navigate(new AutorizationPage());
            dispatcher = new DispatcherTimer(); // Подключаю DispatcherTimer
            dispatcher.Interval = TimeSpan.FromSeconds(0.5); // Обновляю раз в 1 секунду
            dispatcher.Tick += Dispatcher_Tick; // Задаю количество раз обновлений
            dispatcher.Start(); // Запускаю DispatcherTimer
            InfoTextAutorizationButton.IsChecked = true;
        }

        private void Dispatcher_Tick(object sender, EventArgs e)
        {
            if (HideClass.InfoWindows == 1)
            {
                this.Close();
            }
        }

        #region Управление окном
        private void SpaseBarGrid_MouseDown(object sender, MouseButtonEventArgs e) // Для того, что бы окно перетаскивать
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) // Для того, что бы закрыть окно
        {
            this.Close();
            HideClass.InfoWindows = 0;
            AuthorizationWindows authorizationWindows = new AuthorizationWindows();
            authorizationWindows.Show();
        }

        private void RollUpButton_Click(object sender, RoutedEventArgs e) // Для того, чтобы свернуть окно
        {
            WindowState = WindowState.Minimized;
        }
        #endregion

        private void InfoTextAutorizationButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AutorizationPage());
            InfoTextInformationButton.IsChecked = false;
            InfoTextEmailButton.IsChecked = false;
        }

        private void InfoTextInformationButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new InformationsSessionPage());
            InfoTextAutorizationButton.IsChecked = false;
            InfoTextEmailButton.IsChecked = false;
        }

        private void InfoTextEmailButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EmailPage());
            InfoTextAutorizationButton.IsChecked = false;
            InfoTextInformationButton.IsChecked = false;
        }
    }
}
