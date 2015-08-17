using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ extension method syntax
            //var employeesByDepartment = Department.GetAllDepartments()
            //                                      .GroupJoin(Employee.GetAllEmployees(),
            //                                                 d => d.ID, 
            //                                                 e => e.DepartmentID,
            //                                                 (department, employees) => new
            //                                                 {
            //                                                     Department = department,
            //                                                     Employees = employees
            //                                                 });

            // LINQ SQL Like Syntax
            var employeesByDepartment = from department in Department.GetAllDepartments()
                                       join employee in Employee.GetAllEmployees()
                                       on department.ID equals employee.DepartmentID into eGroup
                                       select new { 
                                           Department = department,
                                           Employees = eGroup
                                       };

            foreach (var department in employeesByDepartment)
            {
                Console.WriteLine(department.Department.Name);

                foreach (var employee in department.Employees)
                {
                    Console.WriteLine(" " + employee.Name);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
