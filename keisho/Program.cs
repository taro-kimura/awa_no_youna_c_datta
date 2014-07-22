using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace keisho
{
    class Program
    {
        static void Main(string[] args)
        {
            // InheritsClassクラスだけを使用する
            InheritsClass x = new InheritsClass();

            // BaseClassクラスのShowBaseメソッドを実行
            // InheritsClassクラスには、
            // ShowBaseメソッドが宣言されていないが、
            // BaseClassクラスを継承しているため、
            // ShowBaseメソッドを自身のクラスメンバーのように使用することができる
            x.ShowBase();

            // InheritsClassクラスのShowメソッドを実行
            x.Show();
            
            Console.ReadLine();
        }
    }

    class BaseClass
    {
        // ShowBaseメソッドだけを宣言している
        public void ShowBase()
        {
            Console.WriteLine("私は基本クラスのメンバーです");
        }
    }

    // BaseClassクラスを継承している
    class InheritsClass : BaseClass
    {
        // Showメソッドだけを宣言している
        public void Show()
        {
            ShowBase();
            Console.WriteLine("私は派生クラスのメンバーです");
        }
    }
}
