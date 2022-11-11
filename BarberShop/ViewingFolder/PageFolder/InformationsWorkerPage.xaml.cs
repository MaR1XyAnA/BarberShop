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

        private void UploadingPhotosButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
