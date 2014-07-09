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
            this.butt_check = new System.Windows.Forms.Button();
            this.butt_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_input
            // 
            this.text_input.Location = new System.Drawing.Point(12, 12);
            this.text_input.Name = "text_input";
            this.text_input.Size = new System.Drawing.Size(197, 19);
            this.text_input.TabIndex = 0;
            // 
            // butt_check
            // 
            this.butt_check.Location = new System.Drawing.Point(12, 37);
            this.butt_check.Name = "butt_check";
            this.butt_check.Size = new System.Drawing.Size(96, 34);
            this.butt_check.TabIndex = 1;
            this.butt_check.Text = "チェック";
            this.butt_check.UseVisualStyleBackColor = true;
            this.butt_check.Click += new System.EventHandler(this.butt_check_Click);
            // 
            // butt_close
            // 
            this.butt_close.Location = new System.Drawing.Point(114, 37);
            this.butt_close.Name = "butt_close";
            this.butt_close.Size = new System.Drawing.Size(95, 34);
            this.butt_close.TabIndex = 2;
            this.butt_close.Text = "おしまい";
            this.butt_close.UseVisualStyleBackColor = true;
            this.butt_close.Click += new System.EventHandler(this.butt_close_Click);
            // 
            // referee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 81);
            this.Controls.Add(this.butt_close);
            this.Controls.Add(this.butt_check);
            this.Controls.Add(this.text_input);
            this.Name = "referee";
            this.Text = "レフェリー";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_input;
        private System.Windows.Forms.Button butt_check;
        private System.Windows.Forms.Button butt_close;
    }
}

