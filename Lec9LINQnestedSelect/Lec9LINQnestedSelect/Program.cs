using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec9LINQnestedSelect
{
    class CharPair
    {
        public char first;
        public char second;
        public CharPair(char c1, char c2)
        {
            first = c1;
            second = c2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            char[] chars1 = { 'A', 'B', 'C' };
            char[] chars2 = { 'X', 'Y', 'Z' };

            // Notics that the 1st from iterates over chars1 and
            // the 2nd from iterates over chars2
            var pairs = from ch1 in chars1
                        from ch2 in chars2
                        select new CharPair(ch1, ch2);

            Console.WriteLine("All combinations of ABC with XYZ: ");
            foreach (var p in pairs)
            {
                Console.WriteLine("{0} {1}", p.first, p.second);
            }

            Console.ReadKey();
        }
    }
}
