using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komutlar
{
    class falanfilan
    {
        public bool bolum { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // REVERSE
            int[] intArray = new int[] { 10, 30, 50, 40, 60, 20, 70, 100 };
            Console.WriteLine("Reverse'ten önce");
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            Console.WriteLine("Reverse'ten sonra");

            var ArrayReversedData = intArray.Reverse(); //diziyi ters çevirir
            foreach (var item in ArrayReversedData)
            {
                Console.WriteLine(item);
            }

            // EXCEPT
            Console.WriteLine("");
            string[] isim = { "Mahmut", "Arif", "Müslüm", "Müslüm" ,"Orhan","Ziya","Memati" };
            string[] cagrisim = { "Tuncer", "Manchester", "Gürses", "Orhan","Laz","Memati" };

            var fark = isim.Except(cagrisim);// isimde olan cagrisimda olmayan elemanları ayırır
            Console.WriteLine("Except: ");
            foreach (var item in fark)
            {
                Console.WriteLine(item);
            }

            // UNION
            Console.WriteLine("");
            var allResidents = isim.Union(cagrisim); // dizileri tekrar eden elemanları 1 tane olacak şekilde birleştirir
            Console.WriteLine("Union: ");
            foreach (var item in allResidents)
            {
                Console.WriteLine(item);
            }

            // CONCAT
            Console.WriteLine("");
            var allConcat = isim.Concat(cagrisim); // dizileri tekrar gözetmeksizin birleştirir
            Console.WriteLine("Concat: ");
            foreach (var item in allConcat)
            {
                Console.WriteLine(item);
            }

            // INTERSECT
            Console.WriteLine("");
            var allIntersect = isim.Intersect(cagrisim); // Sadece kesişenleri alır
            Console.WriteLine("Intersect: ");
            foreach (var item in allIntersect)
            {
                Console.WriteLine(item);
            }

            // DISTINCT
            Console.WriteLine("");
            var allDistinct = isim.Distinct(); // Tekrar edenleri çıkarır
            Console.WriteLine("Distinct: ");
            foreach (var item in allDistinct)
            {
                Console.WriteLine(item);
            }

            // ALL
            Console.WriteLine("");


            bool dordebolum = intArray.All(x => x % 4 == 0); // Kondisyonu elemanların tamamı sağlarsa çalışır
            Console.WriteLine("Dörde bölüm: "+dordebolum);
            bool onabolum = intArray.All(x => x % 10 == 0);
            Console.WriteLine("Ona bölüm: " + onabolum);

            // ANY
            Console.WriteLine("");
            if(intArray.Any(x=>x<30)) // Kondisyonu elemanlardan birinin sağlaması yeterlidir
            {
                Console.WriteLine("30'dan küçük sayı vardır");
            }

            // CONTAINS
            Console.WriteLine("");
            var varmı= isim.Contains("Arif"); //Contains içermek demektir
            Console.WriteLine("Contains Arif: "+varmı);
            

            Console.ReadLine();
        }
    }
}
