using System;
using System.Collections;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // aの宣言
            ArrayList a = new ArrayList();
            
            // 入園
            a.Add("いとうあい");
            a.Add("ひらのりほ");

            Console.WriteLine("- リス組園児リスト (2013年4月) -");

            // aを出力
            foreach (string x in a)
            {
                Console.WriteLine(x);
            }

            // 入園: あらいあきこ 
            a.Insert(0,"あらいあきこ");

            Console.WriteLine("- リス組園児リスト (2013年7月) -");

            // aを出力
            foreach (string x in a)
            {
                Console.WriteLine(x);
            }

            // 卒園: いとうあい
            a.RemoveAt(1);

            Console.WriteLine("- リス組園児リスト (2014年3月) -");

            // aを出力
            foreach (string x in a)
            {
                Console.WriteLine(x);
            }

            // [Enter]で終了
            Console.ReadLine();

        }
    }
}
