using BarberShop.ViewingFolder.DataBaseFolder; // Подключаем библеотеку;
using System.Windows.Controls; // Подключаем библеотеку;

namespace BarberShop.ViewingFolder.PageFolder
{
    public partial class InformationServisePage : Page
    {
        public InformationServisePage(HaircutTable haircutTable)
        {
            InitializeComponent();
            if (haircutTable != null)
            {
                haircutTable = haircutTable;
                DataContext = haircutTable;
            }
        }
    }
}
