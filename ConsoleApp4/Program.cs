using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 1500000 };
            int sum = 0;
            foreach (int i in månedsløn)
            {
                sum += i;
                Console.WriteLine(i);
            }

            Console.WriteLine("Gennemsnit  {0:0.00}" , (double)sum/månedsløn.Length);


            string txt = "3;5;22;1;10;15;5;A";
            string[] textA = txt.Split(';');
            sum = 0;
            int sum2 = 0;
            foreach(string s in textA)
            {
                int x;
                if (Int32.TryParse(s, out x))
                {
                    sum2 += x;
                };
                
            }
            
            Console.WriteLine("sum2:" + sum2);
        }
    }
}
