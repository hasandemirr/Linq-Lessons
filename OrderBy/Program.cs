using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBy
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Rank { get; set; }


    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                ID = 1,
                Name = "Faruk",
                Age=37,
                Rank=1
            });

            students.Add(new Student
            {
                ID = 2,
                Name = "Ömer",
                Age=25,
                Rank =1
            });

            students.Add(new Student
            {
                ID = 3,
                Name = "Kamer",
                Age=23,
                Rank =2
            });

            var studentsOrderById = from s in students
                                    orderby s.ID //ID numaralarına göre sıralar
                                    select s;

            var studentsOrderByIdMethod = students.OrderByDescending(x => x.ID);// ID numaralarını azalana göre sıralar

            Console.WriteLine("Sorted by Students ID: ");
            foreach (var s in studentsOrderById)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine("");
            Console.WriteLine("Sorted by Students ID Descending: ");
            foreach (var s in studentsOrderByIdMethod)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine("");
            Console.WriteLine("Sorted by Students Rank and Age with Query: ");
            var orderByRankAgeQuery = from s in students orderby s.Rank, s.Age select s;
            foreach (var s in orderByRankAgeQuery)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine("");
            Console.WriteLine("Sorted by Students Rank and Age with Method: ");
            var orderByRankMethod = students.OrderBy(x =>x.Rank).ThenBy(x => x.Age);
            foreach (var s in orderByRankMethod)
            {
                Console.WriteLine(s.Name);
            }

            Console.ReadLine();
        }
    }
}
