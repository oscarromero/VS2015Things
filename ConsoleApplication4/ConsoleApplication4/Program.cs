using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            printSomething("");

            Customer customer = new Customer();
            customer.printSomething();
        }

        public static void printSomething(String str)
        {
            Console.WriteLine(str);
        }
    }
}
