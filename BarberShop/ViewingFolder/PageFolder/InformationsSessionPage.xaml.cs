using BarberShop.ViewingFolder.WindowsFolder;
using System.Windows;
using System.Windows.Controls;

namespace BarberShop.ViewingFolder.PageFolder
{
    public partial class InformationsSessionPage : Page
    {
        public InformationsSessionPage()
        {
            InitializeComponent();
        }

        private void SessionsInfoButton_Click(object sender, RoutedEventArgs e)
        {
            QueueWindows queueWindows = new QueueWindows();
            queueWindows.Show();
        }
    }
}
