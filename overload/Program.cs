using System;

namespace overload
{
    class Program
    {
        static void Main(string[] args)
        {
            // ShowMessageメソッドを呼び出す際の引数に準じて、どちらのメソッドが使用されるかが決まる
            
            Console.WriteLine("---引数が二個のShowMessageメソッドを呼び出す---");

            ShowMessage("とまらない",false);
            ShowMessage("とまる", true);

            Console.WriteLine("---引数が一個のShowMessageメソッドを呼び出す---");

            ShowMessage("とまる");
        }

        // 同名のメソッド「ShowMessage」を二つ宣言

        // こちらのメソッドは引数が一個
        static void ShowMessage(string message)
        {
            ShowMessage(message, true);
        }

        // こちらのメソッドは引数が二個
        static void ShowMessage(string message, bool isStop)
        {
            Console.WriteLine(message);

            if (!isStop) return;

            // isStopがtrueの場合 : 以下の一文を実行
            Console.ReadLine();
        }
    }
}
