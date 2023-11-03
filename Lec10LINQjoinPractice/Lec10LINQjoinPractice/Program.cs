using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec10LINQjoinPractice
{
    class Students {
        public int Student_ID { get; set; }

        public string Student_Name { get; set; }

        public int Advisor_ID { get; set; }
        public Students(int s_id, string nm, int a_id)
        {
            Student_ID = s_id;
            Student_Name = nm;
            Advisor_ID = a_id;
        }
    }

    class Advisors
    {
        public int Advisor_ID { get; set; }
        public string Advisor_Name { get; set; }

        public Advisors(int a_id, string nm)
        {
            Advisor_ID = a_id;
            Advisor_Name = nm;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Students[] students = {
                                      new Students(1, "Student_1", 1),
                                      new Students(2, "Student_2", 8),
                                      new Students(4, "Student_4", 2),
                                      new Students(5, "Student_5", 3),
                                      new Students(7, "Student_7", 3),
                                      new Students(9, "Student_9", 1),
                                      new Students(10, "Student_10", 3),
                                  };
            Advisors[] advisors = {
                                      new Advisors(1, "Advisor_1"),
                                      new Advisors(3, "Advisor_3"),
                                      new Advisors(5, "Advisor_5"),
                                  };

            // create query
            var std_adv = from s in students
                          join a in advisors
                          on s.Advisor_ID equals a.Advisor_ID
                          select new { s.Student_Name, a.Advisor_Name};

            Console.WriteLine("Students\tAdvisor");
            foreach (var sa in std_adv)
            {
                Console.WriteLine("{0}\t{1}",sa.Student_Name, sa.Advisor_Name);
            }

            Console.ReadKey();
        }
    }
}
