/*
 * Created by SharpDevelop.
 * User: taro_kimura
 * Date: 2014/06/26
 * Time: 13:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;

namespace Hubble
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{		
		public MainForm()
		{
			InitializeComponent();
			this.ActiveControl = this.distance;
		}
		
		// 数値・小数点・制御文字以外は入力不可
		private void VelocitiesKeyPress(object sender, KeyPressEventArgs e)
		{

			// 数値・制御文字は入力可
    		if (TFKeyPress(e.KeyChar))
    		{
    			e.Handled = false;
        		return;
    		}
 
    		// 小数点は１つだけ入力可
    		if ( e.KeyChar == '.')
    		{
        		TextBox target = sender as TextBox;
        		
        		// 複数のピリオド入力はNG
        		if ( target.Text.IndexOf('.') < 0 )
        		{
            		e.Handled = false;
            		return;
        		}
    		}
    		// 先頭のみ符号入力可
    		if (e.KeyChar == '-' && this.velocities.SelectionStart==0 && !this.velocities.Text.StartsWith("-"))
    		{
    			e.Handled = false;
            	return;
    		}
 
    		// 上記以外は入力不可
    		e.Handled = true;
		}
		
		// 数値・小数点・制御文字以外は入力不可
		private void DistanceKeyPress(object sender, KeyPressEventArgs e)
		{
    		
    		// 数値・制御文字は入力可
    		if (TFKeyPress(e.KeyChar))
    		{
    			e.Handled = false;
        		return;
    		}
 
    		// 小数点は１つだけ入力可
    		if ( e.KeyChar == '.')
    		{
        		TextBox target = sender as TextBox;
        		if ( target.Text.IndexOf('.') < 0 )
        		{
            		// 複数のピリオド入力はNG
            		e.Handled = false;
            		return;
        		}
    		}
    		
    		// 先頭のみ符号入力可
    		if (e.KeyChar == '-' && this.distance.SelectionStart==0 && !this.distance.Text.StartsWith("-"))
    		{
    			e.Handled = false;
            	return;
    		}
 
    		// 上記以外は入力不可
    		e.Handled = true;
		}
		
		// 数値・制御文字 : true
		public bool TFKeyPress(char chr_key)
		{
			bool tfkey = false;
			
			// 制御文字は入力可
    		if (char.IsControl(chr_key))
    		{
        		tfkey = true;
    		}
 
    		// 数字(0-9)は入力可
    		if (char.IsDigit(chr_key))
    		{
        		tfkey = true;
    		}
    		return tfkey;
		}
		
		private void CloseClick(object sender, EventArgs e)
		{
			// データの保存
			
			//メッセージボックスを表示する
			DialogResult result = MessageBox.Show("データを保存しますか？",
			                                      "確認",MessageBoxButtons.YesNoCancel,
			                                      MessageBoxIcon.Question,
			                                      MessageBoxDefaultButton.Button2);

			//「はい」が選択された時
			if (result == DialogResult.Yes)
			{
				// 全データ数 n
				int n = listView1.Items.Count;
			
				// n = 0の場合 : メッセージを表示して閉じる
				if (n == 0)
				{
					MessageBox.Show("保存できるデータがありません。",
					"エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
					this.Close();
					
				}
				
				// 書き込むテキストファイルが入っているディレクトリ
				string full_path_dir = System.IO.Path.GetFullPath(@"./data");
				
				//SaveFileDialogクラスのインスタンスを作成
				SaveFileDialog sfd = new SaveFileDialog();
				
				// 書き込むファイルのフルパス取得
				
				//はじめに「ファイル名」で表示される文字列を指定する
				sfd.FileName = "hubble.csv";
				
				//指定しない（空の）文字列の場合 : full_path_dirで指定したフォルダ名を表示
				sfd.InitialDirectory = full_path_dir;
				
				//[ファイルの種類]に表示される選択肢を指定する
				sfd.Filter = "csvファイル(*.csv)|*.csv";
				
				//[ファイルの種類]ではじめに「テキストファイル」が選択されているようにする
				sfd.FilterIndex = 1;
				
				//タイトルを設定する
				sfd.Title = "data";
				
				//ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
				sfd.RestoreDirectory = true;

				//存在しないパスが指定されたとき警告を表示する
				sfd.CheckPathExists = true;
				
				//既に存在するファイル名を指定しても警告しない
				sfd.OverwritePrompt = false;
				
				//ダイアログを表示する
				if (sfd.ShowDialog() == DialogResult.OK)
				{
					
					// 既に存在するファイル名を選択した場合 : 古いファイルを削除して新しく生成
					if (File.Exists(sfd.FileName))
					{
						// 古いファイルを削除
						System.IO.File.Delete(sfd.FileName);
					}
					
					// 一行ずつ書き込み (追記)
					StreamWriter sw = new StreamWriter(sfd.FileName, true);
					
					// 平均値を求める
					for (int i = 0; i < n; i++)
					{
						sw.WriteLine(listView1.Items[i].Text + "," + listView1.Items[i].SubItems[1].Text);
					}
					
					sw.Close();
					MessageBox.Show("データを保存しまうま。",
					"結果",MessageBoxButtons.OK,MessageBoxIcon.Information);
					
				}
			}
			
			//自分自身のフォームがメインフォームの時、
			//自分自身のフォームをCloseメソッドで閉じると、アプリケーションが終了する
			this.Close();
		
		}
		
		private void ReadClick(object sender, EventArgs e)
		{	
			// double型に変換した値を格納する変数
			double dbl_X = 0;	// distance in units of 10^6 parsecs
			double dbl_Y = 0;	// measured velocities in km/sec
			
			// 読み込むテキストファイルが入っているディレクトリ
			string full_path_dir = System.IO.Path.GetFullPath(@"./data");
			
			// 読み込んだ一行を格納する変数
			string line = "";
			
			//OpenFileDialogクラスのインスタンスを作成
			OpenFileDialog ofd = new OpenFileDialog();
			
			//はじめに「ファイル名」で表示される文字列を指定する
			ofd.FileName = "hubble.csv";
			
			//指定しない（空の）文字列の場合 : full_path_dirで指定したフォルダ名を表示
			ofd.InitialDirectory = full_path_dir;
			
			//[ファイルの種類]に表示される選択肢を指定する
			ofd.Filter = "csvファイル(*.csv)|*.csv";
			
			//[ファイルの種類]ではじめに「テキストファイル」が選択されているようにする
			ofd.FilterIndex = 1;
			
			//タイトルを設定する
			ofd.Title = "data";
			
			//ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
			ofd.RestoreDirectory = true;

			//存在しないパスが指定されたとき警告を表示する
			ofd.CheckPathExists = true;
			
			//存在しないファイルの名前が指定されたとき警告を表示する
			ofd.CheckFileExists = true;
			
			//ダイアログを表示する
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				
				// OKボタンがクリックされた場合 : 選択されたファイルを読み込む
				using (StreamReader sr = new StreamReader(ofd.FileName))
				{
					// 一行ずつ読み込み
					while ((line = sr.ReadLine()) != null)
					{
						// 配列 arrXY に取得したデータを格納
						// -> arrXY[0] = distance in units of 10^6 parsecs
						// -> arrXY[1] = measured velocities in km/sec
						string[] arrXY = line.Split(',');
						
						// arrXY の要素が2個ある時 : true
						if (arrXY.Length == 2)
						{
							if (ConvertDouble(arrXY[0], ref dbl_X) && ConvertDouble(arrXY[1], ref dbl_Y))
							{
								// ListView に追加
								insertListView(dbl_X, dbl_Y);
							}
						}
					}
					
					sr.Close();
					
				}
			}
		}
		
		private void InsertClick(object sender, EventArgs e)
		{
			double dbl_distance = 0;	// distance in units of 10^6 parsecs
			double dbl_velocities = 0;	// measured velocities in km/sec
			
			// string型 >> double型に変換可能 : true
			bool flg_distance = ConvertDouble(distance.Text, ref dbl_distance);
			bool flg_velocities = ConvertDouble(velocities.Text, ref dbl_velocities);
			
			if (flg_distance && flg_velocities)
			{
				// ListViewに追加
				insertListView(dbl_distance, dbl_velocities);
				
				// TextBoxの初期化
				distance.Text = "";
				velocities.Text = "";
				
				// テキストボックス distance にフォーカスを設定
				distance.Focus();
				
				// メソッド終了
				return;
			}
			
			// velocities.Textがdouble型に変換不可
			if (flg_velocities == false)
			{
				velocities.Text = "";
				velocities.Focus();
			}
			
			// distance.Textがdouble型に変換不可
			if (flg_distance == false)
			{
				distance.Text = "";
				distance.Focus();
			}
		}
		
		public bool ConvertDouble(string str_text, ref double dbl_data)
		{
			// string型 >> double型に変換可能 : true
			bool flg_convert = false;
			
			//velocities.Textがdouble型に変換できる場合 : true
			if (double.TryParse(str_text, out dbl_data))
			{
				flg_convert = true;
			}
			
			return flg_convert;
		}
		
		// ListViewに値を追加 (テキストボックス内の数値がdouble型に変換可能の場合のみ)
		public bool insertListView(double X, double Y)
		{
			// ListViewに追加した場合 : true
			bool flg_insert = false;
				
			// ListViewに追加
			ListViewItem item1 = listView1.Items.Add(X.ToString());
			item1.SubItems.Add(Y.ToString());
			listView1.EnsureVisible(listView1.Items.Count - 1);
			
			return flg_insert;
		}
		
		private void Text_clearClick(object sender, EventArgs e)
		{
			distance.Text = "";
			velocities.Text = "";			
		}
		
		private void List_clearClick(object sender, EventArgs e)
		{
			listView1.Items.Clear();		
		}
		
		private void DeleteClick(object sender, EventArgs e)
		{
			// 選択されているリストを取得しリストビューから削除する
    		foreach (ListViewItem item in listView1.SelectedItems)
    		{
        		listView1.Items.Remove(item);
    		}			
		}
		
		private void CalculateClick(object sender, EventArgs e)
		{
			// 回帰直線 : Y = aX + b (a, bは定数)
			
			// 傾きa
			double a = 0;
			
			//切片b
			double b = 0;
			
			// 平均値
			double avg_x = 0;
			double avg_y = 0;
			
			// c2
			double avg_c2_x = 0;
			double avg_c2_y = 0;
			double avg_c2_xy = 0;
			
			// c2の平方根
			double root_c2_x = 0;
			double root_c2_y = 0;
			
			// 相関係数r
			double r = 0;
			
			// n(全データ数)を求める
			int n = listView1.Items.Count;
			
			// n = 0の場合 : 計算終了
			if (n == 0)
			{
				MessageBox.Show("データがありません。入力して下さい。",
				                "エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
				distance.Focus();
				return;
			}
			else
			{	
				// 平均値を求める
				for (int i = 0; i < n; i++)
				{
        			avg_x += Convert.ToDouble(listView1.Items[i].Text);
        			avg_y += Convert.ToDouble(listView1.Items[i].SubItems[1].Text);
				}
				 
				 avg_x = avg_x / n;
				 avg_y = avg_y / n;
				 	
				// c2を求める
				for (int i = 0; i < n; i++)
				{
					avg_c2_x += (Convert.ToDouble(listView1.Items[i].Text) - avg_x) * (Convert.ToDouble(listView1.Items[i].Text) - avg_x);
					avg_c2_y += (Convert.ToDouble(listView1.Items[i].SubItems[1].Text) - avg_y) * (Convert.ToDouble(listView1.Items[i].SubItems[1].Text) - avg_y);
				}
				
				avg_c2_x = avg_c2_x / n;
				avg_c2_y = avg_c2_y / n;
				
				if (avg_c2_x == 0)
				{
					MessageBox.Show("データが不足しています。入力を続けてください。",
					                "エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
					distance.Focus();
					return;
				}
				else
				{	
					
					for (int i =0; i < n; i++)
					{
						avg_c2_xy += (Convert.ToDouble(listView1.Items[i].Text) - avg_x) * (Convert.ToDouble(listView1.Items[i].SubItems[1].Text) - avg_y);
					}
					
					// c2_xyの平均値
					avg_c2_xy = avg_c2_xy / n;
					
					// 回帰直線 Y = aX + b を求める
					a = avg_c2_xy / avg_c2_x;
					b = avg_y - (a * avg_x);
					
					if (avg_c2_y == 0)
					{
						MessageBox.Show("このデータには数学的な問題があります。",
						                "エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
						distance.Focus();
						return;
					}
					else
					{
						// 相関係数 r を求める
						root_c2_x = Math.Sqrt(avg_c2_x);
						root_c2_y = Math.Sqrt(avg_c2_y);
							
						r = avg_c2_xy / (root_c2_x * root_c2_y);
						
						// rの絶対値を求める
						r = Math.Abs(r);
						
						if (1.0 >= r && r >= 0.7)
						{
							MessageBox.Show("間違いなく、宇宙は膨張しているでしょう！");
							distance.Focus();
							return;
						}
						else if (0.7 > r && r >= 0.5)
						{
							MessageBox.Show("ほぼ間違いなく、宇宙は膨張しているでしょう！");
							distance.Focus();
							return;
						}
						else if (0.5 > r && r >= 0.4)
						{
							MessageBox.Show("おそらく、宇宙は膨張しているでしょう！");
							distance.Focus();
							return;
						}
						else if (0.4 > r && r >= 0.3)
						{
							MessageBox.Show("きっと、宇宙は膨張しているでしょう！");
							distance.Focus();
							return;
						}
						else if (0.3 > r && r >= 0.2)
 						{
							MessageBox.Show("宇宙は膨張しているかもしれません。");
							distance.Focus();
							return;
						}
						else if (0.2 > r && r >= 0)
						{
							MessageBox.Show("宇宙は膨張していないと思います。");
							distance.Focus();
							return;
						}
						else
						{
							MessageBox.Show("相関係数 r = " + r.ToString());
							distance.Focus();
							return;
						}
						
					}
				}
			}
		}
		
		void ListView1Click(object sender, EventArgs e)
		{
			// 選択されているリストを取得し、テキストボックスに表示する
    		foreach (ListViewItem item in listView1.SelectedItems)
    		{
        		distance.Text = item.Text;
        		velocities.Text = item.SubItems[1].Text;
    		}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			// 選択されているリストを取得し、値を更新する
    		foreach (ListViewItem item in listView1.SelectedItems)
    		{
        		item.Text = distance.Text;
        		item.SubItems[1].Text = velocities.Text;
    		}			
		}
	}
}