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

        }

        private void ListShopButtonListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HaircutTable haircutTable = (HaircutTable)ListShopButtonListBox.SelectedItem;
            FrameClass.AddEditServiseClass.Navigate(new InformationServisePage(haircutTable));
            ButtonStackPanel.Visibility = Visibility.Visible;
        }

        private void EditInformationsServisButton_Click(object sender, RoutedEventArgs e)
        {
            //HaircutTable haircutTable = (HaircutTable)ListShopButtonListBox.SelectedItem;
            //FrameClass.AddEditServiseClass.Navigate(new InformationServisePage(haircutTable));
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
    }
}