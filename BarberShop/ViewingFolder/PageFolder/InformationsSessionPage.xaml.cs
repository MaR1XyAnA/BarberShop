using BarberShop.ViewingFolder.WindowsFolder; // Подключаем библеотеку;
using System.Windows; // Подключаем библеотеку;
using System.Windows.Controls; // Подключаем библеотеку;

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
