using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };

            int j = a.FindIndex(x => x == 51);
            int i = a.FindIndex(Find);

            Console.WriteLine(i + " " + j);

            a.ForEach((x) => Console.WriteLine(x));

           
        }                 

        public static bool Find(int værdi)
        {
            return værdi == 51;
        }
    }
}
