using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace list_of_mammals
{
    public partial class form_mammals : Form
    {
        public form_mammals()
        {
            InitializeComponent();

            // 初期表示時に、霊長目の項目を選択
            this.comb_moku.SelectedIndex = 0;

            // 初期表示時に、霊長目の情報を表示
            for (int i = 0; i < 8; ++i)
            {
                Info info_reic = new Info(comb_moku.SelectedItem.ToString(), i);

                //アイテムをリスビューに追加する
                lv_name.Items.Add(info_reic.Name);
            }
        }

        private void comb_moku_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // ListViewの初期化
            lv_name.Items.Clear();

            // TextBoxの初期化
            text_taicho.Text = "";
            text_taiju.Text = "";
            text_bumpu.Text = "";

            for (int cnt = 0; cnt < 8; cnt++)
            {
                Info info_reic = new Info(comb_moku.SelectedItem.ToString(), cnt);

                //アイテムをリスビューに追加する
                lv_name.Items.Add(info_reic.Name);
            }
        }

        private void lv_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            int idx = 0;

            if (lv_name.SelectedItems.Count > 0)
            {
                idx = lv_name.SelectedItems[0].Index;
            }

            Info info_reic = new Info(comb_moku.SelectedItem.ToString(), idx);

            text_taicho.Text = info_reic.Taicho;
            text_taiju.Text = info_reic.Taiju;
            text_bumpu.Text = info_reic.Bumpu;
        }
    }

    public class Mammals
    {
        // 目
        public string moku;
        // 名前
        public int id;

        public Mammals(string moku, int id)
        {
            this.moku = moku;
            this.id = id;
        }

        public string Moku
          {
            set{this.moku = value;}
            get{return this.moku;}
          }

          public int Id
          {
            set{this.id = value;}
            get{return this.id;}
          }
    }

    public class Info : Mammals
    {
        // 名前
        private string name;
        // 体長
        private string taicho;
        // 体重
        private string taiju;
        // 分布
        private string bumpu;


        public Info(string moku, int id) : base(moku, id)
        {
           switch(moku)
           {
               case "霊長目":

                    switch(id)
                    {
                        case 0:

                            this.name = "ワオキツネザル";
                            this.taicho = "40-45cm";
                            this.taiju = "不明";
                            this.bumpu = "マダガスカル南部";

                            break;

                        case 1:

                            this.name = "アイアイ";
                            this.taicho = "40cm";
                            this.taiju = "不明";
                            this.bumpu = "マダガスカル";

                            break;

                        case 2:

                            this.name = "アビシニアコロブス";
                            this.taicho = "52-57cm";
                            this.taiju = "不明";
                            this.bumpu = "アフリカ中部";

                            break;

                        case 3:

                            this.name = "キンシコウ";
                            this.taicho = "50-85cm";
                            this.taiju = "10-18kg";
                            this.bumpu = "中国";

                            break;

                        case 4:

                            this.name = "シロテテナガザル";
                            this.taicho = "45-65cm";
                            this.taiju = "4.5-6kg";
                            this.bumpu = "アジア東南部";

                            break;

                        case 5:

                            this.name = "チンパンジー";
                            this.taicho = "70-90cm";
                            this.taiju = "25-70kg";
                            this.bumpu = "アフリカ";

                            break;

                        case 6:

                            this.name = "オランウータン";
                            this.taicho = "80-100cm";
                            this.taiju = "40-80kg";
                            this.bumpu = "スマトラ島、ボルネオ島";

                            break;

                        case 7:

                            this.name = "ゴリラ（ローランドゴリラ）";
                            this.taicho = "120cm";
                            this.taiju = "150-160kg";
                            this.bumpu = "アフリカ中央部";

                            break;

                    }

                    break;

               case "有袋目":

                    switch (id)
                    {
                        case 0:

                            this.name = "コアラ";
                            this.taicho = "60-80cm";
                            this.taiju = "8-12kg";
                            this.bumpu = "オーストラリア東部";

                            break;

                        case 1:

                            this.name = "ヒメウォンバット（オーストラリアウォンバット）";
                            this.taicho = "70-120cm";
                            this.taiju = "25-40kg";
                            this.bumpu = "オーストラリア東部、タスマニア";

                            break;

                        case 2:

                            this.name = "アカカンガルー";
                            this.taicho = "85-160cm";
                            this.taiju = "20-55kg";
                            this.bumpu = "オーストラリア";

                            break;

                        case 3:

                            this.name = "セスジキノボリカンガルー";
                            this.taicho = "55-75cm";
                            this.taiju = "7-9kg";
                            this.bumpu = "ニューギニア";

                            break;

                    }

                    break;

               case "貧歯目":

                    switch (id)
                    {
                        case 0:

                            this.name = "ホフマンナマケモノ";
                            this.taicho = "60-65cm";
                            this.taiju = "10kg前後";
                            this.bumpu = "中央･南アメリカ";

                            break;

                        case 1:

                            this.name = "ミナミコアリクイ";
                            this.taicho = "53-88cm";
                            this.taiju = "3.5-8.5kg";
                            this.bumpu = "南アメリカ";

                            break;

                        case 2:

                            this.name = "オオアリクイ";
                            this.taicho = "100-120cm";
                            this.taiju = "20-40kg";
                            this.bumpu = "中央･南アメリカ";

                            break;

                        case 3:

                            this.name = "マタコミツオビアルマジロ";
                            this.taicho = "22-27cm";
                            this.taiju = "1-1.6kg";
                            this.bumpu = "南アメリカ";

                            break;

                    }

                    break;
            }
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public string Taicho
        {
            set{this.taicho = value;}
            get{return this.taicho;}
        }

        public string Taiju
        {
            set { this.taiju = value; }
            get { return this.taiju; }
        }

        public string Bumpu
        {
            set { this.bumpu = value; }
            get { return this.bumpu; }
        }

    }
}
