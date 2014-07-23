using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lambda_shiki
{
    delegate void Signal();
    delegate void Message(string text);
    delegate int Calculate(int value1, int value2);
    class Program
    {
        static void Main(string[] args)
        {
            // ラムダ式の構文
            // (引数リスト) => { 実行したいステートメント };
            
            // メソッドブロック内に、1つのステートメントしかないとき、
            // ブロックを表す{}を省略することができる
            // 省略しない場合: Signal x = () => {Console.WriteLine("赤");};
            // ※ 引数がないことを示す()は、省略することができない
            Signal x = () => Console.WriteLine("赤");

            // 引数の型は、Messageデリゲートの型から推論できるため、
            // ラムダ式で省略することができる
            // 省略しない場合: Message m = (string t) => {Console.WriteLine(t);};
            Message m = t => Console.WriteLine(t);

            // returnキーワードは省略可
            // 省略しない場合: Calculate c = (int a, int b) => { return a + b; };
            Calculate c = (a, b) => a + b;

            x();
            m("C#");
            Console.WriteLine(c(2,4));

            Console.ReadLine();
        }
    }
}
