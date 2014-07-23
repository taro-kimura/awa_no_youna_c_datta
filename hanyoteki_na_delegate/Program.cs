using System;

namespace hanyoteki_na_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action x = () => Console.WriteLine("赤");

            // Actionは戻り値を持たないメソッドへの参照を格納できる汎用的なデリゲート
            Action<string> m = t => Console.WriteLine(t);

            // Funcは戻り値を持つメソッドへの参照を格納できる汎用的なデリゲート
            // 戻り値と2つの引数を指定する場合は、
            // Func<T1, T2, TResult>デリゲートを使用できる
            // <T1, T2, TResult>には、先頭から「第一引数の型・第二引数の型・戻り値の型」を順に指定する
            Func<int, int, int> c = (a, b) => a + b;

            x.Invoke();
            m("C#");
            Console.WriteLine(c(2,4));
            Console.ReadLine();
        }
    }
}
