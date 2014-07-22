using System;

namespace override_to_impei
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();

            // A型の変数aにB型の変数bを代入している
            A a = b;

            // BクラスのCメソッドが実行される
            Console.WriteLine(a.C());

            // AクラスのDメソッドが実行される
            // -> Aクラスに実装され、隠ぺいされていたメソッドが実行される
            Console.WriteLine(a.D());

            // BクラスのCメソッドが実行される
            Console.WriteLine(b.C());

            // BクラスのDメソッドが実行される
            Console.WriteLine(b.D());

            Console.ReadLine();
        }
    }

    // Bクラスの基本クラス
    class A
    {
        // virtualキーワードで修飾
        public virtual string C() { return "A / C"; }

        // virtualキーワードで修飾していない
        public string D() { return "A / D"; }
    }

    class B : A
    {
        // Cメソッドは、Aクラスの宣言時にvirtualキーワードで修飾しているため、
        // Bクラスの宣言ではoverrideキーワードで修飾している
        public override string C(){ return "B / C"; }

        // Bクラスの宣言ではnewによって基本クラスのDメソッドを隠ぺいしている
        public new string D() { return "B / D"; }
    }
}
