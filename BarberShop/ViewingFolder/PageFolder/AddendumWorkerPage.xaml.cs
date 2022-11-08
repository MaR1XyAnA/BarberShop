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
        //int ImageBold = 0;
        //byte ImageByte;
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
            //ImageBold = 1;  
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
                    //ImageByte = Convert.ToByte(Convert.ToBase64String(File.ReadAllBytes(NamePhoto)));
                    //ImageWorkerTable imageWorkerTable = new ImageWorkerTable()
                    //{
                    //    NameImage = NamePhoto,
                    //    ImageBit = PhotoProfileImage
                    //};
                    //if (ImageBold == 1)
                    //{
                    //    AppConnectClass.DataBase.ImageWorkerTable.Add(imageWorkerTable);
                    //    return;
                    //}

                    PassportWorkerTable passportWorkerTable = new PassportWorkerTable()
                    {
                        PassportSeriesWorker = PassportSeriesTextBox.Text,
                        PassportNumberWorker = PassportNumberTextBox.Text,
                        SurnameWorker = SurnameTextBox.Text,
                        NameWorker = NameTextBox.Text,
                        MiddleNameWorker = MiddleNameTextBox.Text,
                        PassportIssuedWorker = PassportIssuedTextBox.Text,
                        DateOfIssueWorker = DatePassportIssuedDateTime,
                        DivisionCodeWorker = DivisionСodeTextBox.Text,
                        PaulWorker = PaulComboBox.Text,
                        PlaceOfBirthWorker = PassportPlaceOfBirthTextBox.Text,
                        RegistrationRegionWorker = PassportRegionTextBox.Text,
                        RegistrationPointWorker = PassportPointTextBox.Text,
                        RegistrationStreetWorker = PassportStreetTextBox.Text,
                        RegistrationHouseWorker = PassportHouseTextBox.Text,
                        RegistrationApartmentWorker = RegistrationApartmentWorkerTextBox.Text,
                        DateOfBirthWorker = DateOfBirthDateTime,
                        DistrictWorker = PassportDistrictTextBox.Text,
                        ImageWorker = "ERROR"
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
                        PSWorker = PassportSeriesTextBox.Text,
                        PNWorker = PassportNumberTextBox.Text,
                        StatusWorker = 1,
                        PostWorker = PostComboBox.Text,
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
