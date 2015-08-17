using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student names before sorting");

            List<Student> students = Student.GetAllStudents();
            foreach(Student student in students)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("\nStudent names after sorting\n");

            IEnumerable<Student> sortedStudents = Student.GetAllStudents().OrderBy(s => s.Name);
            foreach (Student student in sortedStudents)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("\nStudent names after sorting\n");

            // LINQ SQL Like Syntax
            IEnumerable<Student> sortedStudents2 = from student in Student.GetAllStudents()
                                                   orderby student.Name
                                                   select student;
            foreach (Student student in sortedStudents2)
            {
                Console.WriteLine(student.Name);
            }

            Console.ReadKey();
        }
    }
}
