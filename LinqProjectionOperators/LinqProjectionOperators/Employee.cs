using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProjectionOperators
{
    class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int AnualSalary { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    ID = 101,
                    FirstName = "Oscar",
                    LastName = "Romero",
                    Gender = "Male",
                    AnualSalary = 1000000
                },
                new Employee
                {
                    ID = 102,
                    FirstName = "Juan",
                    LastName = "Camaney",
                    Gender = "Male",
                    AnualSalary = 100000
                },
                new Employee
                {
                    ID = 103,
                    FirstName = "Alejandra",
                    LastName = "Escalante",
                    Gender = "Female",
                    AnualSalary = 2000000
                },
                new Employee
                {
                    ID = 104,
                    FirstName = "Enrique",
                    LastName = "Fuentes",
                    Gender = "Male",
                    AnualSalary = 3000000
                },
            };

            return employees;
        }
    }
}
