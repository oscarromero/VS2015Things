using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            // Way 1
            Thread t1 = new Thread(new ThreadStart(Numbers.printNumbers));

            // Way 2
            Thread t2 = new Thread( delegate() { Numbers.printNumbers();} );

            // Way 3
            Thread t3 = new Thread(() => Numbers.printNumbers() );

            t1.Start();

            // ParameterizedThreadStart way
            Console.Write("Please, Enter the target numbers");
            object target = Console.ReadLine();

            Numbers number = new Numbers();
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(number.printNumbers3);
            Thread t4 = new Thread(parameterizedThreadStart);
            t4.Start(target);

            Console.ReadKey();
        }
    }

    class Numbers
    {
        public static void printNumbers()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void printNumbers2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void printNumbers3(object target)
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
