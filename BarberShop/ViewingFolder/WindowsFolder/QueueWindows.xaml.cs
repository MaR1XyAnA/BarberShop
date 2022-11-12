using BarberShop.ViewingFolder.DataBaseFolder;
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
using System.Windows.Shapes;

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
