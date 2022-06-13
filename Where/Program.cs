using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Where
{

    internal class Course
    {
        public int ID { get; set; }
        public int Rank { get; set; }
        public string Subject { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();
            courses.Add(new Course
            {
                ID=1,
                Subject="LINQ Tutorials",
                Rank=5
            });

            courses.Add(new Course
            {
                ID = 2,
                Subject = ".NET Tutorials",
                Rank = 5
            });

            courses.Add(new Course
            {
                ID = 3,
                Subject = "Learn WPF",
                Rank = 3
            });

            // QUERY SYNTAX
            var result = from x in courses
                         where x.Rank > 3 && x.Subject.Contains("Tutorials")
                         // Rank'ı 3'ten büyük olanlar ve "Tutorials" içerenler bulundu
                         select x;
            //Rank'ı 3'ten büyük olan olanlar seçildi

            foreach (var y in result)
            {
                Console.WriteLine(y.Subject+ " ----with QUERY SYNTAX");
            }
            // Seçilen her değerin Subject'i ekrana yazdırıldı


            //METHOD SYNTAX
            var result2 = courses.Where(x => x.Rank < 4 && x.Subject.Contains("Learn"));
            foreach (var y in result2)
            {
                Console.WriteLine(y.Subject+ " ----with METHOD SYNTAX");
            }


            Console.ReadLine();
        }
    }
}
