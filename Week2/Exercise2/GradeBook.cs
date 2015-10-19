using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise2
{
    public class GradeBook
    {
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
        public GradeBook(string courseName, string instructorName)
        {
            CourseName = courseName;
        }

        public GradeBook()
        {
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the grade book for\n{0}", CourseName);
            Console.WriteLine("This course is presented by: {0}", InstructorName);
        }
    }
}