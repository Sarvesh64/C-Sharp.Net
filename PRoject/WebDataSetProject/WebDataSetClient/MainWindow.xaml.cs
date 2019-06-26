using System;
using System.Collections.Generic;
using System.Data;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Mera_btn_Click(object sender, RoutedEventArgs e)
        {
            merahost.WebServiceDataSet obj = new merahost.WebServiceDataSet();
            ds = obj.GetDataSet();

            mera_grid.ItemsSource = ds.Tables["Emps"].DefaultView;
        }

        private void Btn_update_Click(object sender, RoutedEventArgs e)
        {
            localhost.WebServiceDataSet obj = new localhost.WebServiceDataSet();
             obj.UpdateDataSet(ds);

        }

        private void Btn_insert_Click(object sender, RoutedEventArgs e)
        {
            localhost_insert.WebServiceDataSet obj = new localhost_insert.WebServiceDataSet();
            obj.InsertDataSet(ds);
        }

        
    }
}
