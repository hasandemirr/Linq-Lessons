using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iquerable_Ienumarable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            //IEnumerable<int> QuerySyntax = from obj in integerList where obj > 5 select obj;
            IQueryable<int> QuerySyntax = from obj in integerList.AsQueryable() where obj > 5 select obj;

            //var QuerySyntax =from obj 
            //                 in integerList 
            //                 where obj>5 
            //                 select obj;

            foreach (var item in QuerySyntax)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
