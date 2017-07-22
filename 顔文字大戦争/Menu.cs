using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SmallBasic.Library;

namespace 顔文字大戦争
{
    public partial class Menu : UserControl
    {
        private MainForm fm;

        public Menu(MainForm fm)
        {
            InitializeComponent();
            this.fm = fm;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            string msg = "";

            switch(fm.gData.unLockedStage){
                case 1:
                    msg = "まずは出撃からステージ1をクリアするのだ。";
                    break;
                case 2:
                    msg = "仲間になったキャラクターはユニット編成で連れて行けるぞ。";
                    break;
                case 3:
                    msg = "パワーアップでステータスを上げると戦いが楽になるぞ。";
                    break;
                case 4:
                    msg = "ステージ3から仲間の気配を感じる・・・";
                    break;
                case 5:
                    msg = "ステージ選択でレベルを上げると経験値が稼ぎやすいぞ。";
                    break;
                case 6:
                    msg = "バグとかあったらごめんね。";
                    break;
                case 7:
                    msg = "ステージ6から仲間の気配を感じる・・・";
                    break;
                case 8:
                    msg = "ステージ7から仲間の気配を感じる・・・";
                    break;
                case 9:
                    msg = "ステージ8から仲間の気配を感じる・・・";
                    break;
                case 10:
                    msg = "ステージ9から仲間の気配を感じる・・・";
                    break;
                default:
                    msg = "クリアおめ";
                    break;
            }
            lb_Hint.Text = msg;
        }

        private void bt_GoStageSelect_Click(object sender, EventArgs e)
        {
            fm.nextScene(new StageSelect(fm));
        }

        private void bt_GoUnitChange_Click(object sender, EventArgs e)
        {
            fm.nextScene(new UnitChange(fm));
        }

        private void bt_GoPowerUp_Click(object sender, EventArgs e)
        {
            fm.nextScene(new PoweUp(fm));
        }
    }
}
