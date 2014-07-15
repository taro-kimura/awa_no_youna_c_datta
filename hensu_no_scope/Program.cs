using System;

namespace hensu_no_scope
{
    class Program
    {
        private static int a = 1;
        static void Main(string[] args)
        {
            int b = 2;
            {
                int s = a + b;
                // 変数sはスコープの中なので使用できる
                Console.WriteLine(s);
            }
            // 変数sはスコープの外なのでコンパイルエラーになる
            // Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
