using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace list_of_mammals
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_mammals());
        }
    }
}
