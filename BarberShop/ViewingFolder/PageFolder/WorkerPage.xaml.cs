using BarberShop.ContentFolder.ClassFolder; // Подключаем библеотеку;
using BarberShop.ViewingFolder.DataBaseFolder; // Подключаем библеотеку;
using System.ComponentModel; // Подключаем библеотеку;
using System.Linq; // Подключаем библеотеку;
using System.Windows; // Подключаем библеотеку;
using System.Windows.Controls; // Подключаем библеотеку;

namespace BarberShop.ViewingFolder.PageFolder
{
    public partial class WorkerPage : Page
    {
        public WorkerPage() // Событие страницы "WorkerPage";
        {
            InitializeComponent(); // Инициализировать компонент;
            FrameClass.AddEditWorkerClass = InformationFrame; // Запехнули в свойство "AddEditWorkerClass" из класса "FrameClass" элемент "InformationFrame";
            FrameClass.AddEditWorkerClass.Navigate(new NextTextPage()); // Открываем страницу "NextTextPage";
            AppConnectClass.DataBase = new BarberShopDataBaseEntities(); // Подключаем Базу Данных к этой странице;
            ListWorkwrListBox.ItemsSource = AppConnectClass.DataBase.WorkerTable.ToList(); // В элемент "ListWorkwrListBox", выводим всю информацию из таблицы "WorkerTable" в виде списка;
            ListWorkwrListBox.Items.SortDescriptions.Add(new SortDescription("SurnameWorker", ListSortDirection.Ascending)); // Сортируем выведённую информацию в элементе "ListWorkwrListBox" в алфовитном порядке (Сортировка происходит по атрибуту "SurnameWorker");
        }

        private void ListWorkwrListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            WorkerTable workerTable = (WorkerTable)ListWorkwrListBox.SelectedItem; // Обыявляем переменную "workerTable" и даём ей данные из таблицы "WorkerTable", которые выбрали в элементе "ListWorkwrListBox";
            FrameClass.AddEditWorkerClass.Navigate(new InformationsWorkerPage(workerTable));// Переключаем в элементе "InformationFrame" страницу с имянем "InformationsWorkerPage" и передаём данные из переменной "workerTable";
            ButtonStackPanel.Visibility = Visibility.Visible; // Включаем видемость элементу "ButtonStackPanel", в котором находятся кнопки управления;
        }

        private void AddendumWorkerButton_Click(object sender, RoutedEventArgs e) // Событие элемента "AddendumWorkerButton"
        {
            WorkerTable workerTable = (WorkerTable)ListWorkwrListBox.SelectedItem; // Обыявляем переменную "workerTable" и даём ей данные из таблицы "WorkerTable", которые выбрали в элементе "ListWorkwrListBox";
            FrameClass.AddEditWorkerClass.Navigate(new AddendumWorkerPage(null)); // Переключаем в элементе "InformationFrame" страницу с имянем "InformationsWorkerPage" и передаём данные из переменной "workerTable";
            ButtonStackPanel.Visibility = Visibility.Collapsed; // Выключаем видемость элементу "ButtonStackPanel", в котором находятся кнопки управления;
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) // Событие элемента "SearchTextBox";
        {
            if (SearchTextBox.Text.Length == 0) // Если длина содержимого = 0 то;
            {
                SearchTextTextBlock.Visibility = Visibility.Visible; // Видно подсказку;
                ListWorkwrListBox.ItemsSource = AppConnectClass.DataBase.WorkerTable.ToList(); // Выводим в элемент "ListWorkwrListBox" данные из таблицы "WorkerTable";
            }
            else
            {
                ButtonStackPanel.Visibility = Visibility.Collapsed; // Выключаем видемость элементу "ButtonStackPanel", в котором находятся кнопки управления;
                FrameClass.AddEditWorkerClass.Navigate(new NextTextPage()); // Открываем страницу "NextTextPage";
                SearchTextTextBlock.Visibility = Visibility.Hidden; // Прячем подсказку;
                GetSearch(); // Вызываем метод поиска "GetSearch";
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e) // Событие страницы;
        {
            if(Visibility == Visibility.Visible) // Если страница в статусе "Видно";
            {
                OnlineWorkerTextBlock.Text = AppConnectClass.DataBase.WorkerTable.Count().ToString(); // Делаем подсчёт всего сотрудников;
            } 
        }

        private void EditInformationsWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            WorkerTable workerTable = (WorkerTable)ListWorkwrListBox.SelectedItem; // Обыявляем переменную "workerTable" и даём ей данные из таблицы "WorkerTable", которые выбрали в элементе "ListWorkwrListBox";
            FrameClass.AddEditWorkerClass.Navigate(new AddendumWorkerPage(workerTable)); // Переключаем в элементе "InformationFrame" страницу с имянем "AddendumWorkerPage" и передаём данные из переменной "workerTable";
            ButtonStackPanel.Visibility = Visibility.Collapsed; // Выключаем видемость элементу "ButtonStackPanel", в котором находятся кнопки управления;
        }

