using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public interface IDbFunctions
    {
        decimal GetNetSalary();
    }

    abstract class Employee : IDbFunctions
    {
        private static int empid = 1;
        public int id;
        private String name;

        public String NAME
        {
            set
            {

                if (value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Invalid name!! ");
                }
            }
            get { return name; }
        }

        private decimal basic;
        abstract public decimal BASIC
        {
            set;

            get;
           
        }
        private int deptNo;

        public int DEPTNO
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid value!!");
                }
            }
            get { return deptNo; }
        }

        public Employee()
        { }

        public Employee(string name, decimal basic, int deptNo)
        {
            //this.id = id;
            this.name = name;
            this.basic = basic;
            this.deptNo = deptNo;
            id = empid++;
        }

        public decimal GetNetSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Manager : Employee
    {
        private String Designation;

        public String DESIGNATION
        {
            set
            {
                if (value != "")
                {
                    Designation = value;
                }
                else
                {
                    Console.WriteLine("Invalid designation");
                }
            }
            get { return Designation; }
        }

        public override decimal BASIC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class Programmer : Employee
    {
        private String technologiesKnown;

        public String TECHNOLOGIESKNOWN
        {
            set
            {
                if (value != "")
                {
                    technologiesKnown = value;
                }
                else
                {
                    Console.WriteLine("Invalid value");
                }
            }
            get { return technologiesKnown; }
        }

        public override decimal BASIC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }


    class GeneralManager : Manager
    {
        private String AdditionalInfo;

        public String ADDITIONALINFO
        {
            set
            {
                if (value != "")
                {
                    AdditionalInfo = value;
                }
                else
                {
                    Console.WriteLine("Invalid AdditionalInfo");
                }
            }
            get
            {
                return AdditionalInfo;
            }
        }
    }
}
