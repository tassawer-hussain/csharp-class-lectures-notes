using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec9LINQuseVarInQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "alpha", "beta", "gamma"};

            // create a query that obtaines the characters in the strings.
            // returned in sorted order. Notice the use of a nested from clause

            var chrs = from str in strs
                       let chrArr = str.ToCharArray()
                       from ch in chrArr
                       orderby ch
                       select ch;

            Console.WriteLine("The inddividual characters in sorted order:");
            foreach (var c in chrs)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
