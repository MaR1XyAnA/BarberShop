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
            ListWorkerBorder.Visibility = Visibility.Visible;
        }

        private void RollUp_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
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
            HideClass.InfoWindows = 0;
            AuthorizationWindows authorizationWindows = new AuthorizationWindows();
            authorizationWindows.Show();
            this.Close();
        }

        private void RollUpButton_Click(object sender, RoutedEventArgs e) // Для того, чтобы свернуть окно
        {
            WindowState = WindowState.Minimized;
        }
        #endregion

        private void ListWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new WorkerPage());
            ListWorkerButton.IsChecked = true;
            RecordClientButton.IsChecked = false;
            ServicesListButton.IsChecked = false;
            ListWorkerBorder.Visibility = Visibility.Visible;
            RecordClientBorder.Visibility = Visibility.Hidden;
            ServicesListBorder.Visibility = Visibility.Hidden;
        }

        private void RecordClientButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CustomersRecordList());
            ListWorkerButton.IsChecked = false;
            RecordClientButton.IsChecked = true;
            ServicesListButton.IsChecked = false;
            ListWorkerBorder.Visibility = Visibility.Hidden;
            RecordClientBorder.Visibility = Visibility.Visible;
            ServicesListBorder.Visibility = Visibility.Hidden;
        }

        private void ServicesListButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListShopButtonPage());
            ListWorkerButton.IsChecked = false;
            RecordClientButton.IsChecked = false;
            ServicesListButton.IsChecked = true;
            ListWorkerBorder.Visibility = Visibility.Hidden;
            RecordClientBorder.Visibility = Visibility.Hidden;
            ServicesListBorder.Visibility = Visibility.Visible;
        }
    }
}
