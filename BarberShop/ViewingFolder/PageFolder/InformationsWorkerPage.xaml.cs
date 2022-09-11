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
    /// <summary>
    /// Логика взаимодействия для InformationsWorkerPage.xaml
    /// </summary>
    public partial class InformationsWorkerPage : Page
    {
        WorkerTable workerTable = new WorkerTable();
        public InformationsWorkerPage(WorkerTable workerTable)
        {
            InitializeComponent();
            if (workerTable != null)
            {
                workerTable = workerTable;
                DataContext = workerTable;
            }
        }

        private void EditInformationsWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            EditInformationsWorkerButton.Visibility = Visibility.Collapsed;
            DeleteInformationsWokerButton.Visibility = Visibility.Collapsed;
            SaveInformationsWorkerButton.Visibility = Visibility.Visible;
            CanselEditInformationsWorkerButton.Visibility = Visibility.Visible;
            UploadingPhotosButton.Visibility = Visibility.Visible;

            //string PersonalNumberWorkerString;
            //string StatusWorkerString;
            //string SurnameWorkerWorkerString;
            //string NameWorkerString;
            //string MiddleNameWorkerString;
            //string PaulWorkerString;
            //string DateOfBirthWorkerString;
            //string PostWorkerString;
            //string LoginWorkerString;
            //string PasswordWorkerString;
            //string NumberPhoneWorkerString;
            //string EmailWorkerString;
            //string PSWorkerString;
            //string PNWorkerString;
            //string PassportIssuedWorkerString;
            //string DateOfIssueWorkerString;
            //string DivisionCodeWorkerString;
            //string PlaceOfBirthWorkerString;
            //string RegistrationRegionWorkerString;
            //string DistrictWorkerString;
            //string RegistrationPointWorkerString;
            //string RegistrationStreetWorkerString;
            //string RegistrationHouseWorkerString;
            //string RegistrationApartmentWorkerString;
            //string CardNumberWorkerString;
            //string CardValidMonthWorkerString;
            //string CardValidYearsString;
            //string CardKeeperNameString;
            //string CardKeeperSurnameString;
            //string CardCodeString;

            PersonalNumberWorkerTextBlock.Visibility = Visibility.Collapsed;
            StatusWorkerTextBlock.Visibility = Visibility.Collapsed;
            SurnameWorkerWorkerTextBlock.Visibility = Visibility.Collapsed;
            NameWorkerTextBlock.Visibility = Visibility.Collapsed;
            MiddleNameWorkerTextBlock.Visibility = Visibility.Collapsed;
            PaulWorkerTextBlock.Visibility = Visibility.Collapsed;
            DateOfBirthWorkerTextBlock.Visibility = Visibility.Collapsed;
            PostWorkerTextBlock.Visibility = Visibility.Collapsed;
            LoginWorkerTextBlock.Visibility = Visibility.Collapsed;
            PasswordWorkerTextBlock.Visibility = Visibility.Collapsed;
            NumberPhoneWorkerTextBlock.Visibility = Visibility.Collapsed;
            EmailWorkerTextBlock.Visibility = Visibility.Collapsed;
            PSWorkerTextBlock.Visibility = Visibility.Collapsed;
            PNWorkerTextBlock.Visibility = Visibility.Collapsed;
            PassportIssuedWorkerTextBlock.Visibility = Visibility.Collapsed;
            DateOfIssueWorkerTextBlock.Visibility = Visibility.Collapsed;
            DivisionCodeWorkerTextBlock.Visibility = Visibility.Collapsed;
            PlaceOfBirthWorkerTextBlock.Visibility = Visibility.Collapsed;
            RegistrationRegionWorkerTextBlock.Visibility = Visibility.Collapsed;
            DistrictWorkerTextBlock.Visibility = Visibility.Collapsed;
            RegistrationPointWorkerTextBlock.Visibility = Visibility.Collapsed;
            RegistrationStreetWorkerTextBlock.Visibility = Visibility.Collapsed;
            RegistrationHouseWorkerTextBlock.Visibility = Visibility.Collapsed;
            RegistrationApartmentWorkerTextBlock.Visibility = Visibility.Collapsed;
            CardNumberWorkerTextBlock.Visibility = Visibility.Collapsed;
            CardValidMonthTextBlock.Visibility = Visibility.Collapsed;
            CardValidYearsTextBlock.Visibility = Visibility.Collapsed;
            CardKeeperNameTextBlock.Visibility = Visibility.Collapsed;
            CardKeeperSurnameTextBlock.Visibility = Visibility.Collapsed;
            CardCodeTextBlock.Visibility = Visibility.Collapsed;

            PersonalNumberWorkerTextBox.Visibility = Visibility.Visible;
            StatusWorkerTextBox.Visibility = Visibility.Visible;
            SurnameWorkerWorkerTextBox.Visibility = Visibility.Visible;
            NameWorkerTextBox.Visibility = Visibility.Visible;
            MiddleNameWorkerTextBox.Visibility = Visibility.Visible;
            PaulWorkerTextBox.Visibility = Visibility.Visible;
            DateOfBirthWorkerTextBox.Visibility = Visibility.Visible;
            PostWorkerTextBox.Visibility = Visibility.Visible;
            LoginWorkerTextBox.Visibility = Visibility.Visible;
            PasswordWorkerTextBox.Visibility = Visibility.Visible;
            NumberPhoneWorkerTextBox.Visibility = Visibility.Visible;
            EmailWorkerTextBox.Visibility = Visibility.Visible;
            PSWorkerTextBox.Visibility = Visibility.Visible;
            PNWorkerTextBox.Visibility = Visibility.Visible;
            PassportIssuedWorkerTextBox.Visibility = Visibility.Visible;
            DateOfIssueWorkerTextBox.Visibility = Visibility.Visible;
            DivisionCodeWorkerTextBox.Visibility = Visibility.Visible;
            PlaceOfBirthWorkerTextBox.Visibility = Visibility.Visible;
            RegistrationRegionWorkerTextBox.Visibility = Visibility.Visible;
            DistrictWorkerTextBox.Visibility = Visibility.Visible;
            RegistrationPointWorkerTextBox.Visibility = Visibility.Visible;
            RegistrationStreetWorkerTextBox.Visibility = Visibility.Visible;
            RegistrationHouseWorkerTextBox.Visibility = Visibility.Visible;
            RegistrationApartmentWorkerTextBox.Visibility = Visibility.Visible;
            CardNumberWorkerTextBox.Visibility = Visibility.Visible;
            CardValidMonthTextBox.Visibility = Visibility.Visible;
            CardValidYearsTextBox.Visibility = Visibility.Visible;
            CardKeeperNameTextBox.Visibility = Visibility.Visible;
            CardKeeperSurnameTextBox.Visibility = Visibility.Visible;
            CardCodeTextBox.Visibility = Visibility.Visible;
            PersonalNumberWorkerTextBox.Visibility = Visibility.Visible;
        }

        private void DeleteInformationsWokerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveInformationsWorkerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CanselEditInformationsWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            EditInformationsWorkerButton.Visibility = Visibility.Visible;
            DeleteInformationsWokerButton.Visibility = Visibility.Visible;
            SaveInformationsWorkerButton.Visibility = Visibility.Collapsed;
            CanselEditInformationsWorkerButton.Visibility = Visibility.Collapsed;
            UploadingPhotosButton.Visibility = Visibility.Collapsed;

            PersonalNumberWorkerTextBlock.Visibility = Visibility.Visible;
            StatusWorkerTextBlock.Visibility = Visibility.Visible;
            SurnameWorkerWorkerTextBlock.Visibility = Visibility.Visible;
            NameWorkerTextBlock.Visibility = Visibility.Visible;
            MiddleNameWorkerTextBlock.Visibility = Visibility.Visible;
            PaulWorkerTextBlock.Visibility = Visibility.Visible;
            DateOfBirthWorkerTextBlock.Visibility = Visibility.Visible;
            PostWorkerTextBlock.Visibility = Visibility.Visible;
            LoginWorkerTextBlock.Visibility = Visibility.Visible;
            PasswordWorkerTextBlock.Visibility = Visibility.Visible;
            NumberPhoneWorkerTextBlock.Visibility = Visibility.Visible;
            EmailWorkerTextBlock.Visibility = Visibility.Visible;
            PSWorkerTextBlock.Visibility = Visibility.Visible;
            PNWorkerTextBlock.Visibility = Visibility.Visible;
            PassportIssuedWorkerTextBlock.Visibility = Visibility.Visible;
            DateOfIssueWorkerTextBlock.Visibility = Visibility.Visible;
            DivisionCodeWorkerTextBlock.Visibility = Visibility.Visible;
            PlaceOfBirthWorkerTextBlock.Visibility = Visibility.Visible;
            RegistrationRegionWorkerTextBlock.Visibility = Visibility.Visible;
            DistrictWorkerTextBlock.Visibility = Visibility.Visible;
            RegistrationPointWorkerTextBlock.Visibility = Visibility.Visible;
            RegistrationStreetWorkerTextBlock.Visibility = Visibility.Visible;
            RegistrationHouseWorkerTextBlock.Visibility = Visibility.Visible;
            RegistrationApartmentWorkerTextBlock.Visibility = Visibility.Visible;
            CardNumberWorkerTextBlock.Visibility = Visibility.Visible;
            CardValidMonthTextBlock.Visibility = Visibility.Visible;
            CardValidYearsTextBlock.Visibility = Visibility.Visible;
            CardKeeperNameTextBlock.Visibility = Visibility.Visible;
            CardKeeperSurnameTextBlock.Visibility = Visibility.Visible;
            CardCodeTextBlock.Visibility = Visibility.Visible;

            PersonalNumberWorkerTextBox.Visibility = Visibility.Collapsed;
            StatusWorkerTextBox.Visibility = Visibility.Collapsed;
            SurnameWorkerWorkerTextBox.Visibility = Visibility.Collapsed;
            NameWorkerTextBox.Visibility = Visibility.Collapsed;
            MiddleNameWorkerTextBox.Visibility = Visibility.Collapsed;
            PaulWorkerTextBox.Visibility = Visibility.Collapsed;
            DateOfBirthWorkerTextBox.Visibility = Visibility.Collapsed;
            PostWorkerTextBox.Visibility = Visibility.Collapsed;
            LoginWorkerTextBox.Visibility = Visibility.Collapsed;
            PasswordWorkerTextBox.Visibility = Visibility.Collapsed;
            NumberPhoneWorkerTextBox.Visibility = Visibility.Collapsed;
            EmailWorkerTextBox.Visibility = Visibility.Collapsed;
            PSWorkerTextBox.Visibility = Visibility.Collapsed;
            PNWorkerTextBox.Visibility = Visibility.Collapsed;
            PassportIssuedWorkerTextBox.Visibility = Visibility.Collapsed;
            DateOfIssueWorkerTextBox.Visibility = Visibility.Collapsed;
            DivisionCodeWorkerTextBox.Visibility = Visibility.Collapsed;
            PlaceOfBirthWorkerTextBox.Visibility = Visibility.Collapsed;
            RegistrationRegionWorkerTextBox.Visibility = Visibility.Collapsed;
            DistrictWorkerTextBox.Visibility = Visibility.Collapsed;
            RegistrationPointWorkerTextBox.Visibility = Visibility.Collapsed;
            RegistrationStreetWorkerTextBox.Visibility = Visibility.Collapsed;
            RegistrationHouseWorkerTextBox.Visibility = Visibility.Collapsed;
            RegistrationApartmentWorkerTextBox.Visibility = Visibility.Collapsed;
            CardNumberWorkerTextBox.Visibility = Visibility.Collapsed;
            CardValidMonthTextBox.Visibility = Visibility.Collapsed;
            CardValidYearsTextBox.Visibility = Visibility.Collapsed;
            CardKeeperNameTextBox.Visibility = Visibility.Collapsed;
            CardKeeperSurnameTextBox.Visibility = Visibility.Collapsed;
            CardCodeTextBox.Visibility = Visibility.Collapsed;
            PersonalNumberWorkerTextBox.Visibility = Visibility.Collapsed;
        }

        private void UploadingPhotosButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
