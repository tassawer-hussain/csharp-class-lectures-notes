using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec9LINQandInWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { ".com", ".net", "hsNameA.com", "hsNameB.net",
                            "test", ".network", "hsNameC.net", "hsNameD.com"};

            // Create a query that obtains internet addresses that end with .net
            var netAddrs = from adrs in strs
                           where adrs.Length > 4 && adrs.EndsWith(".net", StringComparison.Ordinal)
                           select adrs;

            // Display the result
            foreach (var address in netAddrs)
            {
                Console.WriteLine(address);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
