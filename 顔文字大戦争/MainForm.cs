/***********************************************************************************************************************************************************************************************
 * 制作：18期情報システム科　高橋　佑太
 ***********************************************************************************************************************************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 顔文字大戦争
{
    public partial class MainForm : Form
    {
        public const int StageNum = 10;

        public class GameData
        {
            public int unLockedStage{get; set;}
            public Player[] PlayerCharaSlot{get; set;}
            public int Exp{get; set;}
            public int maxMoney{get; set;}
            public int moneyLevelUpCost{get; set;}
            public int KnockdownBonus{get; set;}
            public Hashtable playerUnLockedList{get; set;}
            public bool[] clearStageList{get; set;}
            public int structureHP{get; set;}
            public int moneyTimerInterval{get; set;}
            
            public GameData()
            {
                unLockedStage = 10;
                Exp = 0;
                maxMoney = 300;
                moneyLevelUpCost = 160;
                structureHP = 300;
                KnockdownBonus = 60;
                moneyTimerInterval = 40;

                PlayerCharaSlot = new Player[]{
                    new PlayerChara1(), null, null, null, null
                };
                playerUnLockedList = new Hashtable();
                for(int i=0; i<PlayerCharaSlot.Length; i++){
                    if(PlayerCharaSlot[i] != null){
                        playerUnLockedList.Add(PlayerCharaSlot[i].Name, PlayerCharaSlot[i]);
                    }
                }
                clearStageList = new bool[StageNum+1];
                for(int i=0; i<StageNum; i++){
                    clearStageList[i] = false;
                }
            }
        }

        public class PowerUpData
        { 
            public int[] poweUpValue{get; set;} //Lvアップ時追加される値
            public int[] level{get; set;}

            public PowerUpData()
            {
                poweUpValue = new int[]{
                    500,2,200,20
                };

                level = new int[]{
                    1,1,1,1
                };
            }
        }

        public GameData gData = new GameData();
        public PowerUpData pData = new PowerUpData();

        public MainForm()
        {
            InitializeComponent();
            this.Controls.Add(new Title(this));
        }

        private void Init()
        {
            gData.unLockedStage = 1;
            gData.Exp = 0;
            gData.maxMoney = 500;
            gData.moneyLevelUpCost = 120;
            gData.PlayerCharaSlot = new Player[]{
                new PlayerChara1(), null, null, null, null
            };
            gData.playerUnLockedList = new Hashtable();
            for(int i=0; i<gData.PlayerCharaSlot.Length; i++){
                if(gData.PlayerCharaSlot[i] != null){
                    gData.playerUnLockedList.Add(gData.PlayerCharaSlot[i].Name, gData.PlayerCharaSlot[i]);
                }
            }
            gData.clearStageList = new bool[StageNum];
            for(int i=0; i<StageNum; i++){
                gData.clearStageList[i] = false;
            }
        }

        public void RefreshPlayerCharaSlot()
        {
            for(int i=0; i<gData.PlayerCharaSlot.Length; i++){
                if(gData.PlayerCharaSlot[i] != null){
                    gData.PlayerCharaSlot[i] = gData.PlayerCharaSlot[i].Refresh();
                }
            }
        }

        public void nextScene(UserControl nextControl)
        {
            this.Controls.Clear();
            this.Controls.Add(nextControl);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("終了してよろしいですか？\n※終了するとデータがリセットされてしまいます。", "終了確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.Cancel){
                e.Cancel = true;
            }
        }
    }
}