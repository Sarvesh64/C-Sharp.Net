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

namespace AdoProjectDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_insert_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Exam63;Integrated Security=True;Pooling=False";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Student values(@StuId, @StuName, @StuMarks)";

            cmd.Parameters.AddWithValue("@StuId", txt_id.Text);
            cmd.Parameters.AddWithValue("@StuName", txt_name.Text);
            cmd.Parameters.AddWithValue("@StuMarks", txt_marks.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Btn_update_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Exam63;Integrated Security=True;Pooling=False";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_procedure";

            cmd.Parameters.AddWithValue("@StuId", txt_id.Text);
            cmd.Parameters.AddWithValue("@StuName", txt_name.Text);
            cmd.Parameters.AddWithValue("@StuMarks", txt_marks.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Success");
            conn.Close();
        }

        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Exam63;Integrated Security=True;Pooling=False";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_procedure";

            cmd.Parameters.AddWithValue("@StuId", txt_id.Text);
           

            cmd.ExecuteNonQuery();
            MessageBox.Show("Success");
            conn.Close();
        }

        private void Btn_display_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Exam63;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student";

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                list.Items.Add(new ListBoxItem { Content = dr["StuName"].ToString() });
               

            }
        }
    }
}
