using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning(7);
            t.Skriv();

            t.Ryst();
            t.Skriv();

            t.Ryst();
            t.Skriv();

            Terning t2 = new Terning
            {
                Værdi = 8
            };

            t2.Skriv();

            LudoTerning lt1 = new LudoTerning(3);
            lt1.Skriv();
            Console.WriteLine(lt1.ErGlobus());
            Console.WriteLine(lt1.ErStjerne());
            lt1.Ryst();
            lt1.Skriv();

            lt1.Ryst();
            lt1.Skriv();

            lt1.Ryst();
            lt1.Skriv();

            lt1.Ryst();
            lt1.Skriv();

            Console.ReadKey();


        }
    }

    public class Terning
    {
        private int værdi;
        private static System.Random rnd = new System.Random();

        public int Værdi
        {
            get {
                Console.WriteLine("Der aflæses: " + værdi);
                return værdi; }
            set {
                Console.WriteLine("Der tildeles: " + value);
                if (value < 1 || value > 6)
                    værdi = 1;
                else
                    værdi = value; }
        }

        public Terning()
        {
            Ryst();
        }
        public Terning(int værdi)
        {
            Værdi = værdi;
        }

        public void Ryst()
        {
           
            Værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine("[" + Værdi + "]");
        }

    }

    public class LudoTerning : Terning
    {
        public LudoTerning() : base()
        {
                
        }

        public LudoTerning(int værdi) : base(værdi)
        {

        }
        public bool ErGlobus()
        {
            return Værdi == 3;
        }

        public bool ErStjerne()
        {
            return Værdi == 5;
        }
    }

    public class Bæger<HE>
    {
        private List<HE> lst = new List<HE>();
        public void Tilføj(HE d)
        {
            lst.Add(d);
        }
        public List<HE> Terninger()
        {
            return lst;
        }
    }
}
