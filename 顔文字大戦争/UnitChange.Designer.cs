namespace 顔文字大戦争
{
    partial class UnitChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitChange));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_characterImage1 = new System.Windows.Forms.Label();
            this.lb_Cost1 = new System.Windows.Forms.Label();
            this.lb_Cost2 = new System.Windows.Forms.Label();
            this.lb_characterImage2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lb_Cost3 = new System.Windows.Forms.Label();
            this.lb_characterImage3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lb_Cost4 = new System.Windows.Forms.Label();
            this.lb_characterImage4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.lb_Cost5 = new System.Windows.Forms.Label();
            this.lb_characterImage5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_Showinfo1 = new System.Windows.Forms.Button();
            this.bt_Showinfo2 = new System.Windows.Forms.Button();
            this.bt_Showinfo3 = new System.Windows.Forms.Button();
            this.bt_Showinfo4 = new System.Windows.Forms.Button();
            this.bt_Showinfo5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(41, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "編成を終わる";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("メイリオ", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(317, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "ユニット編成";
            // 
            // lb_characterImage1
            // 
            this.lb_characterImage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_characterImage1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_characterImage1.Location = new System.Drawing.Point(178, 170);
            this.lb_characterImage1.Name = "lb_characterImage1";
            this.lb_characterImage1.Size = new System.Drawing.Size(230, 61);
            this.lb_characterImage1.TabIndex = 3;
            this.lb_characterImage1.Text = "Image1";
            this.lb_characterImage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cost1
            // 
            this.lb_Cost1.AutoSize = true;
            this.lb_Cost1.BackColor = System.Drawing.Color.Transparent;
            this.lb_Cost1.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_Cost1.Location = new System.Drawing.Point(428, 201);
            this.lb_Cost1.Name = "lb_Cost1";
            this.lb_Cost1.Size = new System.Drawing.Size(48, 31);
            this.lb_Cost1.TabIndex = 4;
            this.lb_Cost1.Text = "0円";
            // 
            // lb_Cost2
            // 
            this.lb_Cost2.AutoSize = true;
            this.lb_Cost2.BackColor = System.Drawing.Color.Transparent;
            this.lb_Cost2.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_Cost2.Location = new System.Drawing.Point(428, 299);
            this.lb_Cost2.Name = "lb_Cost2";
            this.lb_Cost2.Size = new System.Drawing.Size(48, 31);
            this.lb_Cost2.TabIndex = 7;
            this.lb_Cost2.Text = "0円";
            // 
            // lb_characterImage2
            // 
            this.lb_characterImage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_characterImage2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_characterImage2.Location = new System.Drawing.Point(178, 270);
            this.lb_characterImage2.Name = "lb_characterImage2";
            this.lb_characterImage2.Size = new System.Drawing.Size(230, 61);
            this.lb_characterImage2.TabIndex = 6;
            this.lb_characterImage2.Text = "Image2";
            this.lb_characterImage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(43, 268);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(93, 20);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lb_Cost3
            // 
            this.lb_Cost3.AutoSize = true;
            this.lb_Cost3.BackColor = System.Drawing.Color.Transparent;
            this.lb_Cost3.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_Cost3.Location = new System.Drawing.Point(912, 201);
            this.lb_Cost3.Name = "lb_Cost3";
            this.lb_Cost3.Size = new System.Drawing.Size(48, 31);
            this.lb_Cost3.TabIndex = 10;
            this.lb_Cost3.Text = "0円";
            // 
            // lb_characterImage3
            // 
            this.lb_characterImage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_characterImage3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_characterImage3.Location = new System.Drawing.Point(676, 172);
            this.lb_characterImage3.Name = "lb_characterImage3";
            this.lb_characterImage3.Size = new System.Drawing.Size(216, 59);
            this.lb_characterImage3.TabIndex = 9;
            this.lb_characterImage3.Text = "Image3";
            this.lb_characterImage3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(553, 168);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(93, 20);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lb_Cost4
            // 
            this.lb_Cost4.AutoSize = true;
            this.lb_Cost4.BackColor = System.Drawing.Color.Transparent;
            this.lb_Cost4.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_Cost4.Location = new System.Drawing.Point(912, 300);
            this.lb_Cost4.Name = "lb_Cost4";
            this.lb_Cost4.Size = new System.Drawing.Size(48, 31);
            this.lb_Cost4.TabIndex = 13;
            this.lb_Cost4.Text = "0円";
            // 
            // lb_characterImage4
            // 
            this.lb_characterImage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_characterImage4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_characterImage4.Location = new System.Drawing.Point(676, 270);
            this.lb_characterImage4.Name = "lb_characterImage4";
            this.lb_characterImage4.Size = new System.Drawing.Size(216, 63);
            this.lb_characterImage4.TabIndex = 12;
            this.lb_characterImage4.Text = "Image4";
            this.lb_characterImage4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(553, 268);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(93, 20);
            this.comboBox4.TabIndex = 11;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // lb_Cost5
            // 
            this.lb_Cost5.AutoSize = true;
            this.lb_Cost5.BackColor = System.Drawing.Color.Transparent;
            this.lb_Cost5.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_Cost5.Location = new System.Drawing.Point(912, 423);
            this.lb_Cost5.Name = "lb_Cost5";
            this.lb_Cost5.Size = new System.Drawing.Size(48, 31);
            this.lb_Cost5.TabIndex = 16;
            this.lb_Cost5.Text = "0円";
            // 
            // lb_characterImage5
            // 
            this.lb_characterImage5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_characterImage5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_characterImage5.Location = new System.Drawing.Point(676, 394);
            this.lb_characterImage5.Name = "lb_characterImage5";
            this.lb_characterImage5.Size = new System.Drawing.Size(216, 61);
            this.lb_characterImage5.TabIndex = 15;
            this.lb_characterImage5.Text = "Image5";
            this.lb_characterImage5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(553, 381);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(93, 20);
            this.comboBox5.TabIndex = 14;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(41, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "スロット1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(41, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "スロット2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(551, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "スロット3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(551, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "スロット4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(551, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "スロット5";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(45, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 58);
            this.button2.TabIndex = 22;
            this.button2.Text = "(help´Д｀)ﾉ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_Showinfo1
            // 
            this.bt_Showinfo1.Location = new System.Drawing.Point(41, 208);
            this.bt_Showinfo1.Name = "bt_Showinfo1";
            this.bt_Showinfo1.Size = new System.Drawing.Size(93, 24);
            this.bt_Showinfo1.TabIndex = 23;
            this.bt_Showinfo1.Text = "キャラ情報";
            this.bt_Showinfo1.UseVisualStyleBackColor = true;
            this.bt_Showinfo1.Click += new System.EventHandler(this.bt_Showinfo1_Click);
            // 
            // bt_Showinfo2
            // 
            this.bt_Showinfo2.Location = new System.Drawing.Point(43, 309);
            this.bt_Showinfo2.Name = "bt_Showinfo2";
            this.bt_Showinfo2.Size = new System.Drawing.Size(93, 24);
            this.bt_Showinfo2.TabIndex = 24;
            this.bt_Showinfo2.Text = "キャラ情報";
            this.bt_Showinfo2.UseVisualStyleBackColor = true;
            this.bt_Showinfo2.Click += new System.EventHandler(this.bt_Showinfo2_Click);
            // 
            // bt_Showinfo3
            // 
            this.bt_Showinfo3.Location = new System.Drawing.Point(553, 209);
            this.bt_Showinfo3.Name = "bt_Showinfo3";
            this.bt_Showinfo3.Size = new System.Drawing.Size(93, 24);
            this.bt_Showinfo3.TabIndex = 25;
            this.bt_Showinfo3.Text = "キャラ情報";
            this.bt_Showinfo3.UseVisualStyleBackColor = true;
            this.bt_Showinfo3.Click += new System.EventHandler(this.bt_Showinfo3_Click);
            // 
            // bt_Showinfo4
            // 
            this.bt_Showinfo4.Location = new System.Drawing.Point(555, 309);
            this.bt_Showinfo4.Name = "bt_Showinfo4";
            this.bt_Showinfo4.Size = new System.Drawing.Size(93, 24);
            this.bt_Showinfo4.TabIndex = 26;
            this.bt_Showinfo4.Text = "キャラ情報";
            this.bt_Showinfo4.UseVisualStyleBackColor = true;
            this.bt_Showinfo4.Click += new System.EventHandler(this.bt_Showinfo4_Click);
            // 
            // bt_Showinfo5
            // 
            this.bt_Showinfo5.Location = new System.Drawing.Point(553, 431);
            this.bt_Showinfo5.Name = "bt_Showinfo5";
            this.bt_Showinfo5.Size = new System.Drawing.Size(93, 24);
            this.bt_Showinfo5.TabIndex = 27;
            this.bt_Showinfo5.Text = "キャラ情報";
            this.bt_Showinfo5.UseVisualStyleBackColor = true;
            this.bt_Showinfo5.Click += new System.EventHandler(this.bt_Showinfo5_Click);
            // 
            // UnitChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.bt_Showinfo5);
            this.Controls.Add(this.bt_Showinfo4);
            this.Controls.Add(this.bt_Showinfo3);
            this.Controls.Add(this.bt_Showinfo2);
            this.Controls.Add(this.bt_Showinfo1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Cost5);
            this.Controls.Add(this.lb_characterImage5);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.lb_Cost4);
            this.Controls.Add(this.lb_characterImage4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.lb_Cost3);
            this.Controls.Add(this.lb_characterImage3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.lb_Cost2);
            this.Controls.Add(this.lb_characterImage2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lb_Cost1);
            this.Controls.Add(this.lb_characterImage1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "UnitChange";
            this.Size = new System.Drawing.Size(1050, 480);
            this.Load += new System.EventHandler(this.UnitChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_characterImage1;
        private System.Windows.Forms.Label lb_Cost1;
        private System.Windows.Forms.Label lb_Cost2;
        private System.Windows.Forms.Label lb_characterImage2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lb_Cost3;
        private System.Windows.Forms.Label lb_characterImage3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lb_Cost4;
        private System.Windows.Forms.Label lb_characterImage4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lb_Cost5;
        private System.Windows.Forms.Label lb_characterImage5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_Showinfo1;
        private System.Windows.Forms.Button bt_Showinfo2;
        private System.Windows.Forms.Button bt_Showinfo3;
        private System.Windows.Forms.Button bt_Showinfo4;
        private System.Windows.Forms.Button bt_Showinfo5;
    }
}
