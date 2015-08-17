using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProjectionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> result1 = Employee.GetAllEmployees().Select(emp => emp.ID);
            foreach (int id in result1)
            {
                Console.WriteLine(id);
            }

            Console.WriteLine("--------");

            var result2 = Employee.GetAllEmployees().Select(emp => new { ID = emp.ID, FirstName = emp.FirstName });
            foreach (var employee in result2)
            {
                Console.WriteLine(employee.ID + " " + employee.FirstName);
            }

            Console.ReadKey();
        }
    }
}
