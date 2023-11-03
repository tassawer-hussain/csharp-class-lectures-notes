using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec3NamedArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            // the method can be called in the normal way, by using positional arguments
            Console.WriteLine(CalculateBMI(123, 64));

            // Named arguments can be supplied for the parameters in either order
            Console.WriteLine(CalculateBMI(weight: 123, height: 64));
            Console.WriteLine(CalculateBMI(height: 64, weight: 123));

            // Positional arguments cannot follow named arguments.
            // Following statement causes a compiler error.
            //Console.WriteLine(CalculateBMI(weight:123, 64));
            //Console.WriteLine(CalculateBMI(64, weight: 123));

            // Named arguments can follow positional arguments.
            Console.WriteLine(CalculateBMI(123, height: 64));
            

            Console.ReadKey();
        }

        static int CalculateBMI(int weight, int height)
        {
            return (weight * 703) / (height * height);
        }
    }
}
