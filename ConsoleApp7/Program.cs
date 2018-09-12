using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B("a", "b");
        }
    }

    class A
    {
     
        public string S { get; set; }
        public A(string ss)
        {
            S = ss;
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        string s, t;
        public B(string s, string t) : base(s)
        {
            this.s = s;
            this.t = t;
            Console.WriteLine("B");
        }
    }
}

