using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec10LINQjoin
{
    // A class that links an item name with its number.
    class Item
    {
        public string Name { get; set; }
        public int ItemNumber { get; set; }

        public Item(string n, int num)
        {
            Name = n;
            ItemNumber = num;
        }
    }

    // A clas that links an item number with its in-stock status.
    class InStockStatus
    {
        public int ItemNumber { get; set; }
        public bool InStock { get; set; }
        public InStockStatus(int n, bool s)
        {
            ItemNumber = n;
            InStock = s;
        }
    }

    // A class that encapsulates a name with its status.
    class Temp
    {
        public string Name { get; set; }
        public bool InStock { get; set; }
        public Temp(string n, bool s)
        {
            Name = n;
            InStock = s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Item[] items = {
                               new Item("Pliers", 1424),
                               new Item("Hammer", 7892),
                               new Item("Wrench", 8534),
                               new Item("Saw", 6411),
                           };
            InStockStatus[] statusList = {
                                             new InStockStatus(1424, true),
                                             new InStockStatus(7892, false),
                                             new InStockStatus(8534, true),
                                             new InStockStatus(6411, true)
                                         };

            // Create a query that joins Item with InStockStatus to
            // produce a list of item names and availablity.
            // Notice that a sequence of Temp Objects is produced.
            var inStockList = from item in items
                              join itemStatus in statusList
                              on item.ItemNumber equals itemStatus.ItemNumber
                              select new Temp(item.Name, itemStatus.InStock);
            Console.WriteLine("Item\tAvailable\n");
            foreach (Temp t in inStockList)
            {
                Console.WriteLine("{0}\t{1}", t.Name, t.InStock);
            }

            /* We can write the query without using any Temp class obj
            // We used anonumous class obj declaration like
            var inStockList2 = from item in items
                               join itemStatus in statusList
                               on item.ItemNumber equals itemStatus.ItemNumber
                               select new { MyName = item.Name, MyStatus = itemStatus.InStock };
            Console.WriteLine("Item\tAvailable\n");
            foreach (var t in inStockList2)
            {
                Console.WriteLine("{0}\t{1}", t.MyName, t.MyStatus);
            }

            var inStockList3 = from item in items
                               join itemStatus in statusList
                               on item.ItemNumber equals itemStatus.ItemNumber
                               select new {item.Name, itemStatus.InStock };
            Console.WriteLine("Item\tAvailable\n");
            foreach (var t in inStockList3)
            {
                Console.WriteLine("{0}\t{1}", t.Name, t.InStock);
            } */

            /* Use where Clause 
            var inStockList2 = from item in items
                               join itemStatus in statusList
                               on item.ItemNumber equals itemStatus.ItemNumber
                               where item.ItemNumber == 7892
                               select new { MyName = item.Name, MyStatus = itemStatus.InStock };
            Console.WriteLine("Item\tAvailable\n");
            foreach (var t in inStockList2)
            {
                Console.WriteLine("{0}\t{1}", t.MyName, t.MyStatus);
            } */

            /*
             * "==" compares if the object reference are same while
             * ".Equals()" compares if the content are same
             */

            // Create two qual but distinct strings
            string a = new string(new char[] {'h', 'e', 'l', 'l', 'o',});
            string b = new string(new char[] { 'h', 'e', 'l', 'l', 'o', });

            Console.WriteLine("String a: {0}", a);
            Console.WriteLine("String b: {0}", b);

            Console.WriteLine("a==b {0}", a==b);
            Console.WriteLine("a.Equals(b): {0}", a.Equals(b));

            // Now let's see what happens with the same tests but
            // with variables of type object
            object c = a;
            object d = b;
            Console.WriteLine("c==d {0}", c == d);
            Console.WriteLine("c.Equals(d): {0}", c.Equals(d));

            Console.ReadKey();
        }
    }
}
