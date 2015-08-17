using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupJoin
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int DepartmentID { get; set; }
        public int Salary { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>
            {
                new Employee {ID = 1, Name = "Mark", Gender = "Male", DepartmentID = 1, Salary = 45000},
                new Employee {ID = 2, Name = "Steve", Gender = "Male", DepartmentID = 2, Salary = 55000},
                new Employee {ID = 3, Name = "Ben", Gender = "Male", DepartmentID = 3, Salary = 65000},
                new Employee {ID = 4, Name = "Philip", Gender = "Male", DepartmentID = 4, Salary = 55000},
                new Employee {ID = 5, Name = "Mary", Gender = "Female", DepartmentID = 1, Salary = 45000},
                new Employee {ID = 6, Name = "Valerie", Gender = "Female", DepartmentID = 1, Salary = 45000},
                new Employee {ID = 7, Name = "John", Gender = "Male", DepartmentID = 2, Salary = 55000},
                new Employee {ID = 8, Name = "Pam", Gender = "Female", DepartmentID = 4, Salary = 65000},
                new Employee {ID = 9, Name = "Stacey", Gender = "Female", DepartmentID = 3, Salary = 65000},
                new Employee {ID = 10, Name = "Andy", Gender = "Male", DepartmentID = 1, Salary = 45000},
            };
        }
    }
}
