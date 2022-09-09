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

        private void ListWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new WorkerPage());
        }

        private void RecordClientButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CustomersRecordList());
        }

        private void ServicesListButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListShopButtonPage());
        }

        private void QueueListButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
