using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.Changed += (s, e) => Console.WriteLine("Filen " + e.FullPath + " er rettet");
            w.Created += (s, e) => Console.WriteLine("Filen " + e.FullPath + " er oprettet");
            w.Deleted += (s, e) => Console.WriteLine("Filen " + e.FullPath + " er slettet");

            Console.ReadKey();
        }

    }
}
