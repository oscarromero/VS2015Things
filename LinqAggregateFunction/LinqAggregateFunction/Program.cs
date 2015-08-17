using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAggregateFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Countries = { "Honduras", "Francia", "Dinamarca", "Canada", "Suiza", "Belgica", "Holanda", "Austria" };

            string result = string.Empty;

            // Without LINQ
            foreach (string country in Countries)
            {
                result = result + country + ", ";
            }
            int lastIndex = result.LastIndexOf(",");
            result = result.Remove(lastIndex);

            Console.WriteLine(result);

            // With LINQ
            result = Countries.Aggregate((a, b) => a + ", " + b);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
