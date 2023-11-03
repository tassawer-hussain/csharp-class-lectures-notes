using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SC = System.Console;

// To use class in Outside namespace
using MyOutsideNameSpace;

namespace Lec3ClassStructureAccessASpecifier
{
    class Program
    {
        public int num;
        static void Main(string[] args)
        {
            // to create an instance of this class from another namespace
            // first include the namespace by 'using'
            MyClassOutsideNameSpace OsNsClass = new MyClassOutsideNameSpace();

            // Instance of Class inside the same namespace
            MyAnotherClass InSameNsClass = new MyAnotherClass();

            MyInsideNameSpace.MyClassInsideNameSpace InNsClass = new MyInsideNameSpace.MyClassInsideNameSpace();
            SC.WriteLine(InNsClass.pencil(3, 6));
            SC.WriteLine(InSameNsClass.MultiplyBy(7));
            SC.ReadKey();
        }
    }

    public class MyAnotherClass
    {
        // class members:
        // Property
        public int Number { get; set; }

        // Instance Constructor.
        public MyAnotherClass()
        {
            Number = 2;
        }

        // Method.
        public int MultiplyBy(int num)
        {
            return Number * num;
        }
    }

    namespace MyInsideNameSpace
    {
        public class MyClassInsideNameSpace
        {
            public float pencil(int a, int b)
            {
                return ((float)(a + b) / 2);
            }
        }
    }
}

namespace MyOutsideNameSpace
{
    public class MyClassOutsideNameSpace
    {
        public float pen(int a, int b)
        {
            return ((float)(a+b) / 2);
        }
    }
}
