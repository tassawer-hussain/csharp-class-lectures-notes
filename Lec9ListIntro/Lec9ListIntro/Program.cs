using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec9ListIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dogs = new List<string>();
            dogs.Add("maltese1"); // Contains maltese
            dogs.Add("otterhound2"); // maltese, otterhound
            dogs.Add("rottweiler3"); // maltese, otterhound, rottweiler
            dogs.Add("bulldog4");    // ... rottweiler, bulldog
            dogs.Add("whippet5");    // .... rottweiler, bulldog, whippet

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog);
            }

            dogs.Remove("bulldog4"); // remove bulldog
            
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog);
            }

            dogs.RemoveAt(1); // Remove second dog

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog);
            }

            Console.ReadKey();
        }
    }
}
