using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Customer
    {
        String firstName;
        String lastName;

        public Customer()
        {

        }

        public Customer(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            this.printSomething();
        }

        public void printSomething()
        {
            Console.WriteLine("Something...");
        }
    }
}
