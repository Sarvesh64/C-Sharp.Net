using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesCRUD
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet GetDataSet()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Exam63;Integrated Security=True;Pooling=False";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand=cmd;
            da.Fill(ds, "Stud");
            conn.Close();

            return ds;

        }

        [WebMethod]
        public void UpdateDataSet(DataSet ds)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Exam63;Integrated Security=True;Pooling=False";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Student values(@StuId, @StuName, @StuMarks)";

            cmd.Parameters.Add(new SqlParameter { ParameterName = "@StuId", SourceColumn = "StuId", SourceVersion = DataRowVersion.Current });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@StuName", SourceColumn = "StuName", SourceVersion = DataRowVersion.Current });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@StuMarks", SourceColumn = "StuMarks", SourceVersion = DataRowVersion.Current });
            da.InsertCommand = cmd;

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update Student set StuName=@StuName, StuMarks=@StuMarks where StuId=@StuId";

            cmd1.Parameters.Add(new SqlParameter { ParameterName = "@StuId", SourceColumn = "StuId", SourceVersion = DataRowVersion.Original });
            cmd1.Parameters.Add(new SqlParameter { ParameterName = "@StuName", SourceColumn = "StuName", SourceVersion = DataRowVersion.Current });
            cmd1.Parameters.Add(new SqlParameter { ParameterName = "@StuMarks", SourceColumn = "StuMarks", SourceVersion = DataRowVersion.Current });
            
            da.UpdateCommand = cmd1;

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = conn;
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "delete from Student where StuId=@StuId";

            cmd2.Parameters.Add(new SqlParameter { ParameterName = "@StuId", SourceColumn = "StuId", SourceVersion = DataRowVersion.Original });

           
            da.DeleteCommand = cmd2;
            da.Update(ds, "Stud");
            conn.Close();

           

        }
    }
}
