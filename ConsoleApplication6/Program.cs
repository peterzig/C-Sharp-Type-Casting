using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 13.37;
            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            int myInt = (int)myDouble;
            string myString = myDouble.ToString();
            string myFloatString = myFloat.ToString();

            Console.WriteLine("Integer value: ");
            Console.WriteLine(myInt);
            Console.WriteLine("\n");
            Console.WriteLine("Float value: ");
            Console.WriteLine(myFloat);
            Console.WriteLine("\n");
            Console.WriteLine("Double value: ");
            Console.WriteLine(myDouble);
            Console.WriteLine("\n");
            Console.WriteLine("Double value: (from Float) ");
            Console.WriteLine(myNewDouble);
            Console.WriteLine("\n");
            Console.WriteLine("String from double: ");
            Console.WriteLine(myString);
            Console.WriteLine("\n");
            Console.WriteLine("String from float: ");
            Console.WriteLine(myFloatString);
            Console.Read();

        }
    }
}
