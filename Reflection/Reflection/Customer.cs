using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Customer
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public Customer()
        {
            Id = 0;
            Name = "";
        }

        public Customer(int Id, String Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
