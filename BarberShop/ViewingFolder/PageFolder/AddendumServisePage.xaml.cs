using BarberShop.ContentFolder.ClassFolder;
using BarberShop.ViewingFolder.DataBaseFolder;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace BarberShop.ViewingFolder.PageFolder
{
    public partial class AddendumServisePage : Page
    {
        int IdNull = 0; // Объявляем переменную и говорим, что она равна 0;
        public AddendumServisePage(HaircutTable haircutTable) // Событие страницы "AddendumServisePage";
        {
            InitializeComponent(); // Инициализировать компонент;
            AppConnectClass.DataBase = new BarberShopDataBaseEntities(); // Подключаем Базу Данных к этой странице;
            if (haircutTable != null)
            {
                haircutTable = haircutTable;
                DataContext = haircutTable;
                IdNull = haircutTable.PersonalNumberHaircut;
            }
        }

        private void NewPhotoButton_Click(object sender, RoutedEventArgs e) // Событие элемента "NewPhotoButton";
        {

        }

        private void AddEditHaircutButton_Click(object sender, RoutedEventArgs e) // Событие элемента "AddEditHaircutButton";
        {
            if (NameTextBox.Text == "" || PriceTextBox.Text == "" || TimeTextBox.Text == "") // Проверяем пустоту в TextBox;
            {
                MessageBox.Show("Поля не должны быть пустыми", "ОШИБКА ДОБАВЛЕНИЯ"); // Сообщение
            }
            else
            {
                //DateTime time = Convert.ToDateTime(TimeTextBox.Text); // конвертируем время в тип данных DateTime;
                decimal price = Convert.ToDecimal(PriceTextBox.Text); // конвертируем цену в тип данных decimal;
                var haircut = new HaircutTable() // Записываем в таблицу "HaircutTable" данные;
                {
                    PersonalNumberHaircut = IdNull,
                    NameHaircut = NameTextBox.Text, // В арибут "NameHaircut" добавляем данные из "NameTextBox";
                    DescriptionHaircut = DescriptionTextBox.Text, // В арибут "DescriptionHaircut" добавляем данные из "DescriptionTextBox";
                    PriceHaircut = price // В арибут "PriceHaircut" добавляем данные из конвертированного значения "PriceTextBox";
                };
                HaircutTable HaircutSearth = AppConnectClass.DataBase.HaircutTable.Find(IdNull); // Ищем стрижку по ID;
                try
                {
                    if (HaircutSearth != null) // Если "HaircutSearth" не пустое;
                    {
                        AppConnectClass.DataBase.HaircutTable.AddOrUpdate(haircut); // То изменяем данные;
                        AppConnectClass.DataBase.SaveChanges(); // Сохраняем изменения в БД;
                        MessageBox.Show("Стрижка успешно изменина", "РЕДАКТИРОВАНИЕ"); // Сообщение;
                        FrameClass.AddEditServiseClass.Navigate(new NextThreeTextPage()); // Включаем страницу "NextThreeTextPage";
                    }
                    else // Иначе
                    {
                        if (AppConnectClass.DataBase.HaircutTable.Count(data => data.NameHaircut == NameTextBox.Text) > 0) // Сколько причёсок с таким имяним, если больше 0;
                        {
                            MessageBox.Show("Данная стрижка уже существует", "ОШИБКА ДОБАВЛЕНИЯ"); // Сообщение
                        }
                        else // Иначе
                        {
                            AppConnectClass.DataBase.HaircutTable.Add(haircut); // добавляем в БД новую причёску;
                            AppConnectClass.DataBase.SaveChanges(); // Сохраняем изменения в БД;
                            MessageBox.Show("Новая стрижка успешно добавленна", "ДОБАВЛЕНИЕ"); // Сообщение;
                            FrameClass.AddEditServiseClass.Navigate(new NextThreeTextPage()); // Включаем страницу "NextThreeTextPage";
                        }
                    }
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message.ToString(), "Ошибка сохранения"); // Сообщение
                }
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, TextChangedEventArgs e) // Событие элемента "DescriptionTextBox";
        {
            int CountInt = DescriptionTextBox.Text.Length; // В переменную INT получаем количество символов из "DescriptionTextBox";
            CountTextBlock.Text = Convert.ToString(CountInt); // В "CountTextBlock" выводим количество символов;
        }
    }
}
