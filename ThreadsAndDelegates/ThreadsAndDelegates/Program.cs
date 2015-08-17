using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadsAndDelegates
{
    public delegate void SumOfNumbersDelegate(int sum);

    class Program
    {
        public static void PrintSumOfNumbers(int sum)
        {
            Console.WriteLine("The sum of the numbers is {0}", sum);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please, set a limit for the sum");
            int limit = Convert.ToInt32(Console.ReadLine());

            SumOfNumbersDelegate callback = new SumOfNumbersDelegate(PrintSumOfNumbers);

            Numbers numbers = new Numbers(limit, callback);
            Thread t1 = new Thread(new ThreadStart(numbers.SumNumbers));
            t1.Start();

            Console.ReadKey();
        }
    }

    class Numbers
    {
        private int _limit = 0;
        private SumOfNumbersDelegate _callback;

        public Numbers(int limit, SumOfNumbersDelegate callback)
        {
            _limit = limit;
            _callback = callback;
        }

        public void SumNumbers()
        {
            int sum = 0;
            for (int i = 0; i < _limit; i++)
            {
                sum += i;
            }

            if (_callback != null)
                _callback(sum);
        }
    }
}
