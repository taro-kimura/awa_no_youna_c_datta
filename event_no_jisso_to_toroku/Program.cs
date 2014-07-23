using System;

namespace event_no_jisso_to_toroku
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample x = new Sample();

            // x.Valueが変更されたとき、"!?"を表示するイベント
            x.ValueChanged += (s, e) => Console.Write("!?");

            // イベント実行前
            Console.ReadLine();

            // 値の変更 -> イベントの実行
            x.Value = 1;

            Console.ReadLine();
        }
    }

    class Sample
    {
        public event EventHandler ValueChanged;
        private int _value = 0;
        public int Value
        {
            get{return _value;}
            set
            {
                _value = value;
                if (ValueChanged == null) return;
                ValueChanged(this,EventArgs.Empty);
            }
        }
    }
}
