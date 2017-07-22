namespace 顔文字大戦争
{
    partial class Menu
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.bt_GoStageSelect = new System.Windows.Forms.Button();
            this.bt_GoPowerUp = new System.Windows.Forms.Button();
            this.bt_GoUnitChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Hint = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("メイリオ", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(374, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "メニュー";
            // 
            // bt_GoStageSelect
            // 
            this.bt_GoStageSelect.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_GoStageSelect.Location = new System.Drawing.Point(128, 146);
            this.bt_GoStageSelect.Name = "bt_GoStageSelect";
            this.bt_GoStageSelect.Size = new System.Drawing.Size(192, 57);
            this.bt_GoStageSelect.TabIndex = 2;
            this.bt_GoStageSelect.Text = "出撃";
            this.bt_GoStageSelect.UseVisualStyleBackColor = true;
            this.bt_GoStageSelect.Click += new System.EventHandler(this.bt_GoStageSelect_Click);
            // 
            // bt_GoPowerUp
            // 
            this.bt_GoPowerUp.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_GoPowerUp.Location = new System.Drawing.Point(699, 146);
            this.bt_GoPowerUp.Name = "bt_GoPowerUp";
            this.bt_GoPowerUp.Size = new System.Drawing.Size(192, 57);
            this.bt_GoPowerUp.TabIndex = 3;
            this.bt_GoPowerUp.Text = "パワーアップ";
            this.bt_GoPowerUp.UseVisualStyleBackColor = true;
            this.bt_GoPowerUp.Click += new System.EventHandler(this.bt_GoPowerUp_Click);
            // 
            // bt_GoUnitChange
            // 
            this.bt_GoUnitChange.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_GoUnitChange.Location = new System.Drawing.Point(404, 146);
            this.bt_GoUnitChange.Name = "bt_GoUnitChange";
            this.bt_GoUnitChange.Size = new System.Drawing.Size(192, 57);
            this.bt_GoUnitChange.TabIndex = 4;
            this.bt_GoUnitChange.Text = "ユニット編成";
            this.bt_GoUnitChange.UseVisualStyleBackColor = true;
            this.bt_GoUnitChange.Click += new System.EventHandler(this.bt_GoUnitChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(50, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 84);
            this.label2.TabIndex = 5;
            this.label2.Text = "　　　　 ,ﾉﾊ⌒.,ィ{ \r\n　　　ﾄ,K.!|ﾉﾉ）)）)） ,ｲ　　　\r\n　　ﾄ,i~ﾍ!!.|l ﾟ -ﾟﾉ|!ﾉ~iｲ　　\r\n　ﾄ,i~!､　,ﾊγ/ﾍ" +
    "　　,i~iｲ \r\n　ﾍi 弋 i_}oo〈 ,ﾉ ,丿 i,ﾉ \r\n　　ヽ ,_ {.i.:|.::i:.:.! _,, メ \r\n　　　　 \'｀\'r_,t_ｧ" +
    "\'\r\n";
            // 
            // lb_Hint
            // 
            this.lb_Hint.AutoSize = true;
            this.lb_Hint.BackColor = System.Drawing.Color.Transparent;
            this.lb_Hint.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_Hint.Location = new System.Drawing.Point(183, 355);
            this.lb_Hint.Name = "lb_Hint";
            this.lb_Hint.Size = new System.Drawing.Size(69, 28);
            this.lb_Hint.TabIndex = 6;
            this.lb_Hint.Text = "ヒント";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(103, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "神";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_Hint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_GoUnitChange);
            this.Controls.Add(this.bt_GoPowerUp);
            this.Controls.Add(this.bt_GoStageSelect);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(1050, 480);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_GoStageSelect;
        private System.Windows.Forms.Button bt_GoPowerUp;
        private System.Windows.Forms.Button bt_GoUnitChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Hint;
        private System.Windows.Forms.Label label3;
    }
}
