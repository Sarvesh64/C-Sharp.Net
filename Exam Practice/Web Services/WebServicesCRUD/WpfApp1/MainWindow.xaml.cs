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

namespace WpfApp1
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

       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            localhost.WebService obj = new localhost.WebService();
            ds = obj.GetDataSet();
            data_grid.ItemsSource = ds.Tables["Stud"].DefaultView;
        }

        private void Btn_update_Click(object sender, RoutedEventArgs e)
        {
            localhost.WebService obj = new localhost.WebService();
            obj.UpdateDataSet(ds);
        }
    }
}
