using System;

namespace generic_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tupple<string, int>型のインスタンスを生成して、
            // 変数aに格納している
            // <string, int>という指定に準じて、
            // Value1プロパティはstring型、
            // Value2プロパティはint型の値を保持することができる
            Tupple<string, int> a = new Tupple<string,int>();
            
            a.Value1 = "いち";
            a.Value2 = 1;

            Console.WriteLine(a.Value1);
            Console.WriteLine(a.Value2);

            Console.WriteLine("-----------------------------");

            // <string, Tupple<string, int>>という指定に準じて、
            // Value1プロパティはstring型、
            // Value2プロパティはTupple<string, int>型になる
            Tupple<string, Tupple<string, int>> b = new Tupple<string,Tupple<string,int>>();

            b.Value1 = "に";
            b.Value2 = a;

            Console.WriteLine(b.Value1);

            // Value2には14行目で宣言した変数aが格納されている
            Console.WriteLine(b.Value2.Value1);
            Console.WriteLine(b.Value2.Value2);

            Console.ReadLine();
        }
    }

    // Tupple<T1, T2>ジェネリッククラスを宣言
    class Tupple<T1, T2>
    {
        // T1型の値を保持できるValue1プロパティ
        public T1 Value1 { get; set; }

        // T2型の値を保持できるValue2プロパティ
        public T2 Value2 { get; set; }
    }
}
