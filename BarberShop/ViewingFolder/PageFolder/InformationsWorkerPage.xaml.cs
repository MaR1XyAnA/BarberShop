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

            string PersonalNumberWorkerString;
            PersonalNumberWorkerTextBlock.Visibility = Visibility.Collapsed;
            PersonalNumberWorkerTextBox.Visibility = Visibility.Visible;
            PersonalNumberWorkerString = Convert.ToString(PersonalNumberWorkerTextBlock.Text);
            PersonalNumberWorkerTextBox.Text = PersonalNumberWorkerString;
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
            PersonalNumberWorkerTextBox.Visibility = Visibility.Collapsed;
        }

        private void UploadingPhotosButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
