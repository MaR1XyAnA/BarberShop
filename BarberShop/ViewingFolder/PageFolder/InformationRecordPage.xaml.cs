using BarberShop.ViewingFolder.DataBaseFolder; // Подключаем библеотеку;
using System.Windows.Controls; // Подключаем библеотеку;

namespace BarberShop.ViewingFolder.PageFolder
{
    public partial class InformationRecordPage : Page
    {
        public InformationRecordPage(ResultTable resultTable)
        {
            InitializeComponent();
            AppConnectClass.DataBase = new BarberShopDataBaseEntities();
            if (resultTable != null)
            {
                resultTable = resultTable;
                DataContext = resultTable;
            }
        }
    }
}
