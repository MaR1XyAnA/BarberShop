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
    public partial class CustomersRecordList : Page
    {
        public CustomersRecordList()
        {
            InitializeComponent();
            AppConnectClass.DataBase = new BarberShopDataBaseEntities();
            FrameClass.AddEditRecordClass = InformationRecordFrame;
            FrameClass.AddEditRecordClass.Navigate(new NextThoTextPage());
            ListRecordListBox.ItemsSource = AppConnectClass.DataBase.ResultTable.ToList();
            OnlineRecordTextBlock.Text = AppConnectClass.DataBase.ResultTable.Count().ToString(); // Делаем подсчёт всего сотрудников;
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTextBox.Text.Length == 0) // Если длина содержимого = 0 то;
            {
                SearchTextTextBlock.Visibility = Visibility.Visible; // Видно подсказку;
                ListRecordListBox.ItemsSource = AppConnectClass.DataBase.ResultTable.ToList(); // Выводим в элемент "ListWorkwrListBox" данные из таблицы "WorkerTable";
            }
            else
            {
                SearchTextTextBlock.Visibility = Visibility.Hidden; // Прячем подсказку;
                GetSearch(); // Вызываем метод поиска "GetSearch";
            }
        }

        private void GetSearch() // Метод для поиска
        {
            //var Sweep = AppConnectClass.DataBase.ResultTable.ToList(); // Получаем данные из "WorkerTable" в переиенную "Sweep"

            //Sweep = Sweep.Where(Cookie => // метод для поиска по атрибутам
            //Cookie.LoginWorker.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "LoginWorker" данные из элемента "SearchTextBox" или
            //Cookie.PasswordWorker.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "PasswordWorker" данные из элемента "SearchTextBox" или
            //Cookie.CommentResult.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "NumberPhoneWorker" данные из элемента "SearchTextBox" или
            //Cookie.PassportSeries.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "PassportSeries" данные из элемента "SearchTextBox" или
            //Cookie.PassportNumber.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "PassportNumber" данные из элемента "SearchTextBox" или
            //Cookie.SurnameWorker.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "SurnameWorker" данные из элемента "SearchTextBox" или
            //Cookie.NameWorker.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "NameWorker" данные из элемента "SearchTextBox" или
            //Cookie.MiddlenameWorker.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "MiddlenameWorker" данные из элемента "SearchTextBox" или
            //Cookie.EmailWorker.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "EmailWorker" данные из элемента "SearchTextBox" или
            //Cookie.CardNumberWorker.ToLower().Contains(SearchTextBox.Text.ToLower())).ToList(); // Ищем в CardNumberWorker "LoginWorker" данные из элемента "SearchTextBox" и выводим листом;

            //ListRecordListBox.ItemsSource = Sweep.OrderBy(Cookie => Cookie.PersonalNumberResult).ToList(); // в ListWorkwrListBox выводим переменную "Sweep" и сгруперованными данными из метода "Cookie" и ищем сотрудника по атрибуту "PersonalNumberWorker" и получаем список;
        }

        private void EditInformationsRecordButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeliteRecordButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListRecordListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ResultTable resultTable = (ResultTable)ListRecordListBox.SelectedItem;
            FrameClass.AddEditRecordClass.Navigate(new InformationRecordPage(resultTable));
        }
    }
}
