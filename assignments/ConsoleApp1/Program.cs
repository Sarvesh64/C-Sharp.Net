using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.i = 100;
            obj.j = 200;

            Console.WriteLine("obj.i  "+obj.i);
            Console.WriteLine("obj.j  "+obj.j);
            doSomething1(obj);
            Console.WriteLine("After calling doSomething1");
            Console.WriteLine("obj.i  " +obj.i);
            Console.WriteLine("obj.j  " + obj.j);

            doSomething2(obj);
            Console.WriteLine("After calling doSomething2");
            Console.WriteLine("obj.i  " + obj.i);
            Console.WriteLine("obj.j  " + obj.j);

            doSomething3(ref obj);
            Console.WriteLine("After calling doSomething3");
            Console.WriteLine("obj.i  " + obj.i);
            Console.WriteLine("obj.j  " + obj.j);
            Console.ReadLine();

        }

        static void doSomething1(Class1 obj)
        {
            obj.i = 300;
        }

        static void doSomething2(Class1 obj)
        {
            obj = new Class1();
            obj.i = 300;
        }

        static void doSomething3(ref Class1 obj)
        {
            obj = new Class1();
            obj.i = 300;
        }
    }

    class Class1
    {
        public int i;
        public int j;

    }
}
