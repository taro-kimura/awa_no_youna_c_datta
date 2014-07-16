using System;

namespace property
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample x = new Sample();

            // xに変更を加えていない場合: getのみ通過する
            Console.WriteLine(x.Counter);

            ++x.Counter;    // ++ 演算子: インクリメント演算子 (++) では、オペランドが 1 ずつインクリメントされる

            // xに変更を加えた場合: get -> set -> getを通過する
            Console.WriteLine(x.Counter);

            Console.ReadLine();
        }
    }

    class Sample
    {
        // フィールド変数はクラス全体からアクセスすることができる
        private int _counter = -2;

        public int Counter
        {
            // getキーワード直後のブロックには、プロパティが値を返す際の処理を記述
            get
            {
                Console.WriteLine("getを通過");

                // getアクセサーはreturnステートメントによって値を返す
                return _counter;
            }

            // setキーワード直後のブロックには、プロパティに値を設定する際の処理を記述
            set
            {
                Console.WriteLine("setを通過");

                // setアクセサーは設定された値をvalueキーワードから取得する
                _counter = value < 0 ? 0 : value;   // ?: 演算子: 条件演算子 (?:) では、ブール式の値に応じて 2 つの値のいずれかが返される
            }
        }
    }
}
