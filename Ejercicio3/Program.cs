using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();

            Console.ReadKey();

        }
    }

    class A
    {
        public A()
        {
            Console.WriteLine("Soy clase A");     
        }

    }

    class B:A
    {
        public B()
        {
            Console.WriteLine("Soy clase B");
        }
    }

    class C:B
    {
        public C()
        {
            Console.WriteLine("Soy clase C");
        }
    }
}
