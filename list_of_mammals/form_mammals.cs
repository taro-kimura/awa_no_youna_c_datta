﻿using System;
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

            // 初期表示時に、先頭の項目を選択
            this.comb_moku.SelectedIndex = 0;

            // 霊長目
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

            switch(comb_moku.SelectedItem.ToString())
            {
                case "霊長目":

                    // 霊長目
                    for (int i = 0; i < 8; ++i)
                    {
                        Info info_reic = new Info(comb_moku.SelectedItem.ToString(), i);

                        //アイテムをリスビューに追加する
                        lv_name.Items.Add(info_reic.Name);
                    }

                    break;
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
