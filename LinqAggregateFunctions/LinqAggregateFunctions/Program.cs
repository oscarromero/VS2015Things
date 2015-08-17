using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAggregateFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 3 without LINQ
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int? result = null;

            foreach (int i in Numbers) // Find the less even number
            {
                if (i % 2 == 0)
                {
                    if (!result.HasValue || i > result)//if (!result.HasValue || i < result)
                    {
                        result = i;
                    }
                }
            }
            Console.WriteLine(result);

            // Example 3 using LINQ
            //result = Numbers.Min();
            //result = Numbers.Where(n => n % 2 == 0).Min();

            //result = Numbers.Max();
            //result = Numbers.Where(n => n % 2 == 0).Max();

            //result = Numbers.Sum();
            //result = Numbers.Where(n => n % 2 == 0).Sum();

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
