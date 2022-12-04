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
            FrameClass.AddEditServiseClass.Navigate(new NextThreeTextPage());
            AppConnectClass.DataBase = new BarberShopDataBaseEntities(); // Подключаем Базу Данных к этой странице.
            ListShopButtonListBox.ItemsSource = AppConnectClass.DataBase.HaircutTable.ToList(); // В ListWorkwrListBox, в ItemsSource выводим всю информацию из таблицы WorkerTable в виде списка.
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTextBox.Text.Length == 0) // Если длина содержимого = 0 то;
            {
                SearchTextTextBlock.Visibility = Visibility.Visible; // Видно подсказку;
                ListShopButtonListBox.ItemsSource = AppConnectClass.DataBase.HaircutTable.ToList(); // Выводим в элемент "ListWorkwrListBox" данные из таблицы "WorkerTable";
            }
            else
            {
                ButtonStackPanel.Visibility = Visibility.Collapsed; // Выключаем видемость элементу "ButtonStackPanel", в котором находятся кнопки управления;
                FrameClass.AddEditServiseClass.Navigate(new NextThreeTextPage()); // Открываем страницу "NextTextPage";
                SearchTextTextBlock.Visibility = Visibility.Hidden; // Прячем подсказку;
                GetSearch(); // Вызываем метод поиска "GetSearch";
            }
        }

        private void ListShopButtonListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HaircutTable haircutTable = (HaircutTable)ListShopButtonListBox.SelectedItem;
            FrameClass.AddEditServiseClass.Navigate(new InformationServisePage(haircutTable));
            ButtonStackPanel.Visibility = Visibility.Visible;
        }

        private void EditInformationsServisButton_Click(object sender, RoutedEventArgs e)
        {
            HaircutTable haircutTable = (HaircutTable)ListShopButtonListBox.SelectedItem;
            FrameClass.AddEditServiseClass.Navigate(new AddendumServisePage(haircutTable));
            ButtonStackPanel.Visibility = Visibility.Collapsed;
        }

        private void DeliteServiseButton_Click(object sender, RoutedEventArgs e) // Событие кнопки на удаление услуги из БД
        {
            if (MessageBox.Show("Вы действительно хотите удалить данную услугу?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) // Выводим сообщение, и если пользователь нажал кнопку "Да" то;
            {
                var DaliteHaircut = ListShopButtonListBox.SelectedItem as HaircutTable; // В переменную "DaliteHaircut" получаем данные из таблицы "HaircutTable" по услуге выбронному в элементе "ListShopButtonListBox";
                AppConnectClass.DataBase.HaircutTable.Remove(DaliteHaircut); // Удаляем услугу из таблицы "HaircutTable";
                AppConnectClass.DataBase.SaveChanges(); // Сохраняем БД;
                ListShopButtonListBox.ItemsSource = AppConnectClass.DataBase.HaircutTable.ToList(); // Выводим в элемент "ListShopButtonListBox" данные из таблицы "HaircutTable";
                FrameClass.AddEditServiseClass.Navigate(new NextThreeTextPage());// Открываем страницу "NextThreeTextPage";
                ButtonStackPanel.Visibility = Visibility.Collapsed; // ВЫключаем видемость элементу "ButtonStackPanel", в котором находятся кнопки управления;
            }
        }

        private void AddendumServisButton_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.AddEditServiseClass.Navigate(new AddendumServisePage(null));
            ButtonStackPanel.Visibility = Visibility.Collapsed;
        }

        private void GetSearch() // Метод для поиска
        {
            var Sweep = AppConnectClass.DataBase.HaircutTable.ToList(); // Получаем данные из "HaircutTable" в переиенную "Sweep"

            Sweep = Sweep.Where(Cookie => // метод для поиска по атрибутам
            Cookie.NameHaircut.ToLower().Contains(SearchTextBox.Text.ToLower()) || // Ищем в атрибуте "NameHaircut" данные из элемента "SearchTextBox" или
            Cookie.PriceHaircut.ToString().Contains(SearchTextBox.Text.ToLower())).ToList(); // Ищем в CardNumberWorker "PriceHaircut" данные из элемента "SearchTextBox" и выводим листом;

            ListShopButtonListBox.ItemsSource = Sweep.OrderBy(Cookie => Cookie.PersonalNumberHaircut).ToList(); // в ListWorkwrListBox выводим переменную "Sweep" и сгруперованными данными из метода "Cookie" и ищем сотрудника по атрибуту "PersonalNumberWorker" и получаем список;
        }
    }
}