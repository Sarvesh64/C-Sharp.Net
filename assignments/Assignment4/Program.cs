using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public delegate void Del1(int invalidValue);

    class Program
    {
        static void Main()
        {

            try
            {
                Employee e1 = new Employee("Sarvesh", 25336458, 2);

                Employee e2 = new Employee("Chirag", 9820);

                //Employee e3 = new Employee("Sarvesh");

                //Employee e4 = new Employee();

                Console.ReadLine();

            }
            catch (InvalidStringException ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (InvalidSalaryException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
       
        public static void InvalidMethod(int invalidValue)
        {

        }
    }

    public class Employee
    {

        public event Del1 delEvent;


        #region Properties
  
        public static int X;
        private int empId;

      
        public int EmpId
        {
            get
            {
                return empId; 
            }
        }
        public String empName;

        public String EmpName
        {
            set
            {

                if (value != "")
                {
                    empName = value;
                }
                else
                {
                    throw new InvalidStringException("Invalid String");
                }
            }
            get
            {
                return empName;
            }
        }

        public decimal salary;

        public decimal Salary
        {
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                {
                    throw new InvalidSalaryException("Salary Cant be Below '0'");
                }
            }
            get
            {
                return salary;     
            }
        }

        public short departmentNo;

        public short DepatementNo
        {
            set
            {
                if (value > 0)
                {
                    departmentNo = value;

                }
                else
                {
                   
                    if (delEvent != null)
                    {
                        delEvent(value);
                    }
                }
            }
            get
            {
                return departmentNo; 
            }
        }

        #endregion

        #region GetNetSalary Method

        decimal netSal;

        public decimal GEtNetSalary()
        {
            netSal = salary - (salary * 2) / 100;

            Console.WriteLine("Employess net salary is " + netSal);
            Console.WriteLine("");
            return netSal;
        }

        #endregion

        #region Constructor


        public Employee(string EmpName = "", decimal Salary = 0, short DepatementNo = 0)
        {
            empId = ++X;
            this.EmpName = EmpName;
            this.Salary = Salary;
            this.DepatementNo = DepatementNo;

            Console.WriteLine("Employee Id : " + EmpId);
            Console.WriteLine("Employee Name : " + EmpName);
            Console.WriteLine("Employee Salary : " + Salary);
            Console.WriteLine("Employee Department No : " + DepatementNo);
            Console.WriteLine();
        }

        #endregion


    }

    #region Exception Class

    [Serializable]
    internal class InvalidSalaryException : Exception
    {
        public InvalidSalaryException()
        {
        }

        public InvalidSalaryException(string message) : base(message)
        {
        }

    }

    [Serializable]
    internal class InvalidStringException : Exception
    {
        public InvalidStringException()
        {
        }

        public InvalidStringException(string message) : base(message)
        {
        }

    }
    #endregion
}