using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService_Object_
{
    /// <summary>
    /// Summary description for WebServiceObj
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceObj : System.Web.Services.WebService
    {

        [WebMethod]
        
        public Student GetStudent()
        {
            return new Student(10, "Pradnya", 1205);
        }
    }

    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }

        public int Basic { get; set; }

        public Student(int rollNo, string name, int basic)
        {
            RollNo = rollNo;
            Name = name;
            Basic = basic;
        }

        public Student()
        {

        }
    }
}
