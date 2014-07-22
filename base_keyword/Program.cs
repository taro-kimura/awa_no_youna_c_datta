using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace base_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            HighWay x = new HighWay();

            // 実行順序
            // ①Wayクラスのコンストラクタ呼出
            // ②HighWayクラスのコンストラクタ呼出
            Console.WriteLine(x.Speed);
            Console.ReadLine();
        }
    }

    class HighWay : Way
    {
        // 基本クラスのインスタンスにアクセスするには、baseキーワードを使用する
        // baseキーワードには基本クラスのインスタンスへの参照が格納されている
        public HighWay() : base()
        {
            Speed += "必要はない";
        }
    }

    class Way
    {
        public Way()
        {
            Speed = "ゆっくり走る";
        }

        public string Speed { get; protected set; }
    }
}
