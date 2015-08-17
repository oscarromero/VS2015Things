using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            String strNumber = number.ToString(); 
            Console.WriteLine(strNumber);

            Customer c1 = new Customer();
            c1.firstName = "Oscar";
            c1.lastName = "Romero";

            Console.WriteLine(c1.ToString());

            Console.ReadKey();
        }
    }

    class Customer
    {
        public String firstName { get; set; }
        public String lastName { get; set; }

        public override string ToString()
        {
            return firstName + " " + lastName;
            //return base.ToString();
        }
    }
}
