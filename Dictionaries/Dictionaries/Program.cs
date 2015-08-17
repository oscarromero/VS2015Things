using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public class Customer
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }
    }

    class Program
    {
        private static Program self;

        private Dictionary<int, Customer> customers;

        static void Main(string[] args)
        {
            self = new Program();
            self.PopulateCustomers();

            // Show the first customer
            Customer customer = self.GetCustomerById(1);
            Console.WriteLine(customer.Name);

            self.PrintAllCustomers();
            self.PrintAllCustomers2();

            Console.ReadKey();
        }

        public Customer GetCustomerById(int Id)
        {
            return customers[Id];
        }

        public void PrintAllCustomers()
        {
            // Iterate trough the customers dictionary.
            foreach (KeyValuePair<int, Customer> row in customers)
            {
                Customer customer = row.Value;
                Console.WriteLine(customer.Name);
            }
        }

        public void PrintAllCustomers2()
        {
            foreach (Customer customer in customers.Values)
            {
                Console.WriteLine(customer.Name);
            }
        }

        public void PopulateCustomers()
        {
            Customer c1 = new Customer()
            {
                Id = 1,
                Name = "Oscar",
                Salary = 30000
            };
            Customer c2 = new Customer()
            {
                Id = 2,
                Name = "Rolando",
                Salary = 30000
            };
            Customer c3 = new Customer()
            {
                Id = 3,
                Name = "Romero",
                Salary = 30000
            };

            customers = new Dictionary<int, Customer>();
            customers.Add(c1.Id, c1);
            customers.Add(c2.Id, c2);
            customers.Add(c3.Id, c3);
        }
    }
}
