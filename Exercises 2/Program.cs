using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listede 80'den büyük olanları yazdır

            Console.WriteLine("80'den büyük olanlar");
            List<int> ornek1 = new List<int>();
            ornek1.Add(55);
            ornek1.Add(89);
            ornek1.Add(21);
            ornek1.Add(17);
            ornek1.Add(34);
            ornek1.Add(41);
            ornek1.Add(72);
            ornek1.Add(90);
            var cozum1=ornek1.FindAll(x => x > 80 ? true : false);
            foreach (var item in cozum1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            //istenilen değerden büyük olanlar

            Console.WriteLine("İstenilen Değerden Büyük Olanlar");
            int girilendeger,elemansayisi;
            Console.WriteLine("Dizi eleman sayısını giriniz.");
            elemansayisi = Convert.ToInt32(Console.ReadLine());
            List<int> ornek2 = new List<int>();
            for (int i = 1; i <= elemansayisi; i++)
            {
                Console.WriteLine("Dizinin {0}. elamanı: ", i);
                girilendeger= Convert.ToInt32(Console.ReadLine());
                ornek2.Add(girilendeger);
            }
            Console.WriteLine("Listelemek için değer giriniz ");
            girilendeger = Convert.ToInt32(Console.ReadLine());
            var cozum2 = ornek2.Where(x => x > girilendeger);
            Console.Write("{0} değerinden büyük olanlar: ",girilendeger);
            foreach (var item in cozum2)
            {
                Console.Write(" "+item); ;
            }
            Console.WriteLine();

            //En yüksek 3 değeri ekrana yazdırma

            Console.WriteLine("En yüksek 3 değeri ekrana yazdırma");
            ornek1.Sort();
            ornek1.Reverse();
            foreach (var item in ornek1.Take(3))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Büyük harfleri yazdırma

            Console.WriteLine("Büyük harfleri yazdırma");
            string cumle;
            cumle = Console.ReadLine();
            var cozum4 = cumle.Split(' ').Where(x => string.Equals(x, x.ToUpper()));
            //Split metodu istenilen değeri diziden ayırır
            Console.WriteLine("Büyük olanlar: ");
            foreach (var item in cozum4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Dizileri Birleştirme

            Console.WriteLine("Dizileri Birleştirme");
            string[] ornek5;
            int n;
            Console.WriteLine("Dizi kaç elemandan oluşsun?");
            n = Convert.ToInt32(Console.ReadLine());
            ornek5 = new string[n];

            for (int i =0; i < n; i++)
            {
                Console.WriteLine("{0}. elaman: ", i+1);
                ornek5[i] = Console.ReadLine();
            }
            string newstring = string.Join(", ", ornek5.Select(x => x.ToString()));
            Console.WriteLine(newstring);

            Console.ReadLine();
        }

        

    }
}
