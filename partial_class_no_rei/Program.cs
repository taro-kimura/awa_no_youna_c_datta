using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace partial_class_no_rei
{
    class Program
    {
        static void Main(string[] args)
        {
            Echo echo = new Echo();
            echo.Message = "パーシャルクラスとは、クラスの宣言を複数に分けて記述することのできる機能である。";
            echo.ShowMessage();
            Console.ReadLine();
        }
    }

    // partialキーワードで修飾されたクラスは複数宣言することができるが、
    // すべての宣言をpartialキーワードで修飾する必要がある。
    public partial class Echo
    {
        public string Message { get; set; }
    }

    public partial class Echo
    {
        public void ShowMessage()
        {
            Console.WriteLine(Message);
        }
    }
}
