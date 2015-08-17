using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSelectManyOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> subjects = Student.GetAllStudents().SelectMany(s => s.Subjects);
            foreach (string subject in subjects)
            {
                Console.WriteLine(subject);
            }

            // With LINQ
            IEnumerable<string> subjects2 = from student in Student.GetAllStudents()
                                            from subject in student.Subjects
                                            select subject;
            foreach (string subject2 in subjects2)
            {
                Console.WriteLine(subject2);
            }

            Console.ReadKey();
        }
    }
}
