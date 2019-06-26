using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebDataSetProject
{
    /// <summary>
    /// Summary description for WebServiceDataSet
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceDataSet : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet GetDataSet()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (localdb)\MsSqlLocalDb; Initial Catalog = Sarvesh63; Integrated Security = True; Pooling = False";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText="select * from Employees";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds,"Emps");

            conn.Close();
            return (ds);
        }

        [WebMethod]
        public void UpdateDataSet(DataSet ds)
        {   
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (localdb)\MsSqlLocalDb; Initial Catalog = Sarvesh63; Integrated Security = True; Pooling = False";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Employees set Name=@Name, Basic=@Basic, DeptNo=@DeptNo where EmpNo=@Empno";

            cmd.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });

            
            SqlDataAdapter da = new SqlDataAdapter();
            da.UpdateCommand = cmd;
            da.Update(ds, "Emps");


            conn.Close();

        }
        [WebMethod]
        public void InsertDataSet(DataSet ds)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (localdb)\MsSqlLocalDb; Initial Catalog = Sarvesh63; Integrated Security = True; Pooling = False";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert Employees values (@EmpNo, @Name, @Basic, @DeptNo)";

            cmd.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });


            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand= cmd;
            da.Update(ds, "Emps");


            conn.Close();

        }
        
    }
    
}
