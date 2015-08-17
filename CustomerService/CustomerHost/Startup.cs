using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;

namespace CustomerHost
{
    class Startup
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(CustomerService.CustomerService)))
            {
                host.Open();

                Console.WriteLine("Customer Service Started " + DateTime.Now.ToShortDateString());
                Console.ReadLine();
            }
        }
    }
}
