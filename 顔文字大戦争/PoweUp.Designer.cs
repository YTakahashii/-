namespace 顔文字大戦争
{
    partial class PoweUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoweUp));
            this.bt_GoMenu = new System.Windows.Forms.Button();
            this.rb_StructureHP = new System.Windows.Forms.RadioButton();
            this.lb_Detail = new System.Windows.Forms.Label();
            this.bt_PowerUp = new System.Windows.Forms.Button();
            this.rb_MaxMoney = new System.Windows.Forms.RadioButton();
            this.rb_moneyTimer = new System.Windows.Forms.RadioButton();
            this.rb_KnockdownBonus = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_MyExp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_GoMenu
            // 
            this.bt_GoMenu.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_GoMenu.Location = new System.Drawing.Point(30, 400);
            this.bt_GoMenu.Name = "bt_GoMenu";
            this.bt_GoMenu.Size = new System.Drawing.Size(167, 62);
            this.bt_GoMenu.TabIndex = 1;
            this.bt_GoMenu.Text = "メニューへ戻る";
            this.bt_GoMenu.UseVisualStyleBackColor = true;
            this.bt_GoMenu.Click += new System.EventHandler(this.bt_GoMenu_Click);
            // 
            // rb_StructureHP
            // 
            this.rb_StructureHP.AutoSize = true;
            this.rb_StructureHP.BackColor = System.Drawing.Color.Transparent;
            this.rb_StructureHP.Checked = true;
            this.rb_StructureHP.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb_StructureHP.Location = new System.Drawing.Point(231, 125);
            this.rb_StructureHP.Name = "rb_StructureHP";
            this.rb_StructureHP.Size = new System.Drawing.Size(143, 32);
            this.rb_StructureHP.TabIndex = 2;
            this.rb_StructureHP.TabStop = true;
            this.rb_StructureHP.Text = "持久力 Ｌｖ1";
            this.rb_StructureHP.UseVisualStyleBackColor = false;
            this.rb_StructureHP.CheckedChanged += new System.EventHandler(this.rb_StructureHP_CheckedChanged);
            // 
            // lb_Detail
            // 
            this.lb_Detail.AutoSize = true;
            this.lb_Detail.BackColor = System.Drawing.Color.Transparent;
            this.lb_Detail.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_Detail.Location = new System.Drawing.Point(292, 378);
            this.lb_Detail.Name = "lb_Detail";
            this.lb_Detail.Size = new System.Drawing.Size(119, 31);
            this.lb_Detail.TabIndex = 4;
            this.lb_Detail.Text = "項目の詳細";
            // 
            // bt_PowerUp
            // 
            this.bt_PowerUp.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_PowerUp.Location = new System.Drawing.Point(319, 259);
            this.bt_PowerUp.Name = "bt_PowerUp";
            this.bt_PowerUp.Size = new System.Drawing.Size(327, 62);
            this.bt_PowerUp.TabIndex = 5;
            this.bt_PowerUp.Text = "パワーアップ！";
            this.bt_PowerUp.UseVisualStyleBackColor = true;
            this.bt_PowerUp.Click += new System.EventHandler(this.bt_PowerUp_Click);
            // 
            // rb_MaxMoney
            // 
            this.rb_MaxMoney.AutoSize = true;
            this.rb_MaxMoney.BackColor = System.Drawing.Color.Transparent;
            this.rb_MaxMoney.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb_MaxMoney.Location = new System.Drawing.Point(231, 191);
            this.rb_MaxMoney.Name = "rb_MaxMoney";
            this.rb_MaxMoney.Size = new System.Drawing.Size(126, 32);
            this.rb_MaxMoney.TabIndex = 6;
            this.rb_MaxMoney.TabStop = true;
            this.rb_MaxMoney.Text = "お財布 Lv1";
            this.rb_MaxMoney.UseVisualStyleBackColor = false;
            this.rb_MaxMoney.CheckedChanged += new System.EventHandler(this.rb_StructureHP_CheckedChanged);
            // 
            // rb_moneyTimer
            // 
            this.rb_moneyTimer.AutoSize = true;
            this.rb_moneyTimer.BackColor = System.Drawing.Color.Transparent;
            this.rb_moneyTimer.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb_moneyTimer.Location = new System.Drawing.Point(570, 125);
            this.rb_moneyTimer.Name = "rb_moneyTimer";
            this.rb_moneyTimer.Size = new System.Drawing.Size(126, 32);
            this.rb_moneyTimer.TabIndex = 7;
            this.rb_moneyTimer.TabStop = true;
            this.rb_moneyTimer.Text = "生産力 Lv1";
            this.rb_moneyTimer.UseVisualStyleBackColor = false;
            this.rb_moneyTimer.CheckedChanged += new System.EventHandler(this.rb_StructureHP_CheckedChanged);
            // 
            // rb_KnockdownBonus
            // 
            this.rb_KnockdownBonus.AutoSize = true;
            this.rb_KnockdownBonus.BackColor = System.Drawing.Color.Transparent;
            this.rb_KnockdownBonus.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb_KnockdownBonus.Location = new System.Drawing.Point(570, 194);
            this.rb_KnockdownBonus.Name = "rb_KnockdownBonus";
            this.rb_KnockdownBonus.Size = new System.Drawing.Size(107, 32);
            this.rb_KnockdownBonus.TabIndex = 8;
            this.rb_KnockdownBonus.TabStop = true;
            this.rb_KnockdownBonus.Text = "会計 Lv1";
            this.rb_KnockdownBonus.UseVisualStyleBackColor = false;
            this.rb_KnockdownBonus.CheckedChanged += new System.EventHandler(this.rb_StructureHP_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(380, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "???Exp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(712, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "???Exp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(381, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "???Exp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(712, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "???Exp";
            // 
            // lb_MyExp
            // 
            this.lb_MyExp.AutoSize = true;
            this.lb_MyExp.BackColor = System.Drawing.Color.Transparent;
            this.lb_MyExp.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_MyExp.Location = new System.Drawing.Point(53, 259);
            this.lb_MyExp.Name = "lb_MyExp";
            this.lb_MyExp.Size = new System.Drawing.Size(115, 31);
            this.lb_MyExp.TabIndex = 13;
            this.lb_MyExp.Text = "所持Exp：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("メイリオ", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(342, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 72);
            this.label2.TabIndex = 14;
            this.label2.Text = "パワーアップ";
            // 
            // PoweUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_MyExp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_KnockdownBonus);
            this.Controls.Add(this.rb_moneyTimer);
            this.Controls.Add(this.rb_MaxMoney);
            this.Controls.Add(this.bt_PowerUp);
            this.Controls.Add(this.lb_Detail);
            this.Controls.Add(this.rb_StructureHP);
            this.Controls.Add(this.bt_GoMenu);
            this.Name = "PoweUp";
            this.Size = new System.Drawing.Size(1050, 480);
            this.Load += new System.EventHandler(this.PoweUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_GoMenu;
        private System.Windows.Forms.RadioButton rb_StructureHP;
        private System.Windows.Forms.Label lb_Detail;
        private System.Windows.Forms.Button bt_PowerUp;
        private System.Windows.Forms.RadioButton rb_MaxMoney;
        private System.Windows.Forms.RadioButton rb_moneyTimer;
        private System.Windows.Forms.RadioButton rb_KnockdownBonus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_MyExp;
        private System.Windows.Forms.Label label2;
    }
}
