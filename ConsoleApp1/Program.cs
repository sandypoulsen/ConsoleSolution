using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v1 = new Vare("bukser", 200);

            string navnv1 = v1.Navn;
            double prisv1 = v1.Pris;
            Console.WriteLine("Pris med moms: " + v1.PrisMedMoms());

            Vare v2 = new Vare();
            v2.Navn = "trøje";
            v2.Pris = 100;

            string navnv2 = v2.Navn;
            double prisv2 = v2.Pris;

            Console.WriteLine("Pris med moms: " + v2.PrisMedMoms());

            Console.ReadKey();
        }

       
    }

    class Vare
    {
        private string navn;

        public string Navn
        {
            get {
                Console.WriteLine("navn hentes: " + navn);
                return navn; }
            set {
                Console.WriteLine("navn sættes: " + value);
                navn = value; }
        }

        private double pris;

        public double Pris
        {
            get {
                Console.WriteLine("pris hentes: " + pris);
                return pris; }
            set {
                Console.WriteLine("pris sættes: " + value);
                pris = value; }
        }

        public Vare()
        {
                
        }
        public Vare(string navn, double pris)
        {
            Navn = navn;
            Pris = pris;
        }

        public double PrisMedMoms()
        {
            return pris * 1.25;
        }
    }
}


