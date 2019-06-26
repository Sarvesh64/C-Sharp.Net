using System;

namespace InterfaceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //method 1 
            Class1 o = new Class1();
            o.Delete();

            // method 2
            IDbFunctions oIDb;
            oIDb = o;
            oIDb.Delete();

            //method 3 
            ((IDbFunctions)o).Delete();

            Console.ReadLine();
        }
    }

    public interface IDbFunctions
    {
         void Delete();
        void Insert();
        void Update();

    }

    public class Class1 : IDbFunctions
    {

        public void Display()
        {
            Console.WriteLine("Class1 delete");
        }

        public void Delete()
        {
            Console.WriteLine("Class1 delete");
        }

        public void Insert()
        {
            Console.WriteLine("Class1 delete");
        }

        public void Update()
        {
            Console.WriteLine("Class1 delete");
        }
    }
}
