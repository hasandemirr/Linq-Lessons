using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komutlar2
{
    public class Student
    {
        public int ID { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
    }
    public class Employee
    {
        public int ID { get; set; }
        public List<Department> Departments { get; set; }

    }
    public class Department
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee
            {
                ID = 1,
                Departments = new List<Department>()
                {
                    new Department
                    {
                        Name="Marketing"
                    },
                    new Department
                    {
                        Name="Sales"
                    }
                }
            });
            employees.Add(new Employee
            {
                ID = 2,
                Departments = new List<Department>()
                {
                    new Department
                    {
                        Name="Advertisement"
                    },
                    new Department
                    {
                        Name="Production"
                    }
                }
            });
            employees.Add(new Employee
            {
                ID = 3,
                Departments = new List<Department>()
                {
                    new Department
                    {
                        Name="Production"
                    },
                    new Department
                    {
                        Name="Sales"
                    }
                }
            });

            // SELECTMANY
            var result = employees.SelectMany(x => x.Departments); // Her bir departmanı bir değişkende tuttu
            foreach (var x in result)
            {
                Console.WriteLine(x.Name);
            }
            Console.WriteLine("");


            //SUM MIN MAX AVERAGE COUNT AGGREGATE

            int[] intArray = new int[] { 10, 30, 50, 40, 60, 20, 70, 100 };


            int total = intArray.Sum(); //Diziyi toplar
            Console.WriteLine("Method Syntax ile Sayıların Toplamı: " + total);

            int total2 = (from a in intArray select a).Sum();
            Console.WriteLine("Query Syntax ile Sayıların Toplamı: " + total2);

            int max = intArray.Max(); //Maximum değeri alır
            Console.WriteLine("Sayıların MAX değeri: " + max);

            int min = intArray.Min(); //Minimum değeri alır
            Console.WriteLine("Sayıların MIN değeri: " + min);

            double avg = intArray.Average(); //Ortalama değeri alır
            Console.WriteLine("Sayıların ortalama değeri: " + avg);

            int elemansayisi = intArray.Count(); //eleman sayisini alır
            Console.WriteLine("Dizinin eleman sayısı: " + elemansayisi);

            string[] stringArray = new string[] { "C#NET", "MVC", "WCF", "SQL", "LINQ", "ASPNET" };
            var aggre = stringArray.Aggregate((x, y) => x + ", " + y); //Dzinin elemanlarını yazdırır
            Console.WriteLine("Dizinin tamamı: " + aggre);

            Console.WriteLine("");

            //GROUPBY

            List<Student> students = new List<Student>()
            {
                new Student {ID=1001, Name="Angela",Gender="Female",Branch="CSE",Age=20},
                new Student {ID=1002, Name="Mike",Gender="Male",Branch="ETC",Age=21},
                new Student {ID=1003, Name="Lecler",Gender="Male",Branch="CSE",Age=20},
                new Student {ID=1004, Name="Putin",Gender="Male",Branch="CSE",Age=21},
                new Student {ID=1005, Name="Billie",Gender="Female",Branch="CSE",Age=20},
                new Student {ID=1006, Name="Mia",Gender="Female",Branch="ETC",Age=19},
            };

            var sırala = students.GroupBy(x => x.Branch);//Branch'â göre method syntax ile gruplandı
            foreach (var x in sırala)
            {
                Console.WriteLine(x.Key + " : " + x.Count()); //x.Key komutu gruplama key'ini veriyor
                foreach (var y in x)
                {
                    Console.WriteLine("Name: " + y.Name + ", Age:" + y.Age + ", Gender:" + y.Gender);
                    // Gruplama key'ine göre bilgileri verdi 
                }
            }

            var sırala2 = from x in students group x by x.Age; //Age'e göre query syntax ile gruplandı
            foreach (var item in sırala2)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine("");

            //GROUPBY MULTIPLE

            var multiple = students.GroupBy(x => new { x.Branch, x.Gender }).OrderByDescending(y => y.Key.Branch).ThenBy(y => y.Key.Gender).Select(y => new
            {
                branch = y.Key.Branch,
                gender = y.Key.Gender,
                students = y.OrderBy(x => x.Name)
            }
            );

            foreach (var group in multiple)
            {
                Console.WriteLine("Branch: " + group.branch + " Gender: " + group.gender);
                foreach (var item in group.students)
                {
                    Console.WriteLine("ID: " + item.ID + " Name: " + item.Name + " Age: " + item.Age);
                }
            }

            Console.ReadLine();
        }
    }
}
