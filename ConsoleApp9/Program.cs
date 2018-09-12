using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandon r = new UdvidetRandon();
            Console.WriteLine(r.NextBool());
        }
    }

    class UdvidetRandon : Random
    {

        public bool NextBool()
        {
            int n = Next(1, 1002);
            return n <= 500;
        }
    }
}
