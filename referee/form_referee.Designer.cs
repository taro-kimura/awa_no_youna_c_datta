namespace referee
{
    partial class referee
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
            this.text_input = new System.Windows.Forms.TextBox();
            this.butt_check_num = new System.Windows.Forms.Button();
            this.butt_close = new System.Windows.Forms.Button();
            this.butt_check_date = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_input
            // 
            this.text_input.Location = new System.Drawing.Point(12, 12);
            this.text_input.Name = "text_input";
            this.text_input.Size = new System.Drawing.Size(198, 19);
            this.text_input.TabIndex = 0;
            // 
            // butt_check_num
            // 
            this.butt_check_num.Location = new System.Drawing.Point(12, 37);
            this.butt_check_num.Name = "butt_check_num";
            this.butt_check_num.Size = new System.Drawing.Size(96, 34);
            this.butt_check_num.TabIndex = 1;
            this.butt_check_num.Text = "数値チェック";
            this.butt_check_num.UseVisualStyleBackColor = true;
            this.butt_check_num.Click += new System.EventHandler(this.butt_check_num_Click);
            // 
            // butt_close
            // 
            this.butt_close.Location = new System.Drawing.Point(114, 77);
            this.butt_close.Name = "butt_close";
            this.butt_close.Size = new System.Drawing.Size(96, 34);
            this.butt_close.TabIndex = 2;
            this.butt_close.Text = "おしまい";
            this.butt_close.UseVisualStyleBackColor = true;
            this.butt_close.Click += new System.EventHandler(this.butt_close_Click);
            // 
            // butt_check_date
            // 
            this.butt_check_date.Location = new System.Drawing.Point(114, 37);
            this.butt_check_date.Name = "butt_check_date";
            this.butt_check_date.Size = new System.Drawing.Size(96, 34);
            this.butt_check_date.TabIndex = 3;
            this.butt_check_date.Text = "日付チェック";
            this.butt_check_date.UseVisualStyleBackColor = true;
            this.butt_check_date.Click += new System.EventHandler(this.butt_check_date_Click);
            // 
            // referee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 119);
            this.Controls.Add(this.butt_check_date);
            this.Controls.Add(this.butt_close);
            this.Controls.Add(this.butt_check_num);
            this.Controls.Add(this.text_input);
            this.Name = "referee";
            this.Text = "レフェリー";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_input;
        private System.Windows.Forms.Button butt_check_num;
        private System.Windows.Forms.Button butt_close;
        private System.Windows.Forms.Button butt_check_date;
    }
}

