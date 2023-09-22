using StockroomBinar.BD;
using StockroomBinar.Class;
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

namespace StockroomBinar.Pages
{
    /// <summary>
    /// Логика взаимодействия для DeliveresInfoPage.xaml
    /// </summary>
    public partial class DeliveresInfoPage : Page
    {
        public DeliveriesProducts deliveriesProducts = new DeliveriesProducts();
        public Deliveries deliveries = new Deliveries();
        public DeliveresInfoPage(Deliveries item)
        {
            InitializeComponent();
            CostomerText.Text = item.СustomerТame;
            DataText.Text = item.Date.ToString();
            ProcentText.Text = item.Status.ToString();
            DeliversInfoView.ItemsSource = Connect.bd.DeliveriesProducts.Where(p => p.IDInside == item.ID).ToList();

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
