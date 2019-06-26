using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee e1 = new Employee("Sarvesh", 0);
                Employee e2 = new Employee("Chirag", 0);

                Console.ReadLine();
            }
            catch(InvalidSalaryException i)
            {
                Console.WriteLine(i.Message);
                Console.ReadLine();
            }
        }
    }

    public class Employee
    {
        public static int id;
        private int empId;

        public int EMPID
        {
            get
            {
                return empId;
            }
        }

        private String empName;

        public String EMPNAME
        {
            set
            {

                if (value != "")
                {
                    empName = value;
                }
                else
                {
                    throw new InvalidSalaryException("Invalid String");
                }
                
            }
            get { return empName; }
        }
        private decimal salary;

        public decimal SALARY
        {
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                {
                    throw new InvalidSalaryException("Invalid String");
                }
            }
            get
            {
                return salary;
            }
        }

        public Employee(string empName="", decimal salary=0)
        {
            empId = ++id;
            this.empName = empName;
            this.salary = salary;

            Console.WriteLine("Employee Id : " + EMPID);
            Console.WriteLine("Employee Name : " + EMPNAME);
            Console.WriteLine("Employee Salary : " + SALARY);
        }
    }
    internal class InvalidSalaryException : Exception
    {
        public InvalidSalaryException()
        {
        }

        public InvalidSalaryException(string message) : base(message)
        {
        }

    }
}
