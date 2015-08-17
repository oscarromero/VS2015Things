using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        private int id
        {
            get;
            set;
        }

        private struct area{
            int x;
            int y;
        };

        static void Main(string[] args)
        {
            Program program = new Program();
            program.id = 1;

            Console.WriteLine("{0}", program.id);
            Console.ReadKey();
        }
    }
}
