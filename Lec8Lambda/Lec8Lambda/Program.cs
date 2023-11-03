using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec8Lambda
{
    class Program
    {
        // declare delegate
        delegate int addition(int a);

        static void Main(string[] args)
        {
            /*
            // Lambda statement
            addition justAdd = (n) => n + 2;

            int count = 0;
            while (count <= 10)
            {
                Console.Write(count + " ");
                count = justAdd(count);
            } */

            // Lambda Statement
            addition justAddAgain = (n) =>
                {
                    int a = n + 1;
                    int b = a + 1;
                    return b;
                };

            int count2 = 0;
            while (count2 <= 10)
            {
                Console.Write(count2 + " ");
                count2 = justAddAgain(count2);
            }

            Console.ReadKey();
        }
    }
}
