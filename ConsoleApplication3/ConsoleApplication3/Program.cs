using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumbers = { 1, 2, 3, 4 };
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                Console.WriteLine("Number in position {0} is {1}", i, arrNumbers[i]);
            }

            Console.ReadKey();
        }
    }
}
