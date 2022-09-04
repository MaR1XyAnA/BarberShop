using BarberShop.ViewingFolder.DataBaseFolder;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace BarberShop.ViewingFolder.PageFolder
{
    public partial class WorkerPage : Page
    {
        DispatcherTimer dispatcher; // Подключаю к коду такой элемент как DispatcherTimer
        public WorkerPage()
        {
            InitializeComponent();
            AppConnectClass.DataBase = new BarberShopDataBaseEntities(); // Подключаем Базу Данных к этой странице.
            ListWorkwrListBox.ItemsSource = AppConnectClass.DataBase.WorkerTable.ToList(); // В ListWorkwrListBox, в ItemsSource выводим всю информацию из таблицы WorkerTable в виде списка.
            ListWorkwrListBox.Items.SortDescriptions.Add(new SortDescription("SurnameWorker", ListSortDirection.Ascending)); // Сортируем выведённую информацию в алфовитном порядке (Сортировка происходит по полю SurnameWorker).
        }

        private void ListWorkwrListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            WorkerTable workerTable = (WorkerTable)ListWorkwrListBox.SelectedItem;
            InformationFrame.Navigate(new InformationsWorkerPage(workerTable));
            BullshitextBlock.Visibility = Visibility.Collapsed;
        }

        private void Page_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                dispatcher = new DispatcherTimer(); // Подключаю DispatcherTimer
                dispatcher.Interval = TimeSpan.FromSeconds(1); // Обновляю раз в 1 секунду
                dispatcher.Tick += Dispatcher_Tick; // Задаю количество раз обновлений
                dispatcher.Start(); // Запускаю DispatcherTimer
                ListWorkwrListBox.ItemsSource = AppConnectClass.DataBase.WorkerTable.ToList(); // В ListWorkwrListBox, в ItemsSource выводим всю информацию из таблицы WorkerTable в виде списка.
            }
        }
        private void Dispatcher_Tick(object sender, EventArgs e)
        {
            ListWorkwrListBox.ItemsSource = AppConnectClass.DataBase.WorkerTable.ToList(); // Логика действий при обновлении DispatcherTimer (Обновление информации в ListWorkerListBox "Добавление нового элемента")
        }

        private void AddendumWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            InformationFrame.Navigate(new AddendumWorkerPage());
            BullshitextBlock.Visibility = Visibility.Collapsed;
        }
    }
}
