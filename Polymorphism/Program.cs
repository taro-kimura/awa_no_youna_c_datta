using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock a = new AlarmClock();

            // AlarmClock型のインスタンスが格納されている変数aを
            // Watch型の変数bに代入している
            // ※ AlarmClock型のインスタンスはWatch型でもあるため、問題なく代入することができる
            Watch b = a;

            // Watch型の変数bに格納されているAlarmClockインスタンスを
            // AlarmClock型の変数cに代入している
            // ※ 変数bはWatch型なので、AlarmClock型にキャストする必要がある
            AlarmClock c = (AlarmClock)b;

            // AlarmClock型のインスタンスを生成した参照を直接
            // Watch型の変数dに格納することもできる
            Watch d = new AlarmClock();

            // Watch型（基本クラス）インスタンスへの参照をAlarmClock型（派生クラス）の変数eに格納しようとしているため、
            // コンパイルエラーになる
            // AlarmClock e = new Watch();
        }
    }

    // Watchクラスを宣言
    // 基本クラスが省略されているため、
    // Objectクラスを継承したことになる
    class Watch
    { 
        // 実装は省略
    }

    // AlarmClockクラスを宣言
    // Watch型とObject型のインスタンスでもある
    class AlarmClock : Watch
    { 
        // 実装は省略
    }
}
