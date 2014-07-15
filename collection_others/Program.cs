using System;
using System.Collections;

namespace collection_others
{
    class Program
    {
        static void Main(string[] args)
        {
            // BitArray
            Console.WriteLine("---BitArrayクラス---");

            // BitArrayクラスは、ビット値(bool型)の配列を管理する
            BitArray a = new BitArray(8);
            
            // 要素数5にtrueを代入
            a[5] = true;
            
            // 初期値はfalseらしい
            Console.WriteLine(a[3]);

            Console.WriteLine(a[5]);

            // Hashtable
            Console.WriteLine("---Hashtableクラス---");

            // Hashtableクラスは、キーのハッシュコードに基づいて編成された、キーと値のペアとした要素のコレクション
            Hashtable b = new Hashtable();

            b.Add("Red", "あか");
            b.Add("Yellow", "きいろ");
            b.Add("Blue","あお");
            
            // キーを指定して出力
            Console.WriteLine(b["Yellow"]);
            Console.WriteLine(b["Blue"]);
            Console.WriteLine(b["Red"]);

            // SortedList
            Console.WriteLine("---SortedListクラス---");

            // SortedListクラスは、キーと値のペアのコレクション。
            // 要素はキーによって並べ替えられ、キーとインデックスを使ってアクセスすることができる
            SortedList c = new SortedList();

            c.Add("Red", "あか");
            c.Add("Yellow", "きいろ");
            c.Add("Blue", "あお");

            // キーによって値を取得
            Console.WriteLine(c["Red"]);


            for (var i = 0; i < c.Count; i++)
            {
                // インデックスを用いてキーを取得
                Console.Write(c.GetKey(i));

                Console.Write(":");

                // インデックスを用いて値を取得
                Console.WriteLine(c.GetByIndex(i));
            }

            // Queue
            Console.WriteLine("---Queueクラス---");

            // Queueクラスは、先入れ先出しコレクション
            Queue d = new Queue();

            // 要素を追加: EnqueueメソッドはQueueインスタンスの末尾に要素を追加する
            d.Enqueue("むかしむかし");
            d.Enqueue("あるところに");
            d.Enqueue("おじいさんと");
            d.Enqueue("おばあさんが");

            // 要素を取り出す: DequeueメソッドはQueueインスタンスの先頭から要素を取り出す
            Console.WriteLine(d.Dequeue());
            Console.WriteLine(d.Dequeue());
            Console.WriteLine(d.Dequeue());
            Console.WriteLine(d.Dequeue());

            // Stack
            Console.WriteLine("---Stackクラス---");

            // Stackクラスは、後入れ先出しコレクション
            Stack e = new Stack();

            // 要素を追加: Pushメソッドは、Stackインスタンスの先頭に要素を追加する
            e.Push("むかしむかし");
            e.Push("あるところに");
            e.Push("おじいさんと");
            e.Push("おばあさんが");

            // 要素を取り出す: Popメソッドは、Stackオブジェクトの先頭から要素を取り出す
            Console.WriteLine(e.Pop());
            Console.WriteLine(e.Pop());
            Console.WriteLine(e.Pop());
            Console.WriteLine(e.Pop());

            // Popによって取り出された要素は削除される
            Console.WriteLine(e.Count.ToString());

            // [Enter]で終了
            Console.ReadLine();
        }
    }
}
