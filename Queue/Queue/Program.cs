using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
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

            // FIFO -> First In First Out
            Queue<Customer> queueCustomers = new Queue<Customer>();
            queueCustomers.Enqueue(c1);
            queueCustomers.Enqueue(c2);
            queueCustomers.Enqueue(c3);
            queueCustomers.Enqueue(c4);
            queueCustomers.Enqueue(c5);

            Customer tmpC1 = queueCustomers.Dequeue();            
            Console.WriteLine(tmpC1.Id + " - " + tmpC1.Name + " Removed!");

            Console.WriteLine("Total items in the queue {0}", queueCustomers.Count);

            Console.ReadKey();
        }
    }
}
