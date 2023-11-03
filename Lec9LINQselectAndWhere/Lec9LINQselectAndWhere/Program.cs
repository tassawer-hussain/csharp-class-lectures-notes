using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec9LINQselectAndWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2, 3, 0, -4, 5};

            // create a query that obtains only positive numbers.
            var posNums = from n in nums
                          where n > 0
                          select n;

            foreach (var n in posNums)
            {
                Console.WriteLine(n + " ");
            }

            int max = posNums.Max();
            Console.WriteLine("Maximum Positive Number is {0}", max);
            Console.ReadKey();
        }
    }
}
