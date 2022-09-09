using BarberShop.ContentFolder.ClassFolder;
using BarberShop.ViewingFolder.PageFolder;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace BarberShop.ViewingFolder.WindowsFolder
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindows.xaml
    /// </summary>
    public partial class AuthorizationWindows : Window
    {
        private DispatcherTimer dispatcher;

        public AuthorizationWindows()
        {
            InitializeComponent();
            MainFrame.Navigate(new AutorizationPage());
            dispatcher = new DispatcherTimer(); // Подключаю DispatcherTimer
            dispatcher.Interval = TimeSpan.FromSeconds(5); // Обновляю раз в 1 секунду
            dispatcher.Tick += Dispatcher_Tick; // Задаю количество раз обновлений
            dispatcher.Start(); // Запускаю DispatcherTimer
        }

        private void Dispatcher_Tick(object sender, EventArgs e)
        {
            if (HideClass.InfoWindows == 1)
            {
                this.Close();
            }
        }

        private void RollUp_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void InfoTextAutorizationButton_Click(object sender, RoutedEventArgs e)
        {
            TranslateTransform inTheRightBorder = new TranslateTransform();
            InfoAutorizationBorder.RenderTransform = inTheRightBorder;
            DoubleAnimation doubleAnimationBorder = new DoubleAnimation(310, 0, TimeSpan.FromSeconds(0.2));
            InfoAutorizationBorder.Width = 200;
            inTheRightBorder.BeginAnimation(TranslateTransform.XProperty, doubleAnimationBorder);
            MainFrame.Navigate(new AutorizationPage());
        }

        private void InfoTextInformationButton_Click(object sender, RoutedEventArgs e)
        {
            TranslateTransform inTheLeftBorder = new TranslateTransform();
            InfoAutorizationBorder.RenderTransform = inTheLeftBorder;
            DoubleAnimation doubleAnimationBorder = new DoubleAnimation(0, 290, TimeSpan.FromSeconds(0.2));
            InfoAutorizationBorder.Width = 250;
            inTheLeftBorder.BeginAnimation(TranslateTransform.XProperty, doubleAnimationBorder);
            MainFrame.Navigate(new InformationsSessionPage());
        }
    }
}
