using BarberShop.ContentFolder.ClassFolder;
using BarberShop.ViewingFolder.DataBaseFolder;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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
                ButtonStackPanel.Visibility = Visibility.Collapsed;
                FrameClass.AddEditRecordClass.Navigate(new NextThoTextPage());
            }
        }

        private void GetSearch() // Метод для поиска
        {
            var Sweep = AppConnectClass.DataBase.ResultTable.ToList(); // Получаем данные из "WorkerTable" в переиенную "Sweep"

            Sweep = Sweep.Where(Cookie => // метод для поиска по атрибутам
            Cookie.PersonalNumberResult.ToString().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "PersonalNumberResult" данные из элемента "SearchTextBox";
            Cookie.StatusRezult.ToLower().Contains(SearchTextBox.Text.ToLower())).ToList(); // Ищем в атрибуте "StatusRezult" данные из элемента "SearchTextBox" и выводим в ввиде листа;

            ListRecordListBox.ItemsSource = Sweep.OrderBy(Cookie => Cookie.PersonalNumberResult).ToList(); // в ListWorkwrListBox выводим переменную "Sweep" и сгруперованными данными из метода "Cookie" и ищем сотрудника по атрибуту "PersonalNumberWorker" и получаем список;
        }

        private void DeliteRecordButton_Click(object sender, RoutedEventArgs e)
        {
            ButtonStackPanel.Visibility = Visibility.Collapsed;
            ButtonStackPanel.Visibility = Visibility.Collapsed;
            FrameClass.AddEditRecordClass.Navigate(new NextThoTextPage());
        }

        private void ListRecordListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ResultTable resultTable = (ResultTable)ListRecordListBox.SelectedItem;
            FrameClass.AddEditRecordClass.Navigate(new InformationRecordPage(resultTable));
            ButtonStackPanel.Visibility = Visibility.Visible;
        }

    }
}
