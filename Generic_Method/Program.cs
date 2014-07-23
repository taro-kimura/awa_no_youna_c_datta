using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Console.WriteLine("a={0}, b={1}", a, b);

            // 型名を指定
            Swap<int>(ref a, ref b);

            // int型の値がSwapメソッドによって正しく入れ替えられている
            Console.WriteLine("a={0}, b={1}", a, b);

            string c = "右";
            string d = "左";

            // string型の値が先ほどと同じSwapメソッドによって正しく入れ替えられている
            // -> ジェネリックメソッドは、複数のデータ型で同じ処理をするメソッドを共通化できる
            Console.WriteLine("c={0}, d={1}", c, d);

            // 型名を省略
            // 型パラメーター名「T」が引数で使用されているため、
            // Swapメソッドを呼び出す際に、型パラメータ―リストを省略できる
            Swap(ref c, ref d);

            Console.WriteLine("c={0}, d={1}", c, d);

            Console.ReadLine();

        }

        // 二つの値を入れ替えるSwap<T>ジェネリックメソッドの例
        static void Swap<T>(ref T v1, ref T v2)
        {
            // 型パラメータ―名「T」を型のように使用して、変数「b」を宣言している
            // -> 変数「b」の型は、型パラメーターに指定されたデータ型として処理される
            T b = v1;
            v1 = v2;
            v2 = b;
        }
    } 
}
