using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] dbs = new IDbFunktioner[] { new Hund(), new Ubåd(), new Ubåd(), new Hund(), new Ubåd() };
            foreach(IDbFunktioner db in dbs)
            {
                db.Gem();
            }

                       
        }
    }

    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }

        void IDbFunktioner.Gem()
        {
            Console.WriteLine("Gemmer hund...");
        }
    }

    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd...");
        }
    }

    interface IDbFunktioner
    {
        void Gem();
    }
}
