using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec9LINQchangeValueAfterQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2, 3, -4, 0, 5};
            var posNums = from n in nums
                          where n > 0
                          select n;
            Console.WriteLine("Positive numbers are");
            foreach (var n in posNums)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Setting num[1] to 99");
            nums[1] = 99;

            Console.WriteLine("Positive values in nums after change");
            foreach (var n in posNums)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
