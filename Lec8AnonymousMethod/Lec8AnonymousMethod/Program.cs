using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec8AnonymousMethod
{
    class Program
    {
        delegate int AMD(int a);

        static void Main(string[] args)
        {
            /*
             * In normal delegate, first we declare an instance of delegate
             * then assign a function to that delegate instance
             * e.g.
             * AMD myDelegateVar = new AMD(methodName);
             * or
             * AMD myDelegateVar = new AMD();
             * myDelegateVar = methodName;
             * 
             * But here, we define a method without any name and assign 
             * that method to delegate instance
             * 
             */


            AMD anonymousMethod = delegate(int a)
            {
                int result = a * 2;
                Console.WriteLine("I am unNamed Code " + result);
                return result;
            };

            anonymousMethod(4);
            Console.ReadKey();
        }
    }
}
