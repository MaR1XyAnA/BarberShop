using BarberShop.ViewingFolder.DataBaseFolder; // Подключаем библеотеку;
using System.Windows; // Подключаем библеотеку;
using System.Windows.Controls; // Подключаем библеотеку;

namespace BarberShop.ViewingFolder.PageFolder
{
    public partial class InformationsWorkerPage : Page
    {
        public InformationsWorkerPage(WorkerTable workerTable)
        {
            InitializeComponent();
            if (workerTable != null)
            {
                workerTable = workerTable;
                DataContext = workerTable;
            }
        }

        private void UploadingPhotosButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
