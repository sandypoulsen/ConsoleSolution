using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public delegate int m(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            MyClass x = new MyClass();
            m dx = x.getAdd();
            dx += (z, v) =>
            {
                Console.WriteLine(z*v);
                return z * v;
            };
            dx.Invoke(3, 4);
            dx(2, 8);

            Console.WriteLine();

            foreach(m item in dx.GetInvocationList())
            {
                item.DynamicInvoke(3,4);
            }
        }
    }

    class MyClass
    {
        private int Add(int x, int y)
        {
            Console.WriteLine(x + y);
            return x + y;
        }

        public m getAdd()
        {
            return Add;
        }

    }
}
