using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec9LINQuseSelectWithClassObj
{
    class EmailAddress {
        public string Name { get; set; }
        public string Address { get; set; }

        public EmailAddress(string n, string a) {
            Name = n;
            Address = a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmailAddress[] addresses = {
                                           new EmailAddress("Herb", "Herb@HerbSchildt.com"),
                                           new EmailAddress("Tom", "Tom@HerbSchildt.com"),
                                           new EmailAddress("Sara", "Sara@HerbSchildt.com")
                                       };

            // Create a query that select email address.
            var email = from add in addresses
                        select add.Address;

            Console.WriteLine("The e-mail address are");
            foreach (var e in email)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
