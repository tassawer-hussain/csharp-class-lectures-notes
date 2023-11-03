using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec3BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * C# Type System contains three Types, 
             * they are Value Types, Reference Types and Pointer Types.
             * C# allows us to convert a Value Type to a Reference Type,
             * and back again to Value Types . The operation of Converting
             * a Value Type to a Reference Type is called Boxing 
             * and the reverse operation is called Unboxing.
             */

            int a = 123;
            Object obj = a; // Boxing
            
            a = 786;
            int c = (int)obj; // Unboxing

            Console.WriteLine("Value of a is " + a);
            Console.WriteLine("Value of Obj is " + obj);
            Console.WriteLine("Value of c is " + c);

            double d = 2.718281828459045;
            double e = d;

            object o1 = d;
            object o2 = e;

            Console.WriteLine(d == e);
            Console.WriteLine(o1 == o2);

            Console.ReadKey();

        }
    }
}
