using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample a = new Sample();
            a.Method();
            Console.ReadLine();
        }
    }

    // publicキーワードはクラスとメンバの宣言時に修飾することができる
    public class Sample
    {
        // コンストラクタ
        public Sample() { }
        
        // メソッド

        // publicキーワードで修飾されたメンバはアクセスに制限はない
        public void Method()
        {
            // MethodメソッドとPropertyプロパティは
            // どちらもSampleクラスに記述されたメンバなので、
            // お互いにアクセスすることができる
            Property = 0;

            Console.WriteLine("カプセル化");
        }
        
        // プロパティ
        // privateキーワードで修飾されたメンバは、
        // メンバが宣言されているクラス、または構造体の内部からのみアクセス可能
        private int Property { get; set; }
    }
}
