using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string fil = @"c:\temp\test.txt";
            DanFil(fil);
            string indhold = await HentTekst(fil);
        }

        public static void DanFil(string fil)
        {
            if (System.IO.File.Exists(fil))
                System.IO.File.Delete(fil);

            using (var s = System.IO.File.AppendText(fil))
                for (int i = 0; i < 1000; i++)
                    s.WriteLine(Guid.NewGuid().ToString());
        }

        static async Task<string> HentTekst(string fil)
        {
            return "hhe";
        }


    }
}
