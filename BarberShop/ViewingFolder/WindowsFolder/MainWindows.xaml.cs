using BarberShop.ContentFolder.ClassFolder;
using BarberShop.ViewingFolder.PageFolder;
using System.Windows;
using System.Windows.Input;

namespace BarberShop.ViewingFolder.WindowsFolder
{
    public partial class MainWindows : Window
    {
        public MainWindows() 
        {
            InitializeComponent();
            MainFrame.Navigate(new WorkerPage());
            HideClass.InfoWindows = 1;
            ListWorkerButton.IsChecked = true;
        }

        private void RollUp_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            HideClass.InfoWindows = 0;
            AuthorizationWindows authorizationWindows = new AuthorizationWindows();
            authorizationWindows.Show();
            this.Hide();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ListWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new WorkerPage());
            ListWorkerButton.IsChecked = true;
            RecordClientButton.IsChecked = false;
            ServicesListButton.IsChecked = false;
            QueueListButton.IsChecked = false;
        }

        private void RecordClientButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CustomersRecordList());
            ListWorkerButton.IsChecked = false;
            RecordClientButton.IsChecked = true;
            ServicesListButton.IsChecked = false;
            QueueListButton.IsChecked = false;
        }

        private void ServicesListButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListShopButtonPage());
            ListWorkerButton.IsChecked = false;
            RecordClientButton.IsChecked = false;
            ServicesListButton.IsChecked = true;
            QueueListButton.IsChecked = false;
        }

        private void QueueListButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SessionsPage());
            ListWorkerButton.IsChecked = false;
            RecordClientButton.IsChecked = false;
            ServicesListButton.IsChecked = false;
            QueueListButton.IsChecked = true;
        }
    }
}
