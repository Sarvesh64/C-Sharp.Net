using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(func1);
            Thread t2 = new Thread(func2);

            t1.Start();
            t1.Join();
            t2.Start();
            //t2.Join();
            //t2.Abort();
            t2.Suspend();

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("This is main thread " + i.ToString());
                //Console.ReadLine();
                
            }
            Console.ReadLine();
        }

        public static void func1()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("This is first thread is " + i.ToString());
                //Console.ReadLine();
            }
            
        }

        public static void func2()
        {

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("This is second thread is " + i.ToString());
               // Console.ReadLine();
            }
        }
        
    }
}


7