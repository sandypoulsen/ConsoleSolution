using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant(3, 4);
            Console.WriteLine(t.Areal);
            Console.WriteLine(t.GetAreal());
            Trekant t2 = new Trekant(3, 5);
            Console.WriteLine(t2.Areal);
            Console.WriteLine(t2.GetAreal());


            Console.ReadKey();
        }
    }

    public class Trekant
    {
        public int Grundlinje { get; private set; }
        public int Højde { get; private set; }

        public double Areal
        {
            get { return (double)(Højde * Grundlinje) / 2; }
        }

        public Trekant(int grundlinje, int højde)
        {
            Grundlinje = grundlinje;
            Højde = højde;
        }

        public double GetAreal()
        {
            return (double)Højde * Grundlinje / 2;
        }


    }
}
