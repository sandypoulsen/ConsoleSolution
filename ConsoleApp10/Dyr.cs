using System;

namespace ConsoleApp10
{
    abstract class Dyr
    {
        private static System.Random rnd = new Random();
        public string Navn { get; set; }

        public abstract void SigNoget();
        //{
        //    Console.WriteLine("Jeg er et dyr og hedder " + Navn);
        //}

        public static Dyr TilFældigtDyr()
        {
            string sti = @"c:\dyr\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);
            int index = rnd.Next(0, navne.Length);
            if (index % 2 == 0)
            {
                return new Hund() { Navn = navne[index] };
            }
            else
            {
                return new Kat() { Navn = navne[index] };
            }

        }
    }
}
