using System;

namespace constructor_and_destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Member m = new Member("Daiwa House");

            // 変数mにnull値を代入: 9行目で生成されたインスタンスを参照している変数がなくなる
            // しかし、この時点ではデストラクタは実行されない
            m = null;

            Console.ReadLine();

            // GCを明示的に呼び出して、デストラクタを実行
            // ただし、GCは処理コストが高いため、通常は明示的に呼び出さない
            GC.Collect();

            Console.ReadLine();
        }
    }

    class Member
    {
        // コンストラクタは、メソッドの構文とよく似ているが、
        // メソッド名をクラス名と同じにしなければならない点や
        // 戻り値の型を記述しないという点が異なる
        public Member(string name)
        {
            Name = name;
            Console.WriteLine(Name + "は生成されました");
        }

        // デストラクタはインスタンスの消滅時に呼び出される特別なメソッド
        // クラス名の直前に~(チルダ)を記述する　※引数もキーワードも記述することができない
        // 
        ~Member()
        {
            Console.WriteLine(Name + "は回収されました");
        }

        public string Name { get; set; }

    }
}
