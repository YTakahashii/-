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
    public partial class PoweUp : UserControl
    {
        private MainForm fm;

        private enum dIndex{
            ZIKYU, SEISAN, OSAIHU, KAIKEI
        }

        private string[] rbText = new string[]{
            "耐久力 Lv", "稼ぎ Lv", "お財布 Lv", "会計 Lv"
        };

        private string[] detail = new string[]{
            "自分の拠点の体力がアップします。",
            "お金の増加スピードがアップします。",
            "戦闘中に所持できるお金の上限がアップします。",
            "敵を倒したときに得られるお金の金額がアップします。"
        };

        private RadioButton[] radioList;
        private Label[] expList;

        public PoweUp(MainForm fm)
        {
            InitializeComponent();
            this.fm = fm;
        }

        private void bt_GoMenu_Click(object sender, EventArgs e)
        {
            fm.nextScene(new Menu(fm));
        }

        private void PoweUp_Load(object sender, EventArgs e)
        {
            radioList = new RadioButton[]{
                rb_StructureHP, rb_moneyTimer, rb_MaxMoney, rb_KnockdownBonus
            };

            expList = new Label[]{
                label3, label4, label5, label6
            };

            for(int i=0; i<radioList.Length; i++){
                radioList[i].Text = rbText[i] + fm.pData.level[i].ToString();
                expList[i].Text = (fm.pData.level[i] * 1000).ToString() + "Exp";
                if (fm.pData.level[i] >= 10) radioList[i].Enabled = false;
            }
            lb_MyExp.Text = "所持Exp：" + fm.gData.Exp.ToString();
            lb_Detail.Text = detail[0];
        }


        private void rb_StructureHP_CheckedChanged(object sender, EventArgs e)
        {
            int index = 0;

            for(int i=0; i<radioList.Length; i++){
                if(radioList[i].Checked){
                    index = i;
                    break;
                }
            }

            lb_Detail.Text = detail[index];
        }

        private void bt_PowerUp_Click(object sender, EventArgs e)
        {
            int index = 0;
            for(int i=0; i<radioList.Length; i++){
                if(radioList[i].Checked){
                    index = i;
                    break;
                }
            }
            int useExp = fm.pData.level[index] * 1000;
            if (useExp > fm.gData.Exp){
                MessageBox.Show("所持Expが足りません！","コラコラコラコラ～ッ！(`o´)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if(fm.pData.level[index] > 10){
                MessageBox.Show("これ以上あげられないよ！","ヽ('ω')ﾉ三ヽ('ω')ﾉもうしわけねぇ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else{
                switch(index){
                    case (int)dIndex.ZIKYU:
                        fm.gData.structureHP += fm.pData.poweUpValue[index];
                        break;
                    case (int)dIndex.SEISAN:
                        fm.gData.moneyTimerInterval -= fm.pData.poweUpValue[index];
                        break;
                    case (int)dIndex.OSAIHU:
                        fm.gData.maxMoney += fm.pData.poweUpValue[index];
                        break;
                    case (int)dIndex.KAIKEI:
                        fm.gData.KnockdownBonus += fm.pData.poweUpValue[index];
                        break;
                }
                fm.pData.level[index]++;
                fm.gData.Exp -= useExp;
                lb_MyExp.Text = "所持Exp：" + fm.gData.Exp.ToString();
                radioList[index].Text = rbText[index] + fm.pData.level[index];
                expList[index].Text = (fm.pData.level[index] * 1000).ToString() + "Exp";
                if (fm.pData.level[index] > 10){
                    radioList[index].Enabled = false;
                    radioList[index].Text = rbText[index] + "MAX";
                    expList[index].Text = "";
                }
            }
        }
    }
}
