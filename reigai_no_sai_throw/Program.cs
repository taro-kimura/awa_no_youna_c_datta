using System;

namespace reigai_no_sai_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // ReadData実行
                ReadData();
            }
            catch(Exception ex)
            {
                // キャッチした例外インスタンスのメッセージ
                Console.WriteLine(ex.Message);

                // 例外インスタンスに格納されている、
                // 例外元となった例外インスタンスのメッセージ
                Console.WriteLine(ex.InnerException.Message);
            }

            Console.ReadLine();

        }

        // AccessDatabaseメソッドを実行中に発生した例外をキャッチ
        static void ReadData()
        {
            try
            {
                AccessDatabase();
            }
            catch (Exception ex)
            {
                // Exception型の例外インスタンスを生成して再スローしている
                throw new Exception("アクセス失敗", ex);
            }
        }

        static void AccessDatabase()
        {
            throw new Exception("データベースが壊れています");
        }
    }
}
