using BarberShop.ViewingFolder.DataBaseFolder; // Подключаем библеотеку;
using System.Linq; // Подключаем библеотеку;
using System.Windows; // Подключаем библеотеку;
using System.Windows.Controls; // Подключаем библеотеку;

namespace BarberShop.ViewingFolder.WindowsFolder
{
    public partial class QueueWindows : Window
    {
        public QueueWindows()
        {
            InitializeComponent();
            AppConnectClass.DataBase = new BarberShopDataBaseEntities(); // Подключаем Базу Данных к этой странице.
            ListQueueListBox.ItemsSource = AppConnectClass.DataBase.DoNotCutTheFilter.ToList(); // В ListWorkwrListBox, в ItemsSource выводим всю информацию из таблицы WorkerTable в виде списка.
            ListTheQueueListBox.ItemsSource = AppConnectClass.DataBase.CutTheFilter.ToList(); // В ListWorkwrListBox, в ItemsSource выводим всю информацию из таблицы WorkerTable в виде списка.
        }

        private void ListQueueListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
