using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komutlar3
{
    public class Numbers
    {
        public int Points { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> numbers2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("ELEMENTAT ELEMENTATDEFAULT");
            // ELEMENTAT ELEMENTATDEFAULT
            var x = numbers.ElementAt(1);//Dizinin "1" indexli değerini verir
            Console.WriteLine(x);
            Console.WriteLine("");
            var y = numbers.ElementAtOrDefault(15);
            //Dizinin "15" indexli değerini verir eğer değer yoksa int'in default değerini verir
            Console.WriteLine(y);
            Console.WriteLine("");

            Console.WriteLine("FIRST FIRSTORDEFAULT");
            //FIRST FIRSTORDEFAULT
            var z = numbers.First(aa => aa % 4 == 0); //Dizinin 4'e tam bölünebilen ilk elemanını alır
            Console.WriteLine(z);
            Console.WriteLine("");
            var zdef = numbers.FirstOrDefault(aa => aa > 50);
            //Dizinin 50'den büyük ilk değerini verir eğer değer yoksa int'in default değerini verir
            Console.WriteLine(zdef);
            Console.WriteLine("");

            Console.WriteLine("LAST LASTORDEFAULT");
            //LAST LASTORDEFAULT
            var u = numbers.Last(aa => aa % 4 == 0); //Dizinin 4'e tam bölünebilen son elemanını alır
            Console.WriteLine(u);
            Console.WriteLine("");
            var udef = numbers.FirstOrDefault(aa => aa < 50);
            //Dizinin 50'den küçük ilk değerini verir eğer değer yoksa int'in default değerini verir
            Console.WriteLine(udef);
            Console.WriteLine("");

            Console.WriteLine("SINGLE SINGLEORDEFAULT");
            //SINGLE SINGLEORDEFAULT
            var v = numbers.Single(aa => aa % 10 == 0); //Dizinin 10'a tam bölünebilen tek elemanını alır
            Console.WriteLine(v);
            Console.WriteLine("");
            var vdef = numbers.SingleOrDefault(aa => aa==15);
            //Dizinin 15'e eşit tek değerini verir eğer değer yoksa int'in default değerini verir
            Console.WriteLine(vdef);
            Console.WriteLine("");

            Console.WriteLine("DEFAULTEMPTY");
            //DEFAULTEMPTY
            var q = numbers.DefaultIfEmpty(88); //Dizinin içi boşsa default değeri 88 verir değilse diziyi verir
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");


            Console.WriteLine("SEQUENCEEQUAL");
            //SEQUENCEEQUAL
            bool sq = numbers.SequenceEqual(numbers2);//iki liste eşitse true döner
            Console.WriteLine(sq);
            Console.WriteLine("");


            Console.WriteLine("TAKE");
            //TAKE
            var tk = numbers.OrderByDescending(tkk=>tkk).Take(4);//İlk 4 elemanı alır
            foreach (var item in tk)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");


            Console.WriteLine("TAKEWHILE");
            //TAKEWHILE
            var tkw = numbers.TakeWhile((tkww=> tkww < 6));//kondisyon bozulana kadar tüm elemanları alır
            foreach (var item in tkw)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");


            Console.WriteLine("SKIP");
            //SKIP
            var s = numbers.Skip((8));//ilk 8 elemanı atlayarak tüm elemanları alır
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");


            Console.WriteLine("SKIPWHILE");
            //SKIPWHILE
            var sw = numbers.SkipWhile(sww=>sww<5);//5ten küçük elemanları atlayarak tüm elemanları alır
            foreach (var item in sw)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            Console.WriteLine("RANGE");
            //RANGE
            IEnumerable<int> numbers3 = Enumerable.Range(10, 15).Where(r=>r%3==0);
            //10-25 arasında 3e bölünebilen sayıları alır
            foreach (var item in numbers3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            Console.WriteLine("REPEAT");
            //REPEAT
            IEnumerable<string> rpt = Enumerable.Repeat("Deneme", 4);
            //Listeye Deneme elemanını 4 kere ekler
            foreach (var item in rpt)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            Console.WriteLine("ZIP");
            //ZIP
            var zıp = numbers3.Zip(rpt, (xzip, yzip) => xzip + " " + yzip);
            // numbers3 ve rpt dizisini eleman sırasına birleştirir
            foreach (var item in zıp)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            Console.WriteLine("TOLIST TOARRAY");
            //TOLIST TOARRAY
            int[] ArrayGroup = { 1, 2, 3, 4, 5 };
            List<int> newListGroup = ArrayGroup.ToList();
            //ArrayGroup dizisini bir listeye atadı
            int[] newArrayGroup = numbers.ToArray();
            //Numbers Listesini bir diziye atadı

            foreach (var item in newListGroup )
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            foreach (var item in newArrayGroup)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
