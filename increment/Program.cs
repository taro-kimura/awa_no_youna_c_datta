using System;

namespace increment
{
    class Program
    {
        static void Main(string[] args)
        {
            // i++
            int i = 0;
            int a = i++;

            // i++は値を返して、「1」加える
            Console.WriteLine("i = " + i + ", i++ = " + a);

            // ++i
            int j = 0;
            int b = ++j;

            // ++iは、「1」加えて値を返す
            Console.WriteLine("i = " + j + ", ++i = " + b);

            Console.ReadLine();
        }
    }
}
