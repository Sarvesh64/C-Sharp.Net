using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace WebDataSetClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataSet ds = new DataSet();
        localhost.WebServiceDataSet host = new localhost.WebServiceDataSet();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ds = host.GetDataSet();
            mera_grid.ItemsSource = ds.Tables["Emps"].DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            host.UpdateDataSet(ds);
        }
    }
}
