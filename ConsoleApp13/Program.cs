using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public delegate int beregnerDel(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> d = new Func<int, int, int>(FindTilfældigFunktion());
            int res = Beregner(8, 4, d);
            Console.WriteLine(res);
        }

        public static Func<int, int, int> FindTilfældigFunktion()
        {
            int time = DateTime.Now.Millisecond;
            if(time < 250)
            {
                return Plus;
            } else if(time > 250 && time < 500)
            {
                return Minus;
            } else if(time > 500 && time < 750)
            {
                return Divider;
            } else
            {
                return Gange;
            }
        }

        public static int Beregner(int x, int y, Func<int, int, int> del)
        {
            return del(x, y);
        }

        public static int Plus(int a, int b)
        {
            Console.WriteLine("Plus");
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            Console.WriteLine("Minus");
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            Console.WriteLine("Divider");
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            Console.WriteLine("Gange");
            return a * b;
        }
    }
}
