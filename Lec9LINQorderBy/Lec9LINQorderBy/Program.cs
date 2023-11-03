using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec9LINQorderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, -19, 4, 7, 2, -5, 0 };

            // Create a query that obtains the values in sorted order
            var posNums = from n in nums
                          orderby n ascending
                          select n;

            Console.WriteLine("Values in ascending order: ");
            foreach (var n in posNums)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
