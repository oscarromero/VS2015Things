using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool equal = Calculator.AreEqual(1, 2);
            bool equal = Calculator.AreEqual<String>("A", "A");
            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

            Console.ReadKey();
        }
    }

    class Calculator
    {
        //public static bool AreEqual(int value1, int value2)
        //{
        //    return value1 == value2;
        //}

        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
