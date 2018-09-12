using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            Person p1 = new Person()
            {
                Id = 1,
                Navn = "Peter"
            };
            Person p2 = new Person()
            {
                Id = 2,
                Navn = "Hans"
            };
            Person p3 = new Person()
            {
                Id = 3,
                Navn = "Klavs"
            };
            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);

            foreach(Person p in persons)
            {
                Console.WriteLine(p.write());
            }

            Dictionary<int, Person> pd = new Dictionary<int, Person>();
            pd.Add(1, p1);
            pd.Add(2, p2);
            pd.Add(3, p3);

            Person p4;
            if(pd.TryGetValue(1, out p4))
            {
                Console.WriteLine(p4.write());
            }

        


        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }

        public string write()
        {
            return Id + ", " + Navn;
        }
    }
}
