using System;

namespace ireko_ni_sareta_kata
{
    class Program
    {
        // 入れ子にされた型
        // SampleクラスはProgramクラスの中だけで使用できる
        class Sample
        {
            // 自動プロパティ
            // 値を保持するためのフィールド変数の宣言、getアクセサー、setアクセサーの記述を省略できる
            public string Name { get; set; }
            public int Price { get; set; }

            public void Show()
            {
                Console.Write(Name);
                Console.Write(" ￥");
                Console.Write(Price);
            }
        }

        static void Main(string[] args)
        {
            // 同じクラスのメンバーであれば、Sampleクラスを一般的に宣言されたクラスと同様に使用できる
            Sample a = new Sample();

            a.Name = "焼きそばパン";
            a.Price = 150;
            a.Show();
            
            Console.ReadLine();
        }
    }
}
