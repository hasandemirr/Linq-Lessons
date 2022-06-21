using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_3
{
    public class Students
    {
        public int ID { get; set; }
        public int Points { get; set; }
        public string Name { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            // Öğrenci sıralama

            Console.WriteLine("Öğrenci Sıralama");
            List<Students> ogrenciler = new List<Students>();
            ogrenciler.Add(new Students { ID = 1, Name = "Hasan", Points = 55 });
            ogrenciler.Add(new Students { ID = 2, Name = "Furkan", Points = 85 });
            ogrenciler.Add(new Students { ID = 3, Name = "Ali", Points = 95 });
            ogrenciler.Add(new Students { ID = 4, Name = "Veli", Points = 35 });
            ogrenciler.Add(new Students { ID = 5, Name = "Namık", Points = 45 });
            ogrenciler.Add(new Students { ID = 6, Name = "Faruk", Points = 65 });
            ogrenciler.Add(new Students { ID = 7, Name = "Süleyman", Points = 70 });

            Console.WriteLine("Kaçıncı öğrenciyi görmek istiyorsunuz?");
            int kacinci;
            kacinci = Convert.ToInt32(Console.ReadLine());

            var ornek1 = (from x in ogrenciler
                          group x by x.Points
                       into y
                          orderby y.Key descending
                          select new
                          {
                              kayit = y.ToList()
                          }).ToList();
            ornek1[kacinci - 1].kayit.ForEach(i => Console.WriteLine("ID:{0}, Name:{1}, Points:{2}", i.ID, i.Name, i.Points));
            Console.WriteLine("");


            // Öğrenci sıralama

            Console.WriteLine("İsme Göre Sıralama");
            var ornek2 = (from x in ogrenciler select x.Name).Distinct().OrderBy(x => x);
            foreach (var item in ornek2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");


            // Dosya Uzantısı Bulma

            Console.WriteLine("Dosya Uzantısı Bulma");
            string[] ornek3 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml" };
            var cozum3 = ornek3.Select(x => Path.GetExtension(x).TrimStart('.').ToLower())
                // TrimStart komutu istenilen karakterden sonrasını alır
                .GroupBy(y => y, (extension, count) => new
                {
                    Extension = extension,
                    Count = count.Count()
                }
                );
            foreach (var item in cozum3)
            {
                Console.WriteLine("{0} dosyam, {1} kadar bulunur", item.Extension, item.Count);
            }
            Console.WriteLine("");


            // Diziden Çıkarma Yaparak Yeni Dizi Oluşturma

            Console.WriteLine("Diziden Çıkarma Yaparak Yeni Dizi Oluşturma");
            List<string> ornek4 = new List<string>();
            ornek4.Add("m");
            ornek4.Add("n");
            ornek4.Add("o");
            ornek4.Add("p");
            ornek4.Add("q");

            var cozum4 = from x in ornek4 select x;
            foreach (var item in cozum4)
            {
                Console.WriteLine("Char: {0}", item);
            }
            Console.WriteLine("Hangi karakter çıkarılsın?");
            string hngkrktr;
            hngkrktr = Console.ReadLine();
            ornek4.RemoveAll(x => x == hngkrktr);
            // RemoveAll komutu listeden eleman çıkarır
            var cozum4dot2 = from x in ornek4 select x;
            Console.WriteLine("Yeni liste");
            foreach (var item in cozum4)
            {
                Console.WriteLine("Char: {0}", item);
            }
            Console.WriteLine("");


            // Minimum Karakter sayısına göre ekrana bastırma

            Console.WriteLine("Minimum Karakter sayısına göre ekrana bastırma");
            Console.WriteLine("Dizi kaç elemandan oluşsun?");
            int kceleman = Convert.ToInt32(Console.ReadLine());
            string[] ornek5;
            ornek5 = new string[kceleman];
            for (int i = 0; i < kceleman; i++)
            {
                Console.WriteLine("Elaman[{0}]", i + 1);
                ornek5[i] = Console.ReadLine();
            }
            Console.WriteLine("Minimum karakter sayısını giriniz");
            int minkrktr = Convert.ToInt32(Console.ReadLine());

            var cozum5 = from x in ornek5 where x.Length >= minkrktr orderby x select x;
            foreach (var item in cozum5)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
