using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            b.Vis();

            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();

            b.Vis();
        }
    }

    public class Bunke
    {
        private Stack<Kort> bunke = new Stack<Kort>();

        public void TilføjKort(Kort kort)
        {
            bunke.Push(kort);
        }

        public Kort FjernKort()
        {
            return bunke.Pop();
        }

        public void Vis()
        {
            foreach(Kort kort in bunke)
            {
                Console.WriteLine(kort);
            }
        }
    }

    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }

        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }
    }
}
