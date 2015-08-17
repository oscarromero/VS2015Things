using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqInnerJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ Extension Methods
            //var result = Employee.GetAllEmployees().Join(
            //    Department.GetAllDepartments(), 
            //    e => e.DepartmentID, 
            //    d => d.ID,
            //    (employee, department) => new
            //    {
            //        EmployeeName = employee.Name,
            //        DepartmentName = department.Name
            //    });

            // LINQ Like SQL
            var result = from employee in Employee.GetAllEmployees() 
                         join department in Department.GetAllDepartments()
                         on employee.DepartmentID equals department.ID
                         select new
                         {
                             EmployeeName = employee.Name,
                             DepartmentName = department.Name
                         };

            foreach (var employee in result)
            {
                Console.WriteLine(employee.EmployeeName + "\t" + employee.DepartmentName);
            }
        }
    }
}
