using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generic_gata_no_seiyaku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Min(1, 2));
            Console.WriteLine(Min(3, 2));
            Console.WriteLine(Min(3, 6));
            Console.WriteLine(Min(8, 4));
            Console.ReadLine();
        }

        // IComparable制約を指定
        // 制約を指定することにより、
        // T型として宣言されている引数には、
        // IComparableインターフェイスを実装している型だけが指定できるようになる
        static T Min<T>(T v1, T v2) where T : IComparable
        {
            // ComparableToメソッドは、「自身の値」と「引数の値」を比較して、
            // 同じなら0を、自身のほうが小さければ-1を、自身の値が大きければ1を返す
            return v1.CompareTo(v2) < 0 ? v1 : v2;
        }
    }
}
