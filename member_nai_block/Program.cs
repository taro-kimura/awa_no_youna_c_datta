using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace member_nai_block
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new HighWay();

            // 実行順序
            // ①RunHighメソッドの呼出
            // ②baseキーワードによって、WayクラスのRunSlowメソッドを呼出
            x.RunHigh();

            Console.ReadLine();
        }
    }

    class HighWay : Way
    {
        public void RunHigh()
        {
            // baseキーワードを使用して基本クラスのメンバーを呼び出している
            base.RunSlow();
        }
    }

    class Way
    {
        public void RunSlow()
        {
            Console.WriteLine("ゆっくり走っています");
        }
    }
}
