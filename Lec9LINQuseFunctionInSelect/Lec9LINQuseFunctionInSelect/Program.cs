using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec9LINQuseFunctionInSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = { -10.0, 16.4, 12.125, 100.85, -2.2, 25.25, -3.5 };

            // Create a query that returns the squareroots of the
            // positive numbers

            var sqrroot = from n in nums
                          where n > 0
                          select Math.Sqrt(n);

            Console.WriteLine("The square roots of the positive values " + 
                "rounded to two decimal places:");
            // foreach(double d in sqrroot)
            foreach (var d in sqrroot)
            {
                Console.WriteLine("{0:#.##}", d);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
