using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutAsParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int add = 2, sub, mul;
            float div;

            Console.Write("Enter 1st number\t");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            parameter(num1, num2, ref add, out sub, out mul, out div);

            Console.WriteLine("\n\n{0} + {1} = {2}", num1, num2, add);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, sub);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, mul);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, div);

            Console.ReadKey();
        }

        static void parameter(
            int num1,
            int num2,
            ref int a,
            out int sub,
            out int mul,
            out float div)
        {
            a = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = (float)num1 / num2;
        }
    }
}
