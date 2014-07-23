using System;

namespace tokumei_method
{
    delegate void Signal();
    delegate void Message(string text);
    delegate int Calculate(int value1, int value2);

    class Program
    {
        static void Main(string[] args)
        {
            // 引数がないときは、呼び出し演算子「()」を省略できる
            Signal x = delegate{Console.WriteLine("赤");};

            // 匿名メソッドを使用する際には、
            // delegateキーワードに続けて引数リストを記述した後、
            // メソッドブロック内に実行したいコードを記述する
            Message m = delegate(string t) { Console.WriteLine(t); };

            // 戻り値の型はデリゲート型から推論されるため、記述する必要はない
            Calculate c = delegate(int a, int b) { return a + b; };
            
            x();
            m("C#");
            
            Console.WriteLine(c(2, 4));

            Console.ReadLine();
        }
    }
}
