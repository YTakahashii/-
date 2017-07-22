using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 顔文字大戦争
{
    public partial class StageSelect : UserControl
    {
        private MainForm fm;
        private RadioButton[] radioList;
        private int expCost = 0;
        public StageSelect(MainForm fm)
        {
            InitializeComponent();
            this.fm = fm;
            Init();
        }

        private void Init()
        {
            radioList = new RadioButton[]{
                radioButton1, radioButton2, radioButton3, radioButton4, radioButton5, radioButton6,
                radioButton7, radioButton8, radioButton9, radioButton10
            };

            for(int i=0; i<fm.gData.unLockedStage; i++){
                radioList[i].Enabled = true;
            }

            lb_ExpValue.Text = fm.gData.Exp.ToString();
        }

        private void bt_GoGame_Click(object sender, EventArgs e)
        {
            int stageNum = 0;

            for(int i=0; i<radioList.Length; i++){
                if(radioList[i].Checked){
                    stageNum = i + 1;
                    break;
                }
            }

            if(fm.gData.Exp >= expCost){
                fm.gData.Exp -= expCost;
                fm.nextScene(new GameScreen(fm, stageNum, trackBar1.Value)); //第3引数設定で可変に
            }else{
                MessageBox.Show("所持Expが足りません！難易度を下げてください。","コラコラコラコラ～ッ！(`o´)");
                trackBar1.Value = trackBar1.Minimum;
                expCost = 0;
                lb_LevelValue.Text = (trackBar1.Value + 1).ToString();
                lb_expCost.Text = expCost.ToString();
            }
        }

        private void bt_GoMenu_Click(object sender, EventArgs e)
        {
            fm.nextScene(new Menu(fm));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            expCost = 120 * trackBar1.Value;
            lb_LevelValue.Text = (trackBar1.Value + 1).ToString();
            lb_expCost.Text = expCost.ToString();
        }

        private void bt_Hint_Click(object sender, EventArgs e)
        {
            string msg = "";

            switch(fm.gData.unLockedStage){
                case 1:
                    msg = "とにかくキャラクターを生産して、数で圧倒しよう！";
                    break;
                case 2:
                    msg = "パワーアップでステータスを上げると戦いが楽になるぞ！";
                    break;
                case 3:
                    msg = "";
                    break;
                case 4:
                    msg = "";
                    break;
                case 5:
                    msg = "";
                    break;
                case 6:
                    msg = "";
                    break;
                case 7:
                    msg = "";
                    break;
                case 8:
                    msg = "";
                    break;
                case 9:
                    msg = "";
                    break;
                case 10:
                    msg = "";
                    break;
                default:
                    msg = "クリアおめ";
                    break;
            }
        }
    }
}
