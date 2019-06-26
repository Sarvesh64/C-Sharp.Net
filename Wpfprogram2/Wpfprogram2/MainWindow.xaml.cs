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

namespace Wpfprogram2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Sarvesh63;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText="insert into Employees values(" + txt_rollno.Text +",'"+ txt_firstname.Text + "'," + txt_basic.Text + "," + txt_deptno.Text + ")";

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Sarvesh63;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Employees values(@EmpNo, @Name, @Basic, @DeptNo)";
            cmd.Parameters.AddWithValue("@EmpNo", txt_rollno.Text);
            cmd.Parameters.AddWithValue("@Name", txt_firstname.Text);
            cmd.Parameters.AddWithValue("@Basic", txt_basic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txt_deptno.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Sarvesh63;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Employees where EmpNo=@EmpNo";
            cmd.Parameters.AddWithValue("@EmpNo", txt_delete_id.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        

        private void Btn_update_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Sarvesh63;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Employees set Name=@Name, Basic=@Basic, DeptNo=@DeptNo where EmpNo=@EmpNo";
            cmd.Parameters.AddWithValue("@EmpNo", txt_update_id.Text);
            cmd.Parameters.AddWithValue("@Name", txt_firstname_update.Text);
            cmd.Parameters.AddWithValue("@Basic", txt_basic_update.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txt_deptno_update.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Sarvesh63;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_procedure";

            cmd.Parameters.AddWithValue("@EmpNo", txt_rollno.Text);
            cmd.Parameters.AddWithValue("@Name", txt_firstname.Text);
            cmd.Parameters.AddWithValue("@Basic", txt_basic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txt_deptno.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Sarvesh63;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_procedure";
            cmd.Parameters.AddWithValue("@EmpNo", txt_delete_id.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Sarvesh63;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_procedure";

            cmd.Parameters.AddWithValue("@EmpNo", txt_update_id.Text);
            cmd.Parameters.AddWithValue("@Name", txt_firstname_update.Text);
            cmd.Parameters.AddWithValue("@Basic", txt_basic_update.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txt_deptno_update.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        

        private void Btn_all_query_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Sarvesh63;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "all_query_procedure";

            cmd.Parameters.AddWithValue("@EmpNo", txt_rollno.Text);
            cmd.Parameters.AddWithValue("@Name", txt_firstname.Text);
            cmd.Parameters.AddWithValue("@Basic", txt_basic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txt_deptno.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Btn_display_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Sarvesh63;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                list_employee_id.Items.Add(new ListBoxItem { Content = dr["EmpNo"].ToString() });
                list_employees.Items.Add(new ListBoxItem { Content = dr["Name"].ToString() });
                list_employee_basic.Items.Add(new ListBoxItem { Content = dr["Basic"].ToString() });
                list_employee_dept.Items.Add(new ListBoxItem { Content = dr["DeptNo"].ToString() });

            }
            }
    }
}
