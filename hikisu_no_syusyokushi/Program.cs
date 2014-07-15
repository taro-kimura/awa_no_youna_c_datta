using System;

namespace hikisu_no_syusyokushi
{
    class Program
    {
        static void Main(string[] args)
        {
            // paramsキーワード
            Console.WriteLine("---paramsキーワードの例---");
            Console.WriteLine(Plus());
            Console.WriteLine(Plus(1));
            Console.WriteLine(Plus(1,2));
            Console.WriteLine(Plus(1,2,3));
            Console.WriteLine(Plus(1,2,3,4));

            // refキーワード
            int i = 0;
            
            // 変数iを参照渡し
            GetValue(ref i);

            Console.WriteLine("---refキーワードの例---");
            Console.WriteLine(i);

            // outキーワード
            int j = 0;
            
            // outキーワードで修飾した引数には、メソッドを呼び出す側にもoutキーワードを記述しなければならない
            GetValueOut(out j);

            Console.WriteLine("---outキーワードの例---");
            Console.WriteLine(j);

            // outキーワードで修飾した変数は、必ずしも事前に初期化されている必要はない
            int k;

            GetValueOut(out k);

            Console.WriteLine(k);

            // これがないと、勝手にコンソールが閉じてしまう
            Console.ReadLine();

        }

        // paramsキーワードを使用した例
        static int Plus(params int[] value)
        {
            int r = 0;

            foreach (int x in value)
            {
                r += x;
            }

            return r;
        }

        // refキーワードを使用した例
        static void GetValue(ref int value)
        {
            // 参照型なので、値の代入が呼び出し元に反映される
            value = 99;
        }

        // outキーワードを使用した例

        // outキーワードで修飾された変数valueは、GetValueOutメソッド内で値を渡すために使用することができる。
        // しかし、GetValueOutメソッド内で変数valueの値を取得することはできない。
        static void GetValueOut(out int value)
        {
            value = 5;
        }
    }
}
