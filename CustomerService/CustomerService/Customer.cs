using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    public class Customer
    {
        private int _Id;
        private string _Name;
        private string _Email;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
    }
}
