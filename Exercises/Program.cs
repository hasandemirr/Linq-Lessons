using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //0-10 arası dizi oluşturun 2 ile bölünenleri yazdırın.

            Console.WriteLine("İki ile bölüm");
            int[] dizi1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var bolum0 = from x in dizi1 where (x % 2 == 0) select x;
            foreach (var item in bolum0)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("");

            //dizinin pozitif elemanlarını yazdırın.

            Console.WriteLine("Pozitif olanlar");
            int[] dizi2 = new int[10] { 0, 3,-8,-10,4,-5,5,-3,9,7};
            var pozitif = from x in dizi2 where (x> 0) select x;
            foreach (var item in pozitif)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");

            //dizinin elemanlarını ve karesini yazdırın.

            Console.WriteLine("Kendisi ve Karesi");
            int[] dizi3 = new int[10] { 0, 3, -8, -10, 4, -5, 5, -3, 9, 7 };
            var karesi = from x in dizi2 select x;
            foreach (var item in karesi)
            {
                Console.Write(item + " karesi = "+item*item+" || ");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            //Tekrar edenlerin tekrar sayısını yazdırın.

            Console.WriteLine("Tekrar Edenler");
            int[] dizi4 = new int[10] { 7, 3, 8, 8, 4, 5, 5, 5, 9, 7 };
            var tekrar = from x in dizi4
                         group x by x into y
                         select y;
            foreach (var item in tekrar)
            {
                Console.WriteLine(item.Key+", "+item.Count()+" adet var");
            }
            Console.WriteLine("");

            //consoldan girilen yazıda Tekrar edenlerin tekrar sayısını yazdırın.

            Console.WriteLine("Konsolda Tekrar Edenler");
            string ornek5;
            ornek5 = Console.ReadLine();
            var sıklık = from x in ornek5
                         group x by x into y
                         select y;
            foreach (var item in sıklık)
            {
                Console.WriteLine(item.Key + " karakteri "+item.Count() + " tane");
            }
            Console.WriteLine( "");
            Console.WriteLine("");

            //Haftanın günlerini yazdırın.

            Console.WriteLine("Haftanın Günleri");
            string[] ornek6 = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            var hafta = from x in ornek6 select x;
            foreach (var item in hafta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            //Tekrar eden sayıların toplamı
            int[] ornek7 = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            var OutputO7 = from x in ornek7
                           group x by x into y
                           select y;
            foreach (var item in OutputO7)
            {
                Console.WriteLine(item.Key + " " +item.Count()*+item.Key  +" " + item.Count());
            }
            Console.WriteLine("");

            //ilk ve son harflere göre şehirleri bulma

            Console.WriteLine("Şehirleri bulma");
            string[] ornek8 = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "ANKARA", "PARIS" };
            string start, end;
            Console.Write("İlk harfi giriniz ");
            start = Console.ReadLine();
            Console.Write("İlk harfi giriniz ");
            end = Console.ReadLine();

            var cities = from x in ornek8 
                         where x.StartsWith(start)
                         where x.EndsWith(end)
                         select x;
            foreach (var item in cities)
            {
                Console.WriteLine("{0} ile başlayan, {1} ile biten şehir: {2}",start,end,item);
            }
            Console.WriteLine("");

            


            Console.ReadLine();
        }
    }
}
