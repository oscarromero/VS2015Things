using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection
{
    class SortByName : IComparer<Customer>
    {
        public int Compare(Customer c1, Customer c2)
        {
            return c1.Name.CompareTo(c2.Name);
        }
    }

    class Customer : IComparable<Customer>
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public int Salary {get; set;}

        public int CompareTo(Customer customer)
        {
            return this.Salary.CompareTo(customer.Salary);
            //if (this.Salary > customer.Salary)
            //    return 1;
            //else if (this.Salary < customer.Salary)
            //    return -1;
            //else
            //    return 0;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(){
                Id = 1,
                Name = "Oscar",
                Salary = 30000
            };
            Customer c2 = new Customer(){
                Id = 2,
                Name = "Rolando",
                Salary = 40000
            };
            Customer c3 = new Customer(){
                Id = 3,
                Name = "Romero",
                Salary = 50000
            };

            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

            if (customers.Contains(c3))
            {
                Console.WriteLine("Customer3 Exists!");
            }
            else
            {
                Console.WriteLine("Customer 3 does not exists!");
            }

            if (customers.Exists(cust => cust.Name.StartsWith("O"))) {
                Console.WriteLine("Customer 'O' exists");
            }

            Comparison<Customer> customerComparer = new Comparison<Customer>(CustomerComparer);
            customers.Sort(customerComparer);
        }

        public static int CustomerComparer(Customer c1, Customer c2)
        {
            return c1.Id.CompareTo(c2.Id);
        }
    }
}
