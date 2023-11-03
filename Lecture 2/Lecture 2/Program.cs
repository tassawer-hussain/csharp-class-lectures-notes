using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2
{
    class Program
    {
        enum Days {Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        static void Main(string[] args)
        {
            int x = (int)Days.Sun;
            int y = (int)Days.Fri;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);

            Console.WriteLine("Hello World");

            /*
            // How to read a number
            string number;
            int num;
            Console.WriteLine("Enter Number: ");
            number = Console.ReadLine();
            num = Convert.ToInt32(number);
            Console.WriteLine(num); */

            /*
            int a = 12;
            float b = 6F;
            // var is contextual keyword of c#
            var c = "Ali";
            System.Console.WriteLine("A is: " + a 
                + ",\nB is: " + b
                + ",\nC is: " + c);

            System.Console.Write("Write your Name here: ");
            string userinput = System.Console.ReadLine();
            System.Console.WriteLine("Hi, " + userinput + "! How are you baby?");

            afternoon af = new afternoon();
            af.students();
            */

            /*
            string s = "Hel000000l0000000o";
            char third = s[2];
            string[] split = s.Split(third);
            //System.Console.WriteLine(split);
            foreach (var sp in split) 
            {
                //sp.append(sp, 'l');
                Console.WriteLine(sp);
            }
            */

            // Hold down the console to wait, not vanish after displaying output
            Console.ReadKey();
        }
    }

    class afternoon {
        public void students() {
            System.Console.WriteLine("Greeting Message from afternoon Students!");
        }
    }
}
