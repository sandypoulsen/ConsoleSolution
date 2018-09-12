using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person()
            {
                Fornavn = "Hans",
                Efternavn = "Hansen"
            };

            Person p2 = new Person()
            {
                Fornavn = "Peter",
                Efternavn = "Petersen"
            };

            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p2.FuldtNavn());

            Elev e = new Elev()
            {
                Fornavn = "Jens",
                Efternavn = "Jensen",
                Klasselokale = "1A"
            };

            Instruktør i = new Instruktør()
            {
                Fornavn = "Klavs",
                Efternavn = "Klavsen",
                NøgleId = 1001
            };

            Console.WriteLine(e.FuldtNavn());
            Console.WriteLine(i.FuldtNavn());
            Console.WriteLine();

            List<Person> l = new List<Person>();
            l.Add(p1);
            l.Add(p2);
            l.Add(e);
            l.Add(i);

            foreach(Person p in l)
            {
                Console.WriteLine(p.FuldtNavn());
            }
        }
    }

    class Person
    {
        public string Fornavn { get; set; }

        public string Efternavn { get; set; }

        public virtual string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }

        public override string FuldtNavn()
        {
            return Fornavn;
        }
    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }

        public override string FuldtNavn()
        {
            return "Hr. " + Efternavn;
        }
    }
}
