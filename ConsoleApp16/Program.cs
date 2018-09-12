using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(100);
            //foreach (var person in people)
            //    Console.WriteLine(person.Name);

            //Console.WriteLine();

            //var people2 = people.OrderBy(x => x.Name);
            //foreach(var person in people2)
            //    Console.WriteLine(person.Name);

            //var people3 = people.OrderBy(x => x.Name).GroupBy(x => x.Gender);
            //foreach (var g in people3)
            //    foreach(var person in g)
            //    Console.WriteLine(person.Name + " " + person.Gender);

            //var people4 = people.OrderBy(x => x.Name).OrderBy(x => x.Gender);
            //foreach(var p4 in people4)
            //    Console.WriteLine(p4.Name + " " + p4.Gender);

            var people5 = people.Where(x => x.Height < 170 && x.IsHealthy == true);
            foreach(var p5 in people5)
                Console.WriteLine(p5.Name + " " + p5.Height + " " + p5.IsHealthy);

            var people6 = people.GroupBy(p => p.Gender);
            foreach(var i in people6)
            {
                foreach(var p in i)
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
