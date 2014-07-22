using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chusho_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new SpadeAce();
            card.Show();
        }
    }

    // 抽象クラス
    // Cardクラスは、派生クラスを宣言することによって、
    // スペードのエース以外にもスペードのキングやハートのクイーンなど、
    // 複数のマークと数を表現することができる
    abstract class Card
    {
        // マークと数を表すプロパティが抽象化されている
        // 抽象化されたクラスやメンバーの宣言は、abstractキーワードで修飾される
        abstract public string Mark { get; }
        abstract public string Number { get; }
        public void Show()
        {
            Console.Write(Mark);
            Console.Write(Number);
            Console.ReadLine();
        }
    }

    // Cardクラスを継承した派生クラス
    // SpaceAceクラスは「スペードのエース」という特定のマークと数しか表現できない
    class SpadeAce : Card
    {
        public override string Mark
        {
            get { return "スペード"; }
        }

        public override string Number
        {
            get { return "A"; }
        }
    }
}
