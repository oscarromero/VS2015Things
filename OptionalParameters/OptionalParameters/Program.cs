using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddNumbers(10, 20, new object[]{10, 20, 30});
            AddNumbers(10, 20, 10, 20, 30);
            Console.ReadKey();
        }

        public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;

            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }

                Console.Write("Sum = {0}", result);
            }
        }

        public static void testOptionalParams()
        {
            AddNumbers2(1, 2);
        }

        public static int AddNumbers2(int firstNumber, int secondNumber, int thirdNumber = 0)
        {
            int result = firstNumber + secondNumber + thirdNumber;
            return result;
        }
    }
}
