using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffType
{
    abstract class Course
    {
        public int ID { get; set; }
        public int Rank { get; set; }

        public string Subject { get; set; }

    }
    internal class FreeCourse: Course
    {

    }
    internal class PaidCourse:Course
    {
        public decimal Fees { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();
            courses.Add(new FreeCourse
            {
                ID = 1,
                Subject = "LINQ Tutorials",
                Rank = 5
            });

            courses.Add(new FreeCourse
            {
                ID = 2,
                Subject = ".NET Tutorials",
                Rank = 4
            });

            courses.Add(new PaidCourse
            {
                ID = 3,
                Subject = "Learn WPF",
                Rank = 3
            });

            courses.Add(new PaidCourse
            {
                ID = 4,
                Subject = "DataGrid Tutorials",
                Rank = 3
            });

            var paidCourses = from course in courses.OfType<PaidCourse>()
                              select course;
            var freeCourses = from course in courses.OfType<FreeCourse>()
                              select course;

            foreach (var x in paidCourses)
            {
                Console.WriteLine(x.Subject+" --- Paid Courses");
            }
            foreach (var x in freeCourses)
            {
                Console.WriteLine(x.Subject+" --- Free Courses");
            }
            Console.ReadLine();
        }
    }
}
