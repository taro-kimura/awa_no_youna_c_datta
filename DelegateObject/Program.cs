using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateObject
{
    // Signalデリゲートは、戻り値も引数もないメソッドへの参照を格納することができる
    delegate void Signal();

    class Program
    {
        static void Main(string[] args)
        {
            // Signalデリゲート型の変数xを宣言するとともに、
            // Redメソッドへの参照を格納したデリゲートオブジェクトを生成して、
            // 変数xに代入している
            Signal x = new Signal(Red);

            // Invokeメソッドは、デリゲートに格納されているメソッドを実行する
            x.Invoke();

            Console.ReadLine();
        }

        static void Red() { Console.WriteLine("赤"); }
    }
}
