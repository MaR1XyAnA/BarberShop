using BarberShop.ContentFolder.ClassFolder; // Подключаем библеотеку;
using BarberShop.ViewingFolder.DataBaseFolder; // Подключаем библеотеку;
using System; // Подключаем библеотеку;
using System.Data.Entity.Migrations; // Подключаем библеотеку;
using System.Linq; // Подключаем библеотеку;
using System.Windows; // Подключаем библеотеку;
using System.Windows.Controls; // Подключаем библеотеку;


namespace BarberShop.ViewingFolder.PageFolder
{
    public partial class AddendumWorkerPage : Page
    {
        int IdNull = 0;
        public AddendumWorkerPage(WorkerTable workerTable)
        {
            InitializeComponent();
            AppConnectClass.DataBase = new BarberShopDataBaseEntities();
            IdTExtBox.IsEnabled = false;
            if (workerTable != null)
            {
                workerTable = workerTable;
                DataContext = workerTable;
                IdNull = workerTable.PersonalNumberWorker;
            }
            PaulComboBox.ItemsSource = AppConnectClass.DataBase.PaulTable.ToList();
            PostComboBox.ItemsSource = AppConnectClass.DataBase.PostTable.ToList();
        }
        //StringBuilder Error = new StringBuilder(); // Создаём переменную для подсчёта ошибок
        //private WorkerTable GetWorker = new WorkerTable();
        //private SalaryCardTable GetSalaryCard = new SalaryCardTable();
        //private PassportWorkerTable GetPassport = new PassportWorkerTable();
        //string NamePhoto;
        public void GETERROR()
        {
            //Если пустой или имеет пробелы элемент _______, то запоминаем ошибку и её контекст _________;
            //if (string.IsNullOrWhiteSpace(GetPassport.PassportSeriesWorker)) Error.AppendLine("УКАЖИТЕ СЕРИЮ ПАСПОРТА");
            //if (string.IsNullOrWhiteSpace(GetPassport.PassportNumberWorker)) Error.AppendLine("УКАЖИТЕ НОМЕР ПАСПОРТА");
            //if (string.IsNullOrWhiteSpace(GetPassport.PassportIssuedWorker)) Error.AppendLine("УКАЖИТЕ КЕМ ВЫДАН");
            //if (string.IsNullOrWhiteSpace(GetPassport.RegistrationStreetWorker)) Error.AppendLine("УКАЖИТЕ УЛИЦУ");
            //if (string.IsNullOrWhiteSpace(GetPassport.RegistrationPointWorker)) Error.AppendLine("УКАЖИТЕ ЛОГИН СОТРУДНИКА");
            //if (string.IsNullOrWhiteSpace(DatePassportIssuedTextBox.Text)) Error.AppendLine("УКАЖИТЕ ДАТУ ВЫДАЧИ");
            //if (string.IsNullOrWhiteSpace(PaulComboBox.Text)) Error.AppendLine("УКАЖИТЕ ПОЛ СОТРУДНИКА");
            //if (string.IsNullOrWhiteSpace(PassportPlaceOfBirthTextBox.Text)) Error.AppendLine("УКАЖИТЕ ДАТУ РОЖДЕНИЯ");
            //if (string.IsNullOrWhiteSpace(GetPassport.RegistrationRegionWorker)) Error.AppendLine("УКАЖИТЕ РЕГИСТРАЦИЮ");
            //if (string.IsNullOrWhiteSpace(GetPassport.RegistrationHouseWorker)) Error.AppendLine("УКАЖИТЕ ДОМ");
            //if (string.IsNullOrWhiteSpace(GetPassport.RegistrationApartmentWorker)) Error.AppendLine("УКАЖИТЕ КВАРТИРУ");
            //if (string.IsNullOrWhiteSpace(DateOfBirthTExtBox.Text)) Error.AppendLine("УКАЖИТЕ ДАТУ РОЖДЕНИЯ");
            //if (string.IsNullOrWhiteSpace(GetPassport.DistrictWorker)) Error.AppendLine("УКАЖИТЕ УЛИЦУ");
            //if (string.IsNullOrWhiteSpace(GetSalaryCard.CardNumber)) Error.AppendLine("УКАЖИТЕ НОМЕР КАРТЫ");
            //if (string.IsNullOrWhiteSpace(GetSalaryCard.CardValidMonth)) Error.AppendLine("УКАЖИТЕ МЕСЯЦ ВЫДАЧИ");
            //if (string.IsNullOrWhiteSpace(GetSalaryCard.CardValidYears)) Error.AppendLine("УКАЖИТЕ ГОД ВЫДАЧИ");
            //if (string.IsNullOrWhiteSpace(GetSalaryCard.CardKeeperName)) Error.AppendLine("УКАЖИТЕ ИМЯ КАРТЫ");
            //if (string.IsNullOrWhiteSpace(GetSalaryCard.CardKeeperSurname)) Error.AppendLine("УКАЖИТЕ ФАМИЛИЮ КАРТЫ");
            //if (string.IsNullOrWhiteSpace(GetSalaryCard.CardCode)) Error.AppendLine("УКАЖИТЕ КОД КАРТЫ");
            //if (string.IsNullOrWhiteSpace(GetWorker.SurnameWorker)) Error.AppendLine("УКАЖИТЕ ФАМИЛИЮ СОТРУДНИКА");
            //if (string.IsNullOrWhiteSpace(GetWorker.NameWorker)) Error.AppendLine("УКАЖИТЕ ИМЯ СОТРУДНИКА");
            //if (string.IsNullOrWhiteSpace(PostComboBox.Text)) Error.AppendLine("УКАЖИТЕ ОТЧЕСТВО СОТРУДНИКА");
            //if (string.IsNullOrWhiteSpace(GetWorker.LoginWorker)) Error.AppendLine("УКАЖИТЕ ЛОГИН");
            //if (string.IsNullOrWhiteSpace(GetWorker.PasswordWorker)) Error.AppendLine("УКАЖИТЕ ПАРОЛЬ");
            //if (string.IsNullOrWhiteSpace(GetWorker.NumberPhoneWorker)) Error.AppendLine("УКАЖИТЕ НОМЕР ТЕЛЕФОНА");
            //if (string.IsNullOrWhiteSpace(GetWorker.EmailWorker)) Error.AppendLine("УКАЖИТЕ ЭЛЕКТРОННУЮ ПОЧТУ");
            //if (Error.Length > 0) { MessageBox.Show(Error.ToString(), "ПУСТЫЕ ПОЛЯ"); return; }            // Проверяем, нет ли у нас активных действий в Error которые проверяются в методе GetError
        }

