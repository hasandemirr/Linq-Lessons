using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                ID = 1,
                Name = "Faruk"
            });

            students.Add(new Student
            {
                ID = 2,
                Name = "Ömer"
            });

            students.Add(new Student
            {
                ID = 3,
                Name = "Kamer"
            });


            //QUERY SYNTAX

            var result = from s in students //Result isimli, student list'inde bir var oluşturuldu
                         where s.Name.Contains("F") //içerisinde "F" içerenler arandı
                         select s.Name; // bunlar seçildi
            
            Console.WriteLine(result.First()); // Ekrana içeren ilk sonuç bastırıldı


            //METHOD SYNTAX

            var result2 = students.Where(x => x.Name.Contains("F")).Select(c => c.Name);
            // Query syntax'ındaki işlemler tek satırda yapıldı

            Console.WriteLine(result2.First());
            Console.ReadLine();


        }
    }
}
