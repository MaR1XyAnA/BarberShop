using BarberShop.ContentFolder.ClassFolder;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BarberShop.ViewingFolder.PageFolder
{
    public partial class ListShopButtonPage : Page
    {
        public ListShopButtonPage()
        {
            InitializeComponent();
            FrameClass.AddEditServiseClass = InformationServisFrame;
            AppConnectClass.DataBase = new BarberShopDataBaseEntities(); // Подключаем Базу Данных к этой странице.
            ListShopButtonListBox.ItemsSource = AppConnectClass.DataBase.HaircutTable.ToList(); // В ListWorkwrListBox, в ItemsSource выводим всю информацию из таблицы WorkerTable в виде списка.
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}