        private void UploadingPhotosButton_Click(object sender, RoutedEventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.ShowDialog();
            //NamePhoto = openFileDialog.FileName;
            //ImageSource imageSource = new BitmapImage(new Uri(NamePhoto));
            //PhotoProfileImage.Source = imageSource;
        }

        private void NewWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime DatePassportIssuedDateTime, DateOfBirthDateTime;
            DatePassportIssuedDateTime = Convert.ToDateTime(DatePassportIssuedTextBox.Text);
            DateOfBirthDateTime = Convert.ToDateTime(DateOfBirthTExtBox.Text);

            var salaryCardTable = new SalaryCardTable()
            {
                CardNumber = NumberCardTextBox.Text,
                CardValidMonth = CardValidMonthTextBox.Text,
                CardValidYears = CardValidYearTextBox.Text,
                CardKeeperName = NameCardHolderTextBox.Text,
                CardKeeperSurname = SurnameCardHolderTextBox.Text,
                CardCode = CodeCardTextBox.Text
            };
            var workerTable = new WorkerTable()
            {
                PersonalNumberWorker = IdNull,
                SurnameWorker = SurnameTextBox.Text,
                NameWorker = NameTextBox.Text,
                MiddlenameWorker = MiddleNameTextBox.Text,
                PassportSeries = PassportSeriesTextBox.Text,
                PassportNumber = PassportNumberTextBox.Text,
                StatusWorker = 1,
                PostWorker = (PostComboBox.SelectedItem as PostTable).PersonalNumberPost,
                CardNumberWorker = NumberCardTextBox.Text,
                LoginWorker = LogintextBox.Text,
                PasswordWorker = PasswordTextBox.Text,
                NumberPhoneWorker = NumberPhoneTextBox.Text,
                EmailWorker = EmailTextBox.Text
            };

            var passportWorkerTable = new PassportWorkerTable()
            {
                PassportSeriesWorker = PassportSeriesTextBox.Text,
                PassportNumberWorker = PassportNumberTextBox.Text,
                PassportIssuedWorker = PassportIssuedTextBox.Text,
                DateOfIssueWorker = DatePassportIssuedDateTime,
                DivisionCodeWorker = DivisionСodeTextBox.Text,
                PaulWorker = (PaulComboBox.SelectedItem as PaulTable).PersonalNumberPaul,
                PlaceOfBirthWorker = PassportPlaceOfBirthTextBox.Text,
                RegistrationRegionWorker = PassportRegionTextBox.Text,
                RegistrationPointWorker = PassportPointTextBox.Text,
                RegistrationStreetWorker = PassportStreetTextBox.Text,
                RegistrationHouseWorker = PassportHouseTextBox.Text,
                RegistrationApartmentWorker = RegistrationApartmentWorkerTextBox.Text,
                DateOfBirthWorker = DateOfBirthDateTime,
                DistrictWorker = PassportDistrictTextBox.Text
            };

            WorkerTable WorkerSearth = AppConnectClass.DataBase.WorkerTable.Find(IdNull);
            try
            {
                if (WorkerSearth != null)
                {
                    AppConnectClass.DataBase.PassportWorkerTable.AddOrUpdate(passportWorkerTable);
                    AppConnectClass.DataBase.SalaryCardTable.AddOrUpdate(salaryCardTable);
                    AppConnectClass.DataBase.WorkerTable.AddOrUpdate(workerTable);
                }
                else
                {
                    if (AppConnectClass.DataBase.WorkerTable.Count(data =>
                            data.LoginWorker == LogintextBox.Text && data.PasswordWorker == PasswordTextBox.Text ||
                            data.SurnameWorker == SurnameTextBox.Text && data.NameWorker == NameTextBox.Text && data.MiddlenameWorker == MiddleNameTextBox.Text ||
                            data.PassportSeries == PassportSeriesTextBox.Text && data.PassportNumber == PassportNumberTextBox.Text ||
                            data.CardNumberWorker == NumberCardTextBox.Text) > 0)
                    {
                        MessageBox.Show("Данный пользователь уже есть", "ОШИБКА ДОБАВЛЕНИЯ");
                        return;
                    }
                    else
                    {
                        AppConnectClass.DataBase.PassportWorkerTable.Add(passportWorkerTable);
                        AppConnectClass.DataBase.SalaryCardTable.Add(salaryCardTable);
                        AppConnectClass.DataBase.WorkerTable.Add(workerTable);
                    }
                }
                AppConnectClass.DataBase.SaveChanges();
                MessageBox.Show("Данные успешно сохранены");
                FrameClass.AddEditWorkerClass.Navigate(new NextTextPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "", "Ошибка добавления");
            }
        }
    }
}
