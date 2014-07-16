using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample a = new Sample();
            
            // 直前で作成したSample型の変数aのインデクサを使用しているため、
            // 配列の要素にアクセスして値を格納するようにインデックスを使ってコードを記述できる
            a[0] = "いざわ";
            a[1] = "ふじもと";
            a[2] = "いとう";

            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine(a[i]);
            }

            Console.ReadLine();

        }
    }

    class Sample
    {
        // インデクサを通じて渡された値を格納するため、フィールドに配列変数を宣言
        private string[] a = new string[100];
        
        // インデクサを宣言

        // thisキーワードは自分自身のインスタンスへの参照が格納されている。
        // インデクサは、自分自身のインスタンスと[]内で指定された引数を受け取って、プロパティとして処理している。
        public string this[int i]
        {
            get
            {
                return a[i];
            }
            set
            {
                a[i] = value;
            }
        }

    }

}
