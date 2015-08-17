using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Linq;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>(){
                new Employee(){
                    Id = 101,
                    Name = "Oscar Romero"
                },
                new Employee(){
                    Id = 102,
                    Name = "Alejandra Maria"
                },
                new Employee(){
                    Id = 103,
                    Name = "Pedro Rodriguez"
                },
            };

            Employee employee = employees.Find(emp => emp.Id == 102);
            Console.WriteLine(employee.Name);

            Console.ReadKey();
        }
    }

    class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
