using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec3VarParamFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            // call the function with different parameters
            int sum1 = sumVarParameters(1);
            int sum2 = sumVarParameters(2, 2);
            int sum3 = sumVarParameters(3, 3, 3);
            int sum4 = sumVarParameters(4, 4, 4, 4);
            //output the result
            Console.WriteLine("Sum1 = {0}", sum1);
            Console.WriteLine("Sum2 = {0}", sum2);
            Console.WriteLine("Sum3 = {0}", sum3);
            Console.WriteLine("Sum4 = {0}", sum4);

            Console.ReadKey();

        }

        static int sumVarParameters(params int[] values)
        {
            int total = 0;
            foreach (int value in values)
            {
                total += value;
            }
            return total;
        }
    }
}
