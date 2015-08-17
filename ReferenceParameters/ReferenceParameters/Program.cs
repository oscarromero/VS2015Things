using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Program referenceParamaters = new Program();
            
            int aNumber = 1;
            Console.WriteLine("The current value of aNumber is {0}", aNumber);

            referenceParamaters.increment(ref aNumber);

            Console.WriteLine("The new value of aNumber is {0}", aNumber);
            Console.ReadKey();
        }

        public void increment(ref int number)
        {
            number++;
        }
    }
}
