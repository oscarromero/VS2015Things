using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, Enter your first name:");
            String firstName = Console.ReadLine();

            Console.WriteLine("Please, Enter your last name:");
            String lastName = Console.ReadLine();

            Console.WriteLine("Welcome {0} {1}", firstName, lastName);
            Console.ReadKey();
        }
    }
}
