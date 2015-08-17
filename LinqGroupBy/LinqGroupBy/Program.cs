using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupBy
{
    class Program
    {
        static void Main(string[] args)
        {           
            var employeeGroups = Employee.GetAllEmployees().GroupBy(x => x.Department);

            foreach (var group in employeeGroups)
            {
                Console.WriteLine("{0} - {1}", group.Key, group.Count());
            }

            Console.WriteLine("\nWith Linq like SQL\n");

            // Linq like SQL
            var employeeGroups2 = from employee in Employee.GetAllEmployees()
                                  group employee by employee.Department;

            foreach (var group in employeeGroups2)
            {
                Console.WriteLine("{0} - {1}", group.Key, group.Count());
            }

            Console.WriteLine("\nWith Linq like SQL group and sort\n");

            // Group by department and sort each employee by name
            var employeeGroups3 = from employee in Employee.GetAllEmployees()
                                  group employee by employee.Department into eGroup
                                  orderby eGroup.Key
                                  select new {
                                    Key = eGroup.Key,
                                    Employees = eGroup.OrderBy(d => d.Department)
                                  };
            foreach (var department in employeeGroups3)
            {
                Console.WriteLine("{0} - {1}", department.Key, department.Employees.Count());
                Console.WriteLine("------------");
                foreach (var employee in department.Employees)
                {
                    Console.WriteLine("{0} \t {1}", employee.Name, employee.Department);
                }
                Console.WriteLine("\n\n");
            }

            Console.ReadKey();
        }
    }
}
