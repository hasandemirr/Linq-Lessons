using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_4
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
    }
    public class Purchase
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int PurQty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Kartezyen Liste

            Console.WriteLine("Kartezyen Liste");
            char[] ornek1char = { 'x', 'y', 'z' };
            int[] ornek1int = { 1, 2, 3 };
            string[] ornek1string = { "green", "orange" };

            var cozum = from Letter in ornek1char
                        from Number in ornek1int
                        from Colour in ornek1string
                        select new { Letter, Number,Colour };
            foreach (var item in cozum)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");


            // İki listeyi joinleme
            Console.WriteLine("İki listeyi joinleme");
            List<Item> itemlist = new List<Item>
            {
                new Item {ItemId=1,ItemName="Bisküvi "},
                new Item {ItemId=2,ItemName="Çikolata"},
                new Item {ItemId=3,ItemName="Dondurma"},
                new Item {ItemId=4,ItemName="Gofret  "},
                new Item {ItemId=5,ItemName="Kek     "}
            };
            List<Purchase> purchaselist = new List<Purchase>
            {
                new Purchase{Id=100,ItemId=3,PurQty=800},
                new Purchase{Id=101,ItemId=2,PurQty=650},
                new Purchase{Id=102,ItemId=3,PurQty=900},
                new Purchase{Id=103,ItemId=4,PurQty=700},
                new Purchase{Id=104,ItemId=3,PurQty=900},
                new Purchase{Id=105,ItemId=4,PurQty=650},
                new Purchase{Id=106,ItemId=1,PurQty=458},
            };

            var ornek2 = (from x in itemlist
                         join y in purchaselist on x.ItemId equals y.ItemId
                         select new
                         {
                             ItemId = x.ItemId,
                             ItemName = x.ItemName,
                             PurchaseQuantity = y.PurQty
                         });
            foreach (var item in ornek2)
            {
                Console.WriteLine(item.ItemId+"\t"+item.ItemName+"\t"+item.PurchaseQuantity);
            }
            Console.WriteLine("");


            // İki listeyi left joinleme
            Console.WriteLine("İki listeyi Left joinleme");
            var ornek3 = (from x in itemlist
                          join y in purchaselist on x.ItemId equals y.ItemId
                          into z from q in z.DefaultIfEmpty( new Purchase())
                          // Z'yi sola yasladık eğer boş eleman dönerse 0 atayacak
                          select new
                          {
                              ItemId = x.ItemId,
                              ItemName = x.ItemName,
                              PurchaseQuantity = q.PurQty
                          });
            foreach (var item in ornek3)
            {
                Console.WriteLine(item.ItemId + "\t" + item.ItemName + "\t" + item.PurchaseQuantity);
            }
            Console.WriteLine("");


            // İki listeyi right joinleme
            Console.WriteLine("İki listeyi Right joinleme");
            var ornek4 = (from p in purchaselist
                          join i in itemlist on p.ItemId equals i.ItemId
                          into x
                          from y in x.DefaultIfEmpty()
                          select new
                          {
                              ItemId = y.ItemId,
                              ItemName = y.ItemName,
                              PurchaseQuantity = p.PurQty
                          });
            foreach (var item in ornek4)
            {
                Console.WriteLine(item.ItemId + "\t" + item.ItemName + "\t" + item.PurchaseQuantity);
            }
            Console.WriteLine("");




            Console.ReadLine();
        }
    }
}
