using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            int oldValue = 0;
            int newValue = 0;
            program.outputParamsExample(1, out oldValue, out newValue);

            Console.WriteLine("The out oldValue is {0}", oldValue);
            Console.WriteLine("The out newValue is {0}", newValue);
            Console.ReadKey();
        }

        public void outputParamsExample(int aNumber, out int aOldNumber, out int aNewNumber)
        {
            aOldNumber = aNumber;
            aNewNumber = ++aNumber;
        }
    }
}
