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
            EditDeleteStackPanel.Visibility = Visibility.Collapsed;
            SaveCanselStackPanel.Visibility = Visibility.Visible;

            string 
                PersonalNumberWorkerString, StatusWorkerString, SurnameWorkerWorkerString,
                NameWorkerString, MiddleNameWorkerString, PaulWorkerString,
                DateOfBirthWorkerString, PostWorkerString, LoginWorkerString,
                PasswordWorkerString, NumberPhoneWorkerString, EmailWorkerString,
                PSWorkerString, PNWorkerString, PassportIssuedWorkerString,
                DateOfIssueWorkerString, DivisionCodeWorkerString, PlaceOfBirthWorkerString,
                RegistrationRegionWorkerString, DistrictWorkerString, RegistrationPointWorkerString,
                RegistrationStreetWorkerString, RegistrationHouseWorkerString, RegistrationApartmentWorkerString,
                CardNumberWorkerString, CardValidMonthWorkerString, CardValidYearsString,
                CardKeeperNameString, CardKeeperSurnameString, CardCodeString;

            PersonalNumberWorkerString = Convert.ToString(PersonalNumberWorkerTextBlock.Text);
            StatusWorkerString = Convert.ToString(StatusWorkerTextBlock.Text);
            SurnameWorkerWorkerString = Convert.ToString(SurnameWorkerWorkerTextBlock.Text);
            NameWorkerString = Convert.ToString(NameWorkerTextBlock.Text);
            MiddleNameWorkerString = Convert.ToString(MiddleNameWorkerTextBlock.Text);
            PaulWorkerString = Convert.ToString(PaulWorkerTextBlock.Text);
            DateOfBirthWorkerString = Convert.ToString(DateOfBirthWorkerTextBlock.Text);
            PostWorkerString = Convert.ToString(PostWorkerTextBlock.Text);
            LoginWorkerString = Convert.ToString(LoginWorkerTextBlock.Text);
            PasswordWorkerString = Convert.ToString(PasswordWorkerTextBlock.Text);
            NumberPhoneWorkerString = Convert.ToString(NumberPhoneWorkerTextBlock.Text);
            EmailWorkerString = Convert.ToString(EmailWorkerTextBlock.Text);
            PSWorkerString = Convert.ToString(PSWorkerTextBlock.Text);
            PNWorkerString = Convert.ToString(PNWorkerTextBlock.Text);
            PassportIssuedWorkerString = Convert.ToString(PassportIssuedWorkerTextBlock.Text);
            DateOfIssueWorkerString = Convert.ToString(DateOfIssueWorkerTextBlock.Text);
            DivisionCodeWorkerString = Convert.ToString(DivisionCodeWorkerTextBlock.Text);
            PlaceOfBirthWorkerString = Convert.ToString(PlaceOfBirthWorkerTextBlock.Text);
            RegistrationRegionWorkerString = Convert.ToString(RegistrationRegionWorkerTextBlock.Text);
            DistrictWorkerString = Convert.ToString(DistrictWorkerTextBlock.Text);
            RegistrationPointWorkerString = Convert.ToString(RegistrationPointWorkerTextBlock.Text);
            RegistrationStreetWorkerString = Convert.ToString(RegistrationStreetWorkerTextBlock.Text);
            RegistrationHouseWorkerString = Convert.ToString(RegistrationHouseWorkerTextBlock.Text);
            RegistrationApartmentWorkerString = Convert.ToString(RegistrationApartmentWorkerTextBlock.Text);
            CardNumberWorkerString = Convert.ToString(CardNumberWorkerTextBlock.Text);
            CardValidMonthWorkerString = Convert.ToString(CardValidMonthTextBlock.Text);
            CardValidYearsString = Convert.ToString(CardValidYearsTextBlock.Text);
            CardKeeperNameString = Convert.ToString(CardKeeperNameTextBlock.Text);
            CardKeeperSurnameString = Convert.ToString(CardKeeperSurnameTextBlock.Text);
            CardCodeString = Convert.ToString(CardCodeTextBlock.Text);

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
            
            PersonalNumberWorkerTextBox.Text = PersonalNumberWorkerString;
            StatusWorkerTextBox.Text = StatusWorkerString;
            SurnameWorkerWorkerTextBox.Text = SurnameWorkerWorkerString;
            NameWorkerTextBox.Text = NameWorkerString;
            MiddleNameWorkerTextBox.Text = MiddleNameWorkerString;
            PaulWorkerTextBox.Text = PaulWorkerString;
            DateOfBirthWorkerTextBox.Text = DateOfBirthWorkerString;
            PostWorkerTextBox.Text = PostWorkerString;
            LoginWorkerTextBox.Text = LoginWorkerString;
            PasswordWorkerTextBox.Text = PasswordWorkerString;
            NumberPhoneWorkerTextBox.Text = NumberPhoneWorkerString;
            EmailWorkerTextBox.Text = EmailWorkerString;
            PSWorkerTextBox.Text = PSWorkerString;
            PNWorkerTextBox.Text = PNWorkerString;
            PassportIssuedWorkerTextBox.Text = PassportIssuedWorkerString;
            DateOfIssueWorkerTextBox.Text = DateOfIssueWorkerString;
            DivisionCodeWorkerTextBox.Text = DivisionCodeWorkerString;
            PlaceOfBirthWorkerTextBox.Text = PlaceOfBirthWorkerString;
            RegistrationRegionWorkerTextBox.Text = RegistrationRegionWorkerString;
            DistrictWorkerTextBox.Text = DistrictWorkerString;
            RegistrationPointWorkerTextBox.Text = RegistrationPointWorkerString;
            RegistrationStreetWorkerTextBox.Text = RegistrationStreetWorkerString;
            RegistrationHouseWorkerTextBox.Text = RegistrationHouseWorkerString;
            RegistrationApartmentWorkerTextBox.Text = RegistrationApartmentWorkerString;
            CardNumberWorkerTextBox.Text = CardNumberWorkerString;
            CardValidMonthTextBox.Text = CardValidMonthWorkerString;
            CardValidYearsTextBox.Text = CardValidYearsString;
            CardKeeperNameTextBox.Text = CardKeeperNameString;
            CardKeeperSurnameTextBox.Text = CardKeeperSurnameString;
            CardCodeTextBox.Text = CardCodeString;
        }

        private void CanselEditInformationsWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            EditDeleteStackPanel.Visibility = Visibility.Visible;
            SaveCanselStackPanel.Visibility = Visibility.Collapsed;

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
 

        private void SaveInformationsWorkerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteInformationsWokerButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
