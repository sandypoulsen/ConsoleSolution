using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Wrapper<string> w = new Wrapper<string>("hello");
            w.Add("world");

            foreach(string s in w.getList())
            {
                Console.WriteLine(s);
            }
        }
    }

    class Wrapper<T>
    {
        private List<T> ints = new List<T>();
        public Wrapper(T i)
        {
            ints.Add(i);
        }

        public List<T> getList()
        {
            return ints;
        }

        public void Add(T i)
        {
            ints.Add(i);
        }


    }
}
