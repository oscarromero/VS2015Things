using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperators
{
    class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Name = "Oscar Romero",
                    Gender = "Male",
                    Subjects = new List<string>
                    {
                        "Programming",
                        "Accounting",
                        "Finance"
                    }
                },
                new Student
                {
                    Name = "Alejandra Escalante",
                    Gender = "Female",
                    Subjects = new List<string>
                    {
                        "Architecture",
                        "Design",
                        "Calculus"
                    }
                },
                new Student
                {
                    Name = "Jonh Blogs",
                    Gender = "Male",
                    Subjects = new List<string>
                    {
                        "Networks",
                        "Math",
                        "Dansk"
                    }
                },
            };

            return students;
        }
    }
}
