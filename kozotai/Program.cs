using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kozotai
{
    class Program
    {
        static void Main(string[] args)
        {
            EchoClass ca = new EchoClass();
            EchoClass cb = ca;
            
            // 変数caのプロパティ値を変更
            ca.Value = 1;

            // クラスは参照型なので、
            // 変数caの値を変数cbにコピーすると
            // 変数caに格納されているヒープメモリへの参照がコピーされる
            // したがって、変数caのプロパティ値を変更すると
            // 変数cbのプロパティ値も変更される
            Console.WriteLine(ca.Value);
            Console.WriteLine(cb.Value);

            EchoStruct sa = new EchoStruct();
            EchoStruct sb = sa;

            // 変数saのプロパティ値を変更
            sa.Value = 2;

            // 構造体は値型なので、
            // 変数saの値を変数sbにコピーすると、
            // スタックメモリ上の実体がコピーされる
            // したがって、変数saのプロパティ値を変更しても、
            // 変数sbのプロパティ値が変わることはありません
            Console.WriteLine(sa.Value);
            Console.WriteLine(sb.Value);

            Console.ReadLine();
        }
    }

    // クラス
    public class EchoClass
    {
        public int Value { get; set; }
    }

    // 構造体
    public struct EchoStruct
    {
        public int Value { get; set; }
    }
}
