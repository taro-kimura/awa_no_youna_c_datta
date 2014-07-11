namespace list_of_mammals
{
    partial class form_mammals
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.comb_moku = new System.Windows.Forms.ComboBox();
            this.lv_name = new System.Windows.Forms.ListView();
            this.colheader_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lab_bumpu = new System.Windows.Forms.Label();
            this.text_bumpu = new System.Windows.Forms.TextBox();
            this.text_taicho = new System.Windows.Forms.TextBox();
            this.lab_taicho = new System.Windows.Forms.Label();
            this.text_taiju = new System.Windows.Forms.TextBox();
            this.lab_taiju = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comb_moku
            // 
            this.comb_moku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_moku.FormattingEnabled = true;
            this.comb_moku.Items.AddRange(new object[] {
            "霊長目",
            "有袋目",
            "貧歯目",
            "翼手目",
            "クジラ目",
            "食肉目",
            "長鼻目",
            "海牛目",
            "奇蹄目",
            "偶蹄目",
            "管歯目",
            "げっ歯目"});
            this.comb_moku.Location = new System.Drawing.Point(12, 12);
            this.comb_moku.Name = "comb_moku";
            this.comb_moku.Size = new System.Drawing.Size(231, 20);
            this.comb_moku.TabIndex = 0;
            this.comb_moku.SelectionChangeCommitted += new System.EventHandler(this.comb_moku_SelectionChangeCommitted);
            // 
            // lv_name
            // 
            this.lv_name.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colheader_name});
            this.lv_name.FullRowSelect = true;
            this.lv_name.GridLines = true;
            this.lv_name.Location = new System.Drawing.Point(12, 38);
            this.lv_name.Name = "lv_name";
            this.lv_name.Size = new System.Drawing.Size(231, 110);
            this.lv_name.TabIndex = 1;
            this.lv_name.UseCompatibleStateImageBehavior = false;
            this.lv_name.View = System.Windows.Forms.View.Details;
            this.lv_name.SelectedIndexChanged += new System.EventHandler(this.lv_name_SelectedIndexChanged);
            // 
            // colheader_name
            // 
            this.colheader_name.Text = "名前";
            this.colheader_name.Width = 231;
            // 
            // lab_bumpu
            // 
            this.lab_bumpu.AutoSize = true;
            this.lab_bumpu.Location = new System.Drawing.Point(12, 250);
            this.lab_bumpu.Name = "lab_bumpu";
            this.lab_bumpu.Size = new System.Drawing.Size(29, 12);
            this.lab_bumpu.TabIndex = 6;
            this.lab_bumpu.Text = "分布";
            // 
            // text_bumpu
            // 
            this.text_bumpu.BackColor = System.Drawing.SystemColors.Info;
            this.text_bumpu.Location = new System.Drawing.Point(12, 265);
            this.text_bumpu.Name = "text_bumpu";
            this.text_bumpu.ReadOnly = true;
            this.text_bumpu.Size = new System.Drawing.Size(231, 19);
            this.text_bumpu.TabIndex = 7;
            // 
            // text_taicho
            // 
            this.text_taicho.BackColor = System.Drawing.SystemColors.Info;
            this.text_taicho.Location = new System.Drawing.Point(12, 173);
            this.text_taicho.Name = "text_taicho";
            this.text_taicho.ReadOnly = true;
            this.text_taicho.Size = new System.Drawing.Size(231, 19);
            this.text_taicho.TabIndex = 9;
            // 
            // lab_taicho
            // 
            this.lab_taicho.AutoSize = true;
            this.lab_taicho.Location = new System.Drawing.Point(12, 158);
            this.lab_taicho.Name = "lab_taicho";
            this.lab_taicho.Size = new System.Drawing.Size(29, 12);
            this.lab_taicho.TabIndex = 8;
            this.lab_taicho.Text = "体長";
            // 
            // text_taiju
            // 
            this.text_taiju.BackColor = System.Drawing.SystemColors.Info;
            this.text_taiju.Location = new System.Drawing.Point(12, 218);
            this.text_taiju.Name = "text_taiju";
            this.text_taiju.ReadOnly = true;
            this.text_taiju.Size = new System.Drawing.Size(231, 19);
            this.text_taiju.TabIndex = 11;
            // 
            // lab_taiju
            // 
            this.lab_taiju.AutoSize = true;
            this.lab_taiju.Location = new System.Drawing.Point(12, 203);
            this.lab_taiju.Name = "lab_taiju";
            this.lab_taiju.Size = new System.Drawing.Size(29, 12);
            this.lab_taiju.TabIndex = 10;
            this.lab_taiju.Text = "体重";
            // 
            // form_mammals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 306);
            this.Controls.Add(this.text_taiju);
            this.Controls.Add(this.lab_taiju);
            this.Controls.Add(this.text_taicho);
            this.Controls.Add(this.lab_taicho);
            this.Controls.Add(this.text_bumpu);
            this.Controls.Add(this.lab_bumpu);
            this.Controls.Add(this.lv_name);
            this.Controls.Add(this.comb_moku);
            this.Name = "form_mammals";
            this.Text = "List of Mammals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comb_moku;
        private System.Windows.Forms.ListView lv_name;
        private System.Windows.Forms.ColumnHeader colheader_name;
        private System.Windows.Forms.Label lab_bumpu;
        private System.Windows.Forms.TextBox text_bumpu;
        private System.Windows.Forms.TextBox text_taicho;
        private System.Windows.Forms.Label lab_taicho;
        private System.Windows.Forms.TextBox text_taiju;
        private System.Windows.Forms.Label lab_taiju;
    }
}