        private void DeliteWorkerButton_Click(object sender, RoutedEventArgs e) // Событие кнопки "DeliteWorkerButton";
        {
            if (MessageBox.Show("Вы действительно хотите удалить данного сотрудника?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) // Выводим сообщение, и если пользователь нажал кнопку "Да" то;
            {
                var DaliteWorker = ListWorkwrListBox.SelectedItem as WorkerTable; // В переменную "DaliteWorker" получаем данные из таблицы "WorkerTable" по сотруднику выбронному в элементе "ListWorkwrListBox";
                var DalitePassport = DaliteWorker.PassportWorkerTable; // В переменную "DalitePassport" получаем данные из переменной "DaliteWorker" из таблицы "PassportWorkerTable";
                var DaliteSalaryCard = DaliteWorker.SalaryCardTable; // В переменную "DaliteSalaryCard" получаем данные из переменной "DaliteWorker" из таблицы "SalaryCardTable";

                AppConnectClass.DataBase.WorkerTable.Remove(DaliteWorker); // Удаляем сотрудника из таблицы "DaliteWorker";
                AppConnectClass.DataBase.PassportWorkerTable.Remove(DalitePassport); // Удаляем сотрудника из таблицы "DaliteWorker";
                AppConnectClass.DataBase.SalaryCardTable.Remove(DaliteSalaryCard); // Удаляем сотрудника из таблицы "DaliteWorker";
                AppConnectClass.DataBase.SaveChanges(); // Сохраняем БД;
                ListWorkwrListBox.ItemsSource = AppConnectClass.DataBase.WorkerTable.ToList(); // Выводим в элемент "ListWorkwrListBox" данные из таблицы "WorkerTable";
                FrameClass.AddEditWorkerClass.Navigate(new NextTextPage()); // Открываем страницу "NextTextPage";
                ButtonStackPanel.Visibility = Visibility.Collapsed; // ВЫключаем видемость элементу "ButtonStackPanel", в котором находятся кнопки управления;
            }
        }
        private void GetSearch() // Метод для поиска
        {
            var Sweep = AppConnectClass.DataBase.WorkerTable.ToList(); // Получаем данные из "WorkerTable" в переиенную "Sweep"

            Sweep = Sweep.Where(Cookie => // метод для поиска по атрибутам
            Cookie.LoginWorker.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "LoginWorker" данные из элемента "SearchTextBox" или
            Cookie.PasswordWorker.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "PasswordWorker" данные из элемента "SearchTextBox" или
            Cookie.NumberPhoneWorker.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "NumberPhoneWorker" данные из элемента "SearchTextBox" или
            Cookie.PassportSeries.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "PassportSeries" данные из элемента "SearchTextBox" или
            Cookie.PassportNumber.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "PassportNumber" данные из элемента "SearchTextBox" или
            Cookie.SurnameWorker.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "SurnameWorker" данные из элемента "SearchTextBox" или
            Cookie.NameWorker.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "NameWorker" данные из элемента "SearchTextBox" или
            Cookie.MiddlenameWorker.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "MiddlenameWorker" данные из элемента "SearchTextBox" или
            Cookie.EmailWorker.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "EmailWorker" данные из элемента "SearchTextBox" или
            Cookie.CardNumberWorker.ToLower().Contains(SearchTextBox.Text.ToLower())).ToList(); // Ищем в CardNumberWorker "LoginWorker" данные из элемента "SearchTextBox" и выводим листом;

            ListWorkwrListBox.ItemsSource = Sweep.OrderBy(Cookie => Cookie.PersonalNumberWorker).ToList(); // в ListWorkwrListBox выводим переменную "Sweep" и сгруперованными данными из метода "Cookie" и ищем сотрудника по атрибуту "PersonalNumberWorker" и получаем список;
        }
    }
}
