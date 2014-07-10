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
        private void butt_check_num_Click(object sender, EventArgs e)
        {
            // 文字列が入力されていない場合
            if (text_input.Text == "")
            {
                MessageBox.Show("文字を入力してください。");
                text_input.Focus();
                return;
            }

            // 文字列が数値かどうかをチェックする
            if (Validation.IsNumeric(text_input.Text))
            {
                MessageBox.Show("数値です。");
                return;
            }
            else
            {
                MessageBox.Show("数値ではありません。");
                return;
            }
        }

        private void butt_check_date_Click(object sender, EventArgs e)
        {
            // 年月日
            int int_year;
            int int_month;
            int int_day;

            bool bool_year;
            bool bool_month;
            bool bool_day;

            // 文字列が入力されていない場合
            if (text_input.Text == "")
            {
                MessageBox.Show("文字を入力してください。");
                text_input.Focus();
                return;
            }

            // 入力された数値が8桁の場合 : 入力された8桁の数値が日付かどうかチェック
            if (text_input.Text.Length == 8)
            {
                bool_year = int.TryParse(text_input.Text.Substring(0,4), System.Globalization.NumberStyles.Any, null, out int_year);
                bool_month = int.TryParse(text_input.Text.Substring(4,2), System.Globalization.NumberStyles.Any, null, out int_month);
                bool_day = int.TryParse(text_input.Text.Substring(6,2), System.Globalization.NumberStyles.Any, null, out int_day);

                if (bool_year && bool_month && bool_day)
                {
                    if (Validation.IsDate(int_year, int_month, int_day))
                    {
                        MessageBox.Show("正しい日付です。");
                    }
                    else
                    {
                        MessageBox.Show("正しい日付ではありません。");
                    }
                }
                else
                {
                    MessageBox.Show("日付の中に文字が含まれています。");
                }
            }
            else
            {
                MessageBox.Show("8桁の数値を入力してください。例) 20140710");
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

        #region　IsDate メソッド

        /// ------------------------------------------------------------------------------
        /// <summary>
        ///     指定した年・月・日が正しい日付であるかどうかを返します。</summary>
        /// <param name="iYear">
        ///     検査対象となる年。</param>
        /// <param name="iMonth">
        ///     検査対象となる月。</param>
        /// <param name="iDay">
        ///     検査対象となる日。</param>
        /// <returns>
        ///     指定した年・月・日が正しい日付であれば true。それ以外は false。</returns>
        /// ------------------------------------------------------------------------------
        public static bool IsDate(int iYear, int iMonth, int iDay)
        {
            if ((DateTime.MinValue.Year > iYear) || (iYear > DateTime.MaxValue.Year))
            {
                return false;
            }

            if ((DateTime.MinValue.Month > iMonth) || (iMonth > DateTime.MaxValue.Month))
            {
                return false;
            }

            int iLastDay = DateTime.DaysInMonth(iYear, iMonth);

            if ((DateTime.MinValue.Day > iDay) || (iDay > iLastDay))
            {
                return false;
            }

            return true;
        }

        #endregion

    }
}