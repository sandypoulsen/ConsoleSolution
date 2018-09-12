using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dyr[] dyrA = new Dyr[20];
            for(int i = 0; i < dyrA.Length; i++)
            {
                dyrA[i] = Dyr.TilFældigtDyr();
            }

            foreach(Dyr d in dyrA)
            {
                d.SigNoget();
            }

            string s = "hello world.hh";
            Console.WriteLine(s.WordCount());
            
        }
    }

    public static class MyExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
