using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class GradeBookTest
    {

        static void Main(string[] args)
        {
            GradeBook myGradeBook = new GradeBook();

            Console.WriteLine("Initial course name is: '{0}'\n", myGradeBook.CourseName);
            Console.WriteLine("Please enter the course name:");
            myGradeBook.CourseName = Console.ReadLine();
            Console.WriteLine("Initial instructor of the course is: '{0}'\n", myGradeBook.InstructorName);
            Console.WriteLine("Please enter the instructor's name for the course:");
            myGradeBook.InstructorName = Console.ReadLine();
            Console.WriteLine();

            myGradeBook.DisplayMessage();
        }
    }
}
