using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousFunction
{
    public delegate void AddDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            string[] abc = new string[3]
             { "babba", "sarvesh", "chirag" };


            foreach (string i in abc)
            {
                Console.WriteLine(i);
            }


            Program p1 = new Program();
            // AddDelegate adele;
            //AddDelegate adele = new AddDelegate(p1.Add);
            //int sum=adele.Invoke(5, 10);
            // int sum = adele(5, 10);
            //  Console.WriteLine("The sum is {0}",sum);


            AddDelegate adele = delegate (int a, int b)
            {
                //return a + b;
                Console.WriteLine("The sum is : " + (a+b));
            };

            adele += (int a, int b) =>

            Console.WriteLine("The diff is :" + (a-b));

            //adele+=delegate(int a,int b)
            //{
            //    return a - b;
            //};

            adele +=(a, b)=>
            Console.WriteLine("The product is :" + (a * b));
            adele(5, 10);
            
            //Console.WriteLine("The sum is {0}", );

            Console.ReadLine();
        }
        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}


       
    }
}
