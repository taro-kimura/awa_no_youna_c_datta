using System;

namespace property_and_method
{
    class Program
    {
        static void Main(string[] args)
        {
            // オブジェクト初期化子を使用して、Depthプロパティの値を設定
            Recurrence x = new Recurrence { Depth = 8 };
            x.Execute();
            Console.ReadLine();
        }
    }

    class Recurrence
    {
        public int Depth { get; set; }
        public void Execute() { Stack(0); }
        private void Stack(int value)
        {
            ++value;

            // 変数valueの値がDepthプロパティの値が小さい場合: 実行
            Show(value);
            
            // 再帰処理 : 自分自身を呼び出すこと
            // ここでは、Stackメソッドブロック内で、さらにStackメソッドを呼び出している
            if (value < Depth) Stack(value);

            // 変数valueの値がDepthプロパティの値より大きくなった場合: 実行
            Show(value);

        }
        private void Show(int value)
        {
            for (int i = 0; i < value; ++i)
            {
                Console.Write("○");
            }

            Console.WriteLine();
        }
    }
    // 処理の詳細 (デクリメントしていないのに、valueが1ずつ減っていく理由)

    //mainメソッド
    //┌
    //│→呼出
    //│　Stackメソッド
    //│　┌
    //│　│このメソッド内のvalueは、0で初期化
    //│　│++value
    //│　│このメソッド内のvalueは、１に変化。
    //│　│→25行目のShow()呼出
    //│　│　Stackメソッド
    //～  ～
    //│　│　┌
    //│　│　│このメソッド内のvalueは、７で初期化
    //│　│　│++value
    //│　│　│このメソッド内のvalueは、８に変化。
    //│　│　│→25行目のShow()呼出
    //│　│　│
    //│　│　│←戻り
    //│　│　｜このメソッド内のvalueは、８のまま
    //│　│　│→32行目のShow()呼出
    //│　│　└
    //～  ～
    //│　│←戻り
    //│　｜このメソッド内のvalueは、１のまま
    //│　│→32行目のShow()呼出
    //│　└
    //│←戻り
    //└
}
