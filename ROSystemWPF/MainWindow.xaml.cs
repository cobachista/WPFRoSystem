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
using System.Windows.Threading;

namespace ROSystemWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          

        }

      

        private void SignUp_Click(object sender, RoutedEventArgs e) {

            System.Windows.Application.Current.Shutdown();
        }

        private void btnReports_Click(object sender, RoutedEventArgs e)
        {
            Reports rs = new Reports();
            this.Close();
            rs.Show();
        }

        private void btnPurchase_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSupplier_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnInventary_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSigns_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
