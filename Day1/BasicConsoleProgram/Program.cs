using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");


            Child child1 = new Child();
            int sum;
            sum = child1.Add(10, c: 20);
            Console.WriteLine(sum);

            child1.I = 49;
            Console.WriteLine(child1.I);
            Console.ReadLine();
        }
    }

    class Child
    {
        public int Add(int a = 0, int b = 1, int c = 0)
        {
            return a + b + c;
        }

        private int i = 1;

        public int I
        {
            set
            {
                if (value > 1 && value < 50)
                {
                    i = value;
                    Console.WriteLine("Value of i is : ", i);
                }
                else
                {
                    Console.WriteLine("Invalid Value");
                }
            }
            get
            {
                return i;
            }
        }

        public int VAR
        {
            set;
            get;
        }
    }
}