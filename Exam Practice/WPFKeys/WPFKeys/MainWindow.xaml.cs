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

namespace WPFKeys
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

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Practice;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";

           
            da.SelectCommand = cmd;
            da.Fill(ds, "Emps");

            cmd.CommandText = "select * from Departments";
            da.Fill(ds, "Depts");

            DataColumn[] arrcolomns = new DataColumn[1];
            arrcolomns[0] = ds.Tables["Emps"].Columns["EmpNo"];
            ds.Tables["Emps"].PrimaryKey = arrcolomns;

            ds.Relations.Add("DepsEmps",
                ds.Tables["Depts"].Columns["DeptNo"],
                ds.Tables["Emps"].Columns["DeptNo"], true);

            grid.ItemsSource = ds.Tables["Emps"].DefaultView;
            grid2.ItemsSource = ds.Tables["Depts"].DefaultView;
            cn.Close();
        }
    }
}
