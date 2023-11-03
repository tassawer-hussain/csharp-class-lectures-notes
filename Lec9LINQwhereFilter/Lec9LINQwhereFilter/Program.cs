using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec9LINQwhereFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {0, 9, 4, -2, 11, 5, 8, -1, -19, -10, 19, 21, 16, -32};

            // create a query that obtains positive value less than 10
            var posNums = from n in nums
                          where n > 0
                          where n < 10
                          select n;
            Console.WriteLine("Positive numbers between 0 and 10 are");

            foreach (var i in posNums)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
