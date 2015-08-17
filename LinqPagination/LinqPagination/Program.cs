using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPagination
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                IEnumerable<Student> students = Student.GetAllStudetns();

                Console.WriteLine("Please enter page number:");

                int PageNumber = 0;
                int PageSize = 3;

                if (int.TryParse(Console.ReadLine(), out PageNumber))
                {
                    if (PageNumber >= 1 && PageNumber <= 4)
                    {
                        IEnumerable<Student> PageResult = students.Skip((PageNumber - 1) * PageSize).Take(PageSize);

                        Console.WriteLine("\nDisplaying page " + PageNumber);
                        foreach (Student student in PageResult)
                        {
                            Console.WriteLine(student.StudentID + "\t" + student.Name + "\t" + student.TotalMarks);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Page must be between 1 and 4!");
                    }
                }
                else
                {
                    Console.WriteLine("Page must be between 1 and 4!");
                }

            } while (1 == 1);
        }
    }
}
