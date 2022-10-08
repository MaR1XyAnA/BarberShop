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
    public partial class CustomersRecordList : Page
    {
        public CustomersRecordList()
        {
            InitializeComponent();
            NameHaircutComboBox.ItemsSource = AppConnectClass.DataBase.HaircutTable.ToList();
            PaulTextBox.ItemsSource = AppConnectClass.DataBase.PaulTable.ToList();
            //NameHairdresserComboBox.ItemsSource = AppConnectClass.DataBase.HairdresserOnlineViev.ToList();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            string
                SurnameString,
                NameString,
                MiddleNameString,
                PoulString,
                HaircutString,
                DataRecordStrind,
                TimeRecordString,
                Worker;

            SurnameString = Convert.ToString(SurnameTextBox.Text);
            NameString  = Convert.ToString(NameTextBox.Text);
            MiddleNameString  = Convert.ToString(MiddlenameTextBox.Text);
            PoulString = Convert.ToString(PaulTextBox.Text);
            HaircutString = Convert.ToString(NameHaircutComboBox.Text);
            DataRecordStrind = Convert.ToString(DataRecordTextBox.Text);
            TimeRecordString = Convert.ToString(TimeRecordTextBox.Text);
            Worker = Convert.ToString(NameHairdresserComboBox.Text);


            if (AppConnectClass.DataBase.ClientTable.Count
                (data => data.SurnameClient == SurnameString && data.NameClient == NameString) >0)
            {
                MessageBox.Show("Данный клиент уже записан");
                return;
            }
            try
            {
                ClientTable clientTable = new ClientTable()
                {
                    SurnameClient = SurnameString,
                    NameClient = NameString,
                    MiddleNameClient = MiddleNameString,
                    PaulClient = PoulString
                };
                ResultTable resultTable = new ResultTable()
                {
                    //PNWorker = Worker(PersonalNumberWorker),
                    //PNClient = ,
                    //PNHaircut = HaircutString,
                    //DataResult = DataRecordStrind,
                    //StatusRezult = TimeRecordString
                };
            }
            catch
            {

            }
        }
    }
}
