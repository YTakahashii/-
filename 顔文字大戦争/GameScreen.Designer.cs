namespace 顔文字大戦争
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.timerDraw = new System.Windows.Forms.Timer(this.components);
            this.timerEnemyCreate = new System.Windows.Forms.Timer(this.components);
            this.timerPlayerAnimation = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timerEnemyAnimation = new System.Windows.Forms.Timer(this.components);
            this.bt_CreatePlayer1 = new System.Windows.Forms.Button();
            this.bt_CreatePlayer2 = new System.Windows.Forms.Button();
            this.bt_CreatePlayer3 = new System.Windows.Forms.Button();
            this.bt_CreatePlayer4 = new System.Windows.Forms.Button();
            this.bt_CreatePlayer5 = new System.Windows.Forms.Button();
            this.Bar_Create1 = new System.Windows.Forms.ProgressBar();
            this.Bar_Create2 = new System.Windows.Forms.ProgressBar();
            this.Bar_Create3 = new System.Windows.Forms.ProgressBar();
            this.Bar_Create4 = new System.Windows.Forms.ProgressBar();
            this.Bar_Create5 = new System.Windows.Forms.ProgressBar();
            this.bt_MoneyUp = new System.Windows.Forms.Button();
            this.timerMoneyAnimation = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.screen = new 顔文字大戦争.ScreenPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            this.SuspendLayout();
            // 
            // timerDraw
            // 
            this.timerDraw.Enabled = true;
            this.timerDraw.Interval = 16;
            this.timerDraw.Tick += new System.EventHandler(this.timerDraw_Tick);
            // 
            // timerEnemyCreate
            // 
            this.timerEnemyCreate.Enabled = true;
            this.timerEnemyCreate.Interval = 4000;
            this.timerEnemyCreate.Tick += new System.EventHandler(this.EnemyCreate_Tick);
            // 
            // timerPlayerAnimation
            // 
            this.timerPlayerAnimation.Enabled = true;
            this.timerPlayerAnimation.Interval = 1000;
            this.timerPlayerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerEnemyAnimation
            // 
            this.timerEnemyAnimation.Enabled = true;
            this.timerEnemyAnimation.Interval = 1000;
            this.timerEnemyAnimation.Tick += new System.EventHandler(this.timerEnemyAnimation_Tick);
            // 
            // bt_CreatePlayer1
            // 
            this.bt_CreatePlayer1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_CreatePlayer1.Location = new System.Drawing.Point(152, 9);
            this.bt_CreatePlayer1.Name = "bt_CreatePlayer1";
            this.bt_CreatePlayer1.Size = new System.Drawing.Size(124, 83);
            this.bt_CreatePlayer1.TabIndex = 9;
            this.bt_CreatePlayer1.Text = "None";
            this.bt_CreatePlayer1.UseVisualStyleBackColor = true;
            this.bt_CreatePlayer1.Click += new System.EventHandler(this.bt_CreatePlayer1_Click);
            // 
            // bt_CreatePlayer2
            // 
            this.bt_CreatePlayer2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_CreatePlayer2.Location = new System.Drawing.Point(307, 9);
            this.bt_CreatePlayer2.Name = "bt_CreatePlayer2";
            this.bt_CreatePlayer2.Size = new System.Drawing.Size(124, 83);
            this.bt_CreatePlayer2.TabIndex = 10;
            this.bt_CreatePlayer2.Text = "None";
            this.bt_CreatePlayer2.UseVisualStyleBackColor = true;
            this.bt_CreatePlayer2.Click += new System.EventHandler(this.bt_CreatePlayer2_Click);
            // 
            // bt_CreatePlayer3
            // 
            this.bt_CreatePlayer3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_CreatePlayer3.Location = new System.Drawing.Point(457, 9);
            this.bt_CreatePlayer3.Name = "bt_CreatePlayer3";
            this.bt_CreatePlayer3.Size = new System.Drawing.Size(124, 83);
            this.bt_CreatePlayer3.TabIndex = 11;
            this.bt_CreatePlayer3.Text = "None";
            this.bt_CreatePlayer3.UseVisualStyleBackColor = true;
            this.bt_CreatePlayer3.Click += new System.EventHandler(this.bt_CreatePlayer3_Click);
            // 
            // bt_CreatePlayer4
            // 
            this.bt_CreatePlayer4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_CreatePlayer4.Location = new System.Drawing.Point(604, 9);
            this.bt_CreatePlayer4.Name = "bt_CreatePlayer4";
            this.bt_CreatePlayer4.Size = new System.Drawing.Size(124, 83);
            this.bt_CreatePlayer4.TabIndex = 12;
            this.bt_CreatePlayer4.Text = "None";
            this.bt_CreatePlayer4.UseVisualStyleBackColor = true;
            this.bt_CreatePlayer4.Click += new System.EventHandler(this.bt_CreatePlayer4_Click);
            // 
            // bt_CreatePlayer5
            // 
            this.bt_CreatePlayer5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_CreatePlayer5.Location = new System.Drawing.Point(760, 9);
            this.bt_CreatePlayer5.Name = "bt_CreatePlayer5";
            this.bt_CreatePlayer5.Size = new System.Drawing.Size(124, 83);
            this.bt_CreatePlayer5.TabIndex = 13;
            this.bt_CreatePlayer5.Text = "None";
            this.bt_CreatePlayer5.UseVisualStyleBackColor = true;
            this.bt_CreatePlayer5.Click += new System.EventHandler(this.bt_CreatePlayer5_Click);
            // 
            // Bar_Create1
            // 
            this.Bar_Create1.Location = new System.Drawing.Point(152, 98);
            this.Bar_Create1.Name = "Bar_Create1";
            this.Bar_Create1.Size = new System.Drawing.Size(124, 12);
            this.Bar_Create1.Step = 1;
            this.Bar_Create1.TabIndex = 14;
            this.Bar_Create1.Value = 100;
            // 
            // Bar_Create2
            // 
            this.Bar_Create2.Location = new System.Drawing.Point(307, 98);
            this.Bar_Create2.Name = "Bar_Create2";
            this.Bar_Create2.Size = new System.Drawing.Size(124, 12);
            this.Bar_Create2.TabIndex = 15;
            this.Bar_Create2.Value = 100;
            // 
            // Bar_Create3
            // 
            this.Bar_Create3.Location = new System.Drawing.Point(457, 98);
            this.Bar_Create3.Name = "Bar_Create3";
            this.Bar_Create3.Size = new System.Drawing.Size(124, 12);
            this.Bar_Create3.TabIndex = 16;
            this.Bar_Create3.Value = 100;
            // 
            // Bar_Create4
            // 
            this.Bar_Create4.Location = new System.Drawing.Point(604, 98);
            this.Bar_Create4.Name = "Bar_Create4";
            this.Bar_Create4.Size = new System.Drawing.Size(124, 12);
            this.Bar_Create4.TabIndex = 17;
            this.Bar_Create4.Value = 100;
            // 
            // Bar_Create5
            // 
            this.Bar_Create5.Location = new System.Drawing.Point(760, 98);
            this.Bar_Create5.Name = "Bar_Create5";
            this.Bar_Create5.Size = new System.Drawing.Size(124, 12);
            this.Bar_Create5.TabIndex = 18;
            this.Bar_Create5.Value = 100;
            // 
            // bt_MoneyUp
            // 
            this.bt_MoneyUp.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_MoneyUp.ForeColor = System.Drawing.Color.Goldenrod;
            this.bt_MoneyUp.Location = new System.Drawing.Point(3, 9);
            this.bt_MoneyUp.Name = "bt_MoneyUp";
            this.bt_MoneyUp.Size = new System.Drawing.Size(134, 83);
            this.bt_MoneyUp.TabIndex = 19;
            this.bt_MoneyUp.Text = "お金アップ";
            this.bt_MoneyUp.UseVisualStyleBackColor = true;
            this.bt_MoneyUp.Click += new System.EventHandler(this.bt_MoneyUp_Click);
            // 
            // timerMoneyAnimation
            // 
            this.timerMoneyAnimation.Enabled = true;
            this.timerMoneyAnimation.Interval = 40;
            this.timerMoneyAnimation.Tick += new System.EventHandler(this.timerMoneyAnimation_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(980, 421);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 19);
            this.textBox1.TabIndex = 20;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(980, 421);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 19);
            this.textBox2.TabIndex = 21;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(980, 421);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 19);
            this.textBox3.TabIndex = 22;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(980, 421);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(50, 19);
            this.textBox4.TabIndex = 23;
            this.textBox4.Visible = false;
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.Control;
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1050, 480);
            this.screen.TabIndex = 0;
            this.screen.TabStop = false;
            this.screen.Resize += new System.EventHandler(this.screen_Resize);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_MoneyUp);
            this.Controls.Add(this.Bar_Create5);
            this.Controls.Add(this.Bar_Create4);
            this.Controls.Add(this.Bar_Create3);
            this.Controls.Add(this.Bar_Create2);
            this.Controls.Add(this.Bar_Create1);
            this.Controls.Add(this.bt_CreatePlayer5);
            this.Controls.Add(this.bt_CreatePlayer4);
            this.Controls.Add(this.bt_CreatePlayer3);
            this.Controls.Add(this.bt_CreatePlayer2);
            this.Controls.Add(this.bt_CreatePlayer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.screen);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1050, 480);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScreenPictureBox screen;
        private System.Windows.Forms.Timer timerDraw;
        private System.Windows.Forms.Timer timerEnemyCreate;
        private System.Windows.Forms.Timer timerPlayerAnimation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerEnemyAnimation;
        private System.Windows.Forms.Button bt_CreatePlayer1;
        private System.Windows.Forms.Button bt_CreatePlayer2;
        private System.Windows.Forms.Button bt_CreatePlayer3;
        private System.Windows.Forms.Button bt_CreatePlayer4;
        private System.Windows.Forms.Button bt_CreatePlayer5;
        private System.Windows.Forms.ProgressBar Bar_Create1;
        private System.Windows.Forms.ProgressBar Bar_Create2;
        private System.Windows.Forms.ProgressBar Bar_Create3;
        private System.Windows.Forms.ProgressBar Bar_Create4;
        private System.Windows.Forms.ProgressBar Bar_Create5;
        private System.Windows.Forms.Button bt_MoneyUp;
        private System.Windows.Forms.Timer timerMoneyAnimation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}
