using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace referee
{
    public partial class referee : Form
    {
        public referee()
        {
            InitializeComponent();
        }

        // [チェック]ボタンが押された場合 : TextBox内の文字列が数値かどうかチェックする。
        private void butt_check_Click(object sender, EventArgs e)
        {
            // 文字列が入力されていない場合
            if (text_input.Text == "")
            {
                MessageBox.Show("文字を入力してください");
                text_input.Focus();
                return;
            }

            // 文字列が数値かどうかをチェックする
            if (Validation.IsNumeric(text_input.Text))
            {
                MessageBox.Show("数値です");
                return;
            }
            else
            {
                MessageBox.Show("数値ではありません");
                return;
            }
        }

        private void butt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    /// -----------------------------------------------------------------------------
    /// <summary>
    ///     検証・エラーチェックをサポートした静的クラスです。
    /// </summary>
    /// -----------------------------------------------------------------------------

    public sealed class Validation
    {

        #region　IsNumeric メソッド (+1)

        /// -----------------------------------------------------------------------------
        /// <summary>
        ///     文字列が数値であるかどうかを返します。</summary>
        /// <param name="stTarget">
        ///     検査対象となる文字列。<param>
        /// <returns>
        ///     指定した文字列が数値であれば true。それ以外は false。</returns>
        /// -----------------------------------------------------------------------------
        public static bool IsNumeric(string stTarget)
        {
            double dNullable;
            bool flg_num;

            flg_num = double.TryParse(stTarget,System.Globalization.NumberStyles.Any,null,out dNullable);

            return flg_num;
        }

        #endregion

    }
}
