using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jag_hairetsu
{
    class Program
    {
        static void Main(string[] args)
        {
            // ジャグ配列を宣言 : 一般的な配列変数であることを表す[]の後、さらに[]を重ねて記述する
            int[][] a = new int[3][]
            {
            　// ジャグ配列aに値を格納
              new int[] {1},
              new int[] {2,3,4},
              new int[] {6,7,8,9}
            };

            for (int i = 0; i < a.Length; i++)
            {
                // ジャグ配列aの要素数
                Console.Write(i.ToString() + ":");

                for (int j = 0; j < a[i].Length; j++)
                {
                    // aに格納された配列を列挙
                    Console.Write(a[i][j] + " ");
                }

                Console.WriteLine();
            }
            // [Enter]でコンソールを閉じる
            Console.ReadLine();
        }
    }
}
