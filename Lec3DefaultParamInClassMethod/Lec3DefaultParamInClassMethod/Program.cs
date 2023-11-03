using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec3DefaultParamInClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instance anExample does not send an argument for the
            // constructor's optional parameter.
            TestClass anExample = new TestClass();
            anExample.TestMethod(1, "one", 1);
            anExample.TestMethod(2, "Two");
            anExample.TestMethod(3);

            // Instance anotherExample sends an argument for the
            // constructor's optional parameter.
            TestClass anotherExample = new TestClass("Provided Name");
            anotherExample.TestMethod(1, "one", 1);
            anotherExample.TestMethod(2, "Two");
            anotherExample.TestMethod(3);

            // The following statements produce compiler errors.
            // An argument must be supplied for the first parameter, and it must
            // be an interger.
            //anExample.TestMethod("one", 1);
            //anExample.TestMethod();

            // You cannot leave a gap in the provided arguments.
            //anExample.TestMethod(3, ,4);
            //anExample.TestMethod(3, 4);

            // you can use a named parameter to make the previous
            // statement work.
            anExample.TestMethod(3, optionalInt: 4);
            anExample.TestMethod(3, optionalStr: "Hi");
            
            Console.ReadKey();
        }
    }

    class TestClass
    {
        private string _name;

        // Because the parameter for the constructor, name, has a defualt
        // value assigned to it, it is optional.
        public TestClass(string name = "Default Name")
        {
            _name = name;
        }

        // The first parameter, required, has no default value assigned to it.
        // Therefore, it is not optional.
        // Both optionalStr and optionalInt have default values assigned to them.
        // They are optional
        public void TestMethod(int req,
            string optionalStr = "Default string",
            int optionalInt = 10)
        {
            Console.WriteLine("{0}: {1}, {2} and {3}.", _name, req, optionalStr, optionalInt);
        }
    
    }
}
