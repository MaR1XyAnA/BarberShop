using BarberShop.ViewingFolder.DataBaseFolder;
using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace BarberShop.ViewingFolder.PageFolder
{
    public partial class AddendumWorkerPage : Page
    {
        string NamePhoto;
        public AddendumWorkerPage()
        {
            InitializeComponent();
            PaulComboBox.ItemsSource = AppConnectClass.DataBase.PaulTable.ToList();
            PostComboBox.ItemsSource = AppConnectClass.DataBase.PostTable.ToList();
            if (PhotoProfileImage.Source != null)
            {
                UploadingPhotosButton.Content = "ИЗМЕНИТЬ ФОТО";
            }
        }

        private void UploadingPhotosButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            NamePhoto = openFileDialog.FileName;
            ImageSource imageSource = new BitmapImage(new Uri(NamePhoto));
            PhotoProfileImage.Source = imageSource;
        }

        private void NewWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime DatePassportIssuedDateTime, DateOfBirthDateTime;
            DatePassportIssuedDateTime = Convert.ToDateTime(DatePassportIssuedTextBox.Text);
            DateOfBirthDateTime = Convert.ToDateTime(DateOfBirthTExtBox.Text);
            if (AppConnectClass.DataBase.WorkerTable.Count(data => data.LoginWorker == LogintextBox.Text && data.PasswordWorker == PasswordTextBox.Text)>0)
            {
                MessageBox.Show("Данный пользователь уже есть");
                return;
            }
            else
            {
                try
                {

                    PassportWorkerTable passportWorkerTable = new PassportWorkerTable()
                    {
                        PassportSeriesWorker = PassportSeriesTextBox.Text,
                        PassportNumberWorker = PassportNumberTextBox.Text,
                        PassportIssuedWorker = PassportIssuedTextBox.Text,
                        DateOfIssueWorker = DatePassportIssuedDateTime,
                        DivisionCodeWorker = DivisionСodeTextBox.Text,
                        PaulTable = PaulComboBox.SelectedItem as PaulTable,
                        PlaceOfBirthWorker = PassportPlaceOfBirthTextBox.Text,
                        RegistrationRegionWorker = PassportRegionTextBox.Text,
                        RegistrationPointWorker = PassportPointTextBox.Text,
                        RegistrationStreetWorker = PassportStreetTextBox.Text,
                        RegistrationHouseWorker = PassportHouseTextBox.Text,
                        RegistrationApartmentWorker = RegistrationApartmentWorkerTextBox.Text,
                        DateOfBirthWorker = DateOfBirthDateTime,
                        DistrictWorker = PassportDistrictTextBox.Text
                    };
                    AppConnectClass.DataBase.PassportWorkerTable.Add(passportWorkerTable);

                    SalaryCardTable salaryCardTable = new SalaryCardTable()
                    {
                        CardNumber = NumberCardTextBox.Text,
                        CardValidMonth = CardValidMonthTextBox.Text,
                        CardValidYears = CardValidYearTextBox.Text,
                        CardKeeperName = NameCardHolderTextBox.Text,
                        CardKeeperSurname = SurnameCardHolderTextBox.Text,
                        CardCode = CodeCardTextBox.Text
                    };
                    AppConnectClass.DataBase.SalaryCardTable.Add(salaryCardTable);

                    WorkerTable workerTable = new WorkerTable()
                    {
                        SurnameWorker = SurnameCardHolderTextBox.Text,
                        NameWorker = NameCardHolderTextBox.Text,
                        MiddlenameWorker = MiddleNameTextBox.Text,
                        PassportSeries = PassportSeriesTextBox.Text,
                        PassportNumber = PassportNumberTextBox.Text,
                        StatusWorker = 1,
                        PostTable = PostComboBox.SelectedItem as PostTable,
                        CardNumberWorker = NumberCardTextBox.Text,
                        LoginWorker = LogintextBox.Text,
                        PasswordWorker = PasswordTextBox.Text,
                        NumberPhoneWorker = NumberPhoneTextBox.Text,
                        EmailWorker = EmailTextBox.Text,
                    };
                    AppConnectClass.DataBase.WorkerTable.Add(workerTable);

                    AppConnectClass.DataBase.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Ошибка добавления работника");
                }
            }
        }
    }
}
