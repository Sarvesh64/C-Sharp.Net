using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ");
            Add(90, 90, out int ans);
            Console.WriteLine("90 + 90 = {0}", ans);
            //Console.WriteLine("Enter the name: ");
            //string uname = Console.ReadLine();
            // Console.WriteLine("Hello" + uname);
            //Console.WriteLine("Hello {0}" , uname);
            //ConsoleColor pcolor = Console.ForegroundColor;
            //Console.ForegroundColor = ConsoleColor.Yellow;

            //Console.WriteLine(10.GetHashCode());
            //Console.WriteLine(10.Equals(12));
            //Console.WriteLine(10.2.GetHashCode());
            //Console.WriteLine(10.2.GetType());
            //Console.WriteLine(10.GetType());
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(double.PositiveInfinity);

            //bool b = bool.Parse("True");
            //Console.WriteLine("Value of b: {0}", b);
            //double d = double.Parse("99.884");
            //Console.WriteLine("Value of d: {0}", d);
            //int i = int.Parse("8");
            //Console.WriteLine("Value of i: {0}", i);
            //char c = Char.Parse("w");
            //Console.WriteLine("Value of c: {0}", c);

             void Add(int a, int b, out int ans)
            {
                ans = a + b;
            }
            Console.ReadLine();


        }
    }
}
