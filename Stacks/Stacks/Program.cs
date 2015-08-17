using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer()
            {
                Id = 101,
                Name = "Oscar",
                Gender = "Male"
            };
            Customer c2 = new Customer()
            {
                Id = 102,
                Name = "Alejandara",
                Gender = "Female"
            };
            Customer c3 = new Customer()
            {
                Id = 103,
                Name = "Juan",
                Gender = "Male"
            };
            Customer c4 = new Customer()
            {
                Id = 104,
                Name = "Johanna",
                Gender = "Female"
            };
            Customer c5 = new Customer()
            {
                Id = 105,
                Name = "Ricardo",
                Gender = "Male"
            };

            // LIFO -> Last in First Out
            Stack<Customer> stackCustomers = new Stack<Customer>();
            stackCustomers.Push(c1);
            stackCustomers.Push(c2);
            stackCustomers.Push(c3);
            stackCustomers.Push(c4);
            stackCustomers.Push(c5);

            Customer tmpC1 = stackCustomers.Pop();
            Console.WriteLine(tmpC1.Id + " - " + tmpC1.Name + " was removed!");
            Console.WriteLine("Customers on the stack {0}", stackCustomers.Count);
            Console.ReadKey();
        }
    }
}
