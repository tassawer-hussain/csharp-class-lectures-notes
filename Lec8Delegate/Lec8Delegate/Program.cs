using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec8Delegate
{
    class MyDelegate
    {
        public int addThreeNum(int x, int y, int z)
        {
            int result = x + y + z;
            Console.WriteLine("Sum of X:{0}, Y:{1} and Z:{2} is {3}", x, y, z, result);
            return result;
        }
    }

    class Program
    {
        // Declare delegate
        delegate int MyFirstDelegate(int a, int b);

        static int addTwoNum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Sum of A:{0} and B:{1} is {2}", a, b, sum);
            return sum;
        }

        static int multiplyTwoNum(int m, int n)
        {
            int product = m * n;
            Console.WriteLine("Multiplication of M:{0} and N:{1} is {2}", m, n, product);
            return product;
        }
        static void Main(string[] args)
        {
            // Simple Delegate
            /*
            MyFirstDelegate myFirstDelegate = new MyFirstDelegate(addTwoNum);
            myFirstDelegate(4, 8); */

            // Delegate Method Group Conversion
            MyFirstDelegate myFirstDelegate = addTwoNum;
            myFirstDelegate(10, 12);

            myFirstDelegate = multiplyTwoNum;
            myFirstDelegate(4, 12);

            // Using Instance Methods as Delegate
            MyDelegate insMethod = new MyDelegate();
            insMethod.addThreeNum(3, 4, 5);

            Console.WriteLine("\n\nCall delegate after creating an instance of the class");
            myFirstDelegate(12, 12);

            Console.WriteLine("\n\n");
            
            // Multicast Delegate
            MyFirstDelegate multiCastDelegate = addTwoNum;
            multiCastDelegate += multiplyTwoNum;
            multiCastDelegate(5, 8);

            Console.WriteLine("\n\nCall MultiCastDelegate after removing adddtion method");
            multiCastDelegate -= addTwoNum;
            multiCastDelegate(5, 6);
            

            Console.ReadKey();
        }
    }
}
