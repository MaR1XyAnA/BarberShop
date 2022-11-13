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
    public partial class CustomersRecordList : Page
    {
        public CustomersRecordList()
        {
            InitializeComponent();
            AppConnectClass.DataBase = new BarberShopDataBaseEntities();
            ListRecordListBox.ItemsSource = AppConnectClass.DataBase.ResultTable.ToList();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void EditInformationsRecordButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeliteRecordButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
