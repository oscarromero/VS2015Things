using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Company company = new Company();
            Console.WriteLine(company[0]);
            Console.ReadKey();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee { Id = 1, Name = "Oscar", Gender = "Male" });
            listEmployees.Add(new Employee { Id = 1, Name = "Maria", Gender = "Female" });
            listEmployees.Add(new Employee { Id = 1, Name = "Alejandra", Gender = "Female" });
            listEmployees.Add(new Employee { Id = 1, Name = "Juan", Gender = "Male" });
        }

        public string this[int employeeId]
        {
            get
            {
                Employee employee = listEmployees.FirstOrDefault(emp => emp.Id == employeeId);
                if (employee == null) {
                    return "Unknown";
                }

                return employee.Name; 
            }
            set 
            {
                listEmployees.FirstOrDefault(emp => emp.Id == employeeId).Name = value;
            }
        }
    }
}
