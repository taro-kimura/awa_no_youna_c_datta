using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reigai_no_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0.チャーハン");
            Console.WriteLine("1.ラーメン");
            Console.WriteLine("2.ギョウザ");
            Console.WriteLine("何にしますか？");

            string s = Console.ReadLine();
            int i = 0;

            if (int.TryParse(s, out i)) Order(i);

            Console.ReadLine();

        }

        static void Order(int i)
        {
            // 0～2の範囲外なら
            // ArgumentOutOfRangeException型の例外をスローする
            // -> プログラムの実行を停止
            if (i < 0 || i > 2)
            {
                throw new ArgumentOutOfRangeException();
            }

            Console.WriteLine("承りました！");
        }
    }
}
