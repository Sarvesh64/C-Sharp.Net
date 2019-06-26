using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee ("Sarvesh", 20000, 20);
            Console.WriteLine("id :" +e1.id);
            Console.WriteLine("Name: " +e1.NAME);
            Console.WriteLine("BAsic: " + e1.BASIC);
            Console.WriteLine("Dept no: " + e1.DEPTNO);


            Employee e2 = new Employee("sonali", 15000, 31);
            Console.WriteLine("id :" + e2.id);
            Console.WriteLine("Name" + e2.NAME);
            Console.WriteLine(e2.BASIC);
            Console.WriteLine(e2.DEPTNO);


            Employee e3 = new Employee("Chirag", 25000, 41);
            Console.WriteLine("id :" + e3.id);
            Console.WriteLine("Name" + e3.NAME);
            Console.WriteLine(e3.BASIC);
            Console.WriteLine(e3.DEPTNO);
            Console.ReadLine();



        }
    }
   

    class Employee 
    {
        private static int  empid=1;
        public int id;
        private String name;

        public String NAME
        {
            set
            {
                
                if(value != "")
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
        public decimal BASIC
        {
            set
            {
               if (value > 1000 && value < 50000)
               {
                    basic = value;
                    Console.WriteLine("The salary is :", basic);
                }
                else
                {
                    Console.WriteLine("Invalid salary ");
                }
            }

            get
            {
                return basic;
            }
        }
        private int deptNo;

        public int DEPTNO
        {
            set {
                if(value > 0)
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
        {

        }

        public Employee( string name, decimal basic, int deptNo)
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
   





}
