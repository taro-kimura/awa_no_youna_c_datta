using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // データソースを作成
            var members = new[]
            {
                new { Name = "ゆきこ", Age = 32 },
                new { Name = "ようこ", Age = 8 },
                new { Name = "ひろし", Age = 11 }
            };

            // from : データソース（ここでは、members）の各要素を順に範囲変数（ここでは、p）に格納して、次の句(where)を処理する
            // where : 条件を演算した結果のブール値がtrue（ここでは、年齢が20歳未満）なら、次の句(select)を処理する
            // select : 列挙したい値を返す
            var q = from p in members where p.Age < 20 select p.Name;

            foreach(string x in q)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();

        }
    }
}
