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

        static public int cnt_max = 22;

        public form_mammals()
        {
            InitializeComponent();

            // 初期表示時に、霊長目の項目を選択
            this.comb_moku.SelectedIndex = 0;

            // 初期表示時に、霊長目の情報を表示
            for (int cnt = 0; cnt < cnt_max; cnt++)
            {
                Info info_reic = new Info(comb_moku.SelectedItem.ToString(), cnt);

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

            for (int cnt = 0; cnt < cnt_max; cnt++)
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

               case "翼手目":

                    switch (id)
                    {
                        case 0:

                            this.name = "クビワオオコウモリ";
                            this.taicho = "19-25cm";
                            this.taiju = "不明";
                            this.bumpu = "分布　日本（南西諸島）、台湾";

                            break;
                    }

                    break;

               case "クジラ目":

                    switch (id)
                    {
                        case 0:

                            this.name = "バンドウイルカ（ハンドウイルカ）";
                            this.taicho = "190-400cm";
                            this.taiju = "150-650kg";
                            this.bumpu = "世界中の温帯～熱帯海域";

                            break;
                    }

                    break;

               case "食肉目":

                    switch (id)
                    {
                        case 0:

                            this.name = "オオカミ（タイリクオオカミ）";
                            this.taicho = "100-160cm";
                            this.taiju = "20-80kg";
                            this.bumpu = "ユーラシア、北アメリカ、中近東など、北半球に広く分布";

                            break;

                        case 1:

                            this.name = "ヒグマ（エゾヒグマ）";
                            this.taicho = "200-230cm";
                            this.taiju = "150-250kg";
                            this.bumpu = "北海道";

                            break;

                        case 2:

                            this.name = "マレーグマ";
                            this.taicho = "100-140cm";
                            this.taiju = "27-65kg";
                            this.bumpu = "東南アジア";

                            break;

                        case 3:

                            this.name = "メガネグマ";
                            this.taicho = "130-210cm";
                            this.taiju = "27-65kg";
                            this.bumpu = "南アメリカ";

                            break;

                        case 4:

                            this.name = "ホッキョクグマ（シロクマ）";
                            this.taicho = "180-250cm";
                            this.taiju = "150-800kg";
                            this.bumpu = "北極圏とその周辺";

                            break;

                        case 5:

                            this.name = "パンダ（ジャイアントパンダ）";
                            this.taicho = "120-150cm";
                            this.taiju = "75-160kg";
                            this.bumpu = "中国";

                            break;

                        case 6:

                            this.name = "レッサーパンダ";
                            this.taicho = "50-65cm";
                            this.taiju = "4-6kg";
                            this.bumpu = "中央アジア";

                            break;

                        case 7:

                            this.name = "コツメカワウソ";
                            this.taicho = "45-60cm";
                            this.taiju = "1-5kg";
                            this.bumpu = "南アジア、東南アジア";

                            break;

                        case 8:

                            this.name = "ラッコ";
                            this.taicho = "75-120cm";
                            this.taiju = "13-45kg";
                            this.bumpu = "北太平洋";

                            break;

                        case 9:

                            this.name = "シママングース";
                            this.taicho = "30-45cm";
                            this.taiju = "不明";
                            this.bumpu = "アフリカ";

                            break;

                        case 10:

                            this.name = "ミーアキャット";
                            this.taicho = "25-35cm";
                            this.taiju = "不明";
                            this.bumpu = "アフリカ南西部";

                            break;

                        case 11:

                            this.name = "ブチハイエナ";
                            this.taicho = "130cm前後";
                            this.taiju = "不明";
                            this.bumpu = "アフリカ（サハラ砂漠以南）";

                            break;

                        case 12:

                            this.name = "サーバル";
                            this.taicho = "60-100cm";
                            this.taiju = "9-18kg";
                            this.bumpu = "アフリカ（サハラ砂漠以南）";

                            break;

                        case 13:

                            this.name = "ピューマ（クーガー、アメリカライオン）";
                            this.taicho = "110-200cm";
                            this.taiju = "70-105kg";
                            this.bumpu = "北アメリカ、中央アメリカ、南アメリカ";

                            break;

                        case 14:

                            this.name = "ウンピョウ";
                            this.taicho = "60-110cm";
                            this.taiju = "16-23kg";
                            this.bumpu = "東南アジア";

                            break;

                        case 15:

                            this.name = "ライオン";
                            this.taicho = "140-250cm";
                            this.taiju = "120-250kg";
                            this.bumpu = "アフリカ、インド北西部";

                            break;

                        case 16:

                            this.name = "トラ";
                            this.taicho = "140-280cm";
                            this.taiju = "120-250kg";
                            this.bumpu = "アジア中部～東部";

                            break;

                        case 17:

                            this.name = "ジャガー";
                            this.taicho = "110-185cm";
                            this.taiju = "40-160kg";
                            this.bumpu = "北アメリカ南部、中央アメリカ、南アメリカ";

                            break;

                        case 18:

                            this.name = "ヒョウ";
                            this.taicho = "90-190cm";
                            this.taiju = "37-90kg";
                            this.bumpu = "アフリカ、アジア";

                            break;

                        case 19:

                            this.name = "チーター";
                            this.taicho = "110-150cm";
                            this.taiju = "20-70kg";
                            this.bumpu = "アフリカ、アジア西部";

                            break;

                        case 20:

                            this.name = "カリフォルニアアシカ";
                            this.taicho = "220cm（オス）　180cm（メス）";
                            this.taiju = "300kg（オス）";
                            this.bumpu = "太平洋東部沿岸";

                            break;

                        case 21:

                            this.name = "ゴマフアザラシ";
                            this.taicho = "～180cm";
                            this.taiju = "～150kg";
                            this.bumpu = "ベーリング海～オホーツク海";

                            break;

                    }

                    break;

               case "長鼻目":

                    switch (id)
                    {
                        case 0:

                            this.name = "ゾウ（アジアゾウ）";
                            this.taicho = "550-640cm";
                            this.taiju = "2700-5400kg";
                            this.bumpu = "インド～東南アジア、中国南部";

                            break;
                    }

                    break;

               case "海牛目":

                    switch (id)
                    {
                        case 0:

                            this.name = "ジュゴン";
                            this.taicho = "400cm";
                            this.taiju = "230-900kg";
                            this.bumpu = "インド洋～太平洋南西部沿岸";

                            break;
                    }

                    break;

               case "奇蹄目":

                    switch (id)
                    {
                        case 0:

                            this.name = "モウコノウマ";
                            this.taicho = "220-260cm";
                            this.taiju = "200-300kg";
                            this.bumpu = "アジア中央部（野生のものは絶滅）";

                            break;

                        case 1:

                            this.name = "シマウマ（サバンナシマウマ）";
                            this.taicho = "240cm";
                            this.taiju = "300kg";
                            this.bumpu = "アフリカ";

                            break;

                        case 2:

                            this.name = "マレーバク";
                            this.taicho = "185-240cm";
                            this.taiju = "250-365kg";
                            this.bumpu = "東南アジア";

                            break;

                        case 3:

                            this.name = "クロサイ";
                            this.taicho = "295-375cm";
                            this.taiju = "800-1400kg";
                            this.bumpu = "アフリカ";

                            break;
                    }

                    break;

               case "偶蹄目":

                    switch (id)
                    {
                        case 0:

                            this.name = "カバ";
                            this.taicho = "280-420cm";
                            this.taiju = "1350-3200kg";
                            this.bumpu = "アフリカ";

                            break;

                        case 1:

                            this.name = "コビトカバ";
                            this.taicho = "170-195cm";
                            this.taiju = "200-275kg";
                            this.bumpu = "西アフリカ";

                            break;

                        case 2:

                            this.name = "フタコブラクダ";
                            this.taicho = "300cm";
                            this.taiju = "450-1000kg";
                            this.bumpu = "中央アジア";

                            break;

                        case 3:

                            this.name = "ジャワマメジカ";
                            this.taicho = "30-48cm";
                            this.taiju = "1.7-2.6kg";
                            this.bumpu = "東南アジア";

                            break;

                        case 4:

                            this.name = "キリン";
                            this.taicho = "250-370cm　頭までの高さ　500-580cm";
                            this.taiju = "550-1900kg";
                            this.bumpu = "アフリカ";

                            break;

                        case 5:

                            this.name = "オカピ";
                            this.taicho = "200-210cm";
                            this.taiju = "210-300kg";
                            this.bumpu = "アフリカ";

                            break;

                        case 6:

                            this.name = "バーバリーシープ";
                            this.taicho = "130-170cm";
                            this.taiju = "40-145kg";
                            this.bumpu = "アフリカ北部";

                            break;

                        case 7:

                            this.name = "ムフロン";
                            this.taicho = "100-120cm";
                            this.taiju = "30-50kg";
                            this.bumpu = "地中海のコルシカ島、サルジニア島、地中海沿岸など";

                            break;
                    }

                    break;

               case "管歯目":

                    switch (id)
                    {
                        case 0:

                            this.name = "ツチブタ";
                            this.taicho = "160cm";
                            this.taiju = "不明";
                            this.bumpu = "アフリカ中部・南部";

                            break;
                    }

                    break;

               case "げっ歯目":

                    switch (id)
                    {
                        case 0:

                            this.name = "シマリス（エゾシマリス）";
                            this.taicho = "12-17cm";
                            this.taiju = "50-120g";
                            this.bumpu = "北海道";

                            break;

                        case 1:

                            this.name = "プレーリードッグ（オグロプレーリードッグ）";
                            this.taicho = "28-35cm";
                            this.taiju = "900-1400g";
                            this.bumpu = "北アメリカ";

                            break;

                        case 2:

                            this.name = "ハダカデバネズミ";
                            this.taicho = "8-9cm";
                            this.taiju = "不明";
                            this.bumpu = "アフリカ東部";

                            break;

                        case 3:

                            this.name = "カナダヤマアラシ";
                            this.taicho = "65-80cm";
                            this.taiju = "不明";
                            this.bumpu = "北アメリカ";

                            break;

                        case 4:

                            this.name = "マーラ";
                            this.taicho = "60-75cm";
                            this.taiju = "9-16kg";
                            this.bumpu = "南アメリカ";

                            break;

                        case 5:

                            this.name = "カピバラ";
                            this.taicho = "105-135cm";
                            this.taiju = "35-65kg";
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
