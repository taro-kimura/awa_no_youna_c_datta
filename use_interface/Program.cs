using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace use_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // A・B・Cの3つのクラスは、ICalculatorインターフェイスで継承している
            ICalculator[] a = { new A(), new B(), new C() };
            
            foreach (ICalculator calc in a)
            {
                int r = calc.Execute(3, 2);
                Console.WriteLine(r);
            }

            Console.ReadLine();
        }
    }

    interface ICalculator
    {
        int Execute(int a, int b);
    }

    class A : ICalculator
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }

    class B : ICalculator
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }

    class C : ICalculator
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}
