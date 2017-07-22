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
using System.Collections;

namespace 顔文字大戦争
{
    public partial class GameScreen : UserControl
    {
        private const int BAR_MAX_NUM = 100;
        private int moneyLevelUpNum = 0;
        private int stageLevel;
        private MainForm fm;
        private Stage stage;
        private int stageNum = 0;
        private int moneyLevelUpCost;
        private List<Player> _playerList = new List<Player>();
        private List<Enemy> _enemyList = new List<Enemy>();
        private List<Structure> _structureList = new List<Structure>();
        private Structure playerStructure, enemyStructure;
        private Button[] CreatePlayerButton;
        private ProgressBar[] CreatePlayerBar;

        public GameScreen(MainForm fm, int stageNum, int stageLevel)
        {
            InitializeComponent();
            screen.init();
            this.fm = fm;
            this.stageNum = stageNum;
            this.stageLevel = stageLevel;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            InitGame();
        }

        private void screen_Resize(object sender, EventArgs e)
        {
        }

        private void InitGame()
        {
            timerMoneyAnimation.Interval = fm.gData.moneyTimerInterval;
            screen.money.maxMoney = fm.gData.maxMoney;
            moneyLevelUpCost = fm.gData.moneyLevelUpCost;
            bt_MoneyUp.Text = "お金上限Up！\n" + moneyLevelUpCost.ToString() + "円";
            CreatePlayerButton = new Button[]{
                bt_CreatePlayer1, bt_CreatePlayer2, bt_CreatePlayer3, bt_CreatePlayer4, bt_CreatePlayer5
            };

            CreatePlayerBar = new ProgressBar[]{
                Bar_Create1, Bar_Create2, Bar_Create3, Bar_Create4, Bar_Create5
            };

            for(int i=0; i<CreatePlayerButton.Length; i++){
                if(fm.gData.PlayerCharaSlot[i] == null){
                    CreatePlayerButton[i].Enabled = false;
                }else{
                    CreatePlayerButton[i].Text = fm.gData.PlayerCharaSlot[i].getMyText() + "\n\n" + fm.gData.PlayerCharaSlot[i].charaState.ProductionCost.ToString() + "円";
                }
            }
            if (stageNum > 10) stageNum = 10;
            switch(stageNum){
                case 1: stage = new Stage1(stageLevel); break;
                case 2: stage = new Stage2(stageLevel); break;
                case 3: stage = new Stage3(stageLevel); break;
                case 4: stage = new Stage4(stageLevel); break;
                case 5: stage = new Stage5(stageLevel); break;
                case 6: stage = new Stage6(stageLevel); break;
                case 7: stage = new Stage7(stageLevel); break;
                case 8: stage = new Stage8(stageLevel); break;
                case 9: stage = new Stage9(stageLevel); break;
                case 10: stage = new Stage10(stageLevel); break;
            }

            playerStructure =  new Structure1(0, screen.Height-300, true, fm.gData.structureHP); //自分の
            enemyStructure = stage.CreateStructure(screen.Width - 120,screen.Height-300, false); //敵の
            screen.structureList.Add(playerStructure);
            screen.structureList.Add(enemyStructure);
        }

        private bool CheckWinGame()
        {
            if(enemyStructure.isDead()){
                return true;
            }else{
                return false;
            }
        }

        private bool CheckLoseGame()
        {
            if(playerStructure.isDead()){
                return true;
            }else{
                return false;
            }
        }

        private void ResultWin()
        {
            MessageBox.Show("大勝利！\n✌('ω'✌ )三✌('ω')✌三( ✌'ω')✌","リザルト");
            if (fm.gData.unLockedStage <= 9 && !fm.gData.clearStageList[stageNum]) fm.gData.unLockedStage++;
            if (!fm.gData.clearStageList[stageNum]) fm.gData.clearStageList[stageNum] = true;

            MessageBox.Show(stage.getExp().ToString() + "経験値獲得！", "報酬");
            fm.gData.Exp += stage.getExp();

            if (stage.NewCharacter() && !fm.gData.playerUnLockedList.ContainsKey(stage.getNewCharacter().Name)){
                MessageBox.Show("新しいキャラクター「"+ stage.getNewCharacter().Name +"」が開放されました！\nユニット編成から確認できます。","キャラクター開放");
                fm.gData.playerUnLockedList.Add(stage.getNewCharacter().Name, stage.getNewCharacter());
            }
            fm.nextScene(new Menu(fm));
        }

        private void ResultLose()
        {
            MessageBox.Show("負け...(◞‸◟)","リザルト");
            fm.nextScene(new Menu(fm));
        }

        private void CreateButtonEnableChange()
        {
            for(int i=0; i<CreatePlayerButton.Length; i++){
                if (fm.gData.PlayerCharaSlot[i] == null) continue;
                if(screen.money.CheckCreateCharacter(fm.gData.PlayerCharaSlot[i].charaState.ProductionCost, false) && CreatePlayerBar[i].Value == BAR_MAX_NUM){
                    CreatePlayerButton[i].Enabled = true;
                }else{
                    CreatePlayerButton[i].Enabled = false;
                }
            }
            if(screen.money.CheckCreateCharacter(moneyLevelUpCost, false)){
                bt_MoneyUp.Enabled = true;
            }else{
                bt_MoneyUp.Enabled = false;
            }
        }

        //30msごとに呼び出される。描画処理と歩くか止まっているかだけを判定する
        private void timerDraw_Tick(object sender, EventArgs e)
        {
            screen.draw();
            DeleteCharacterList();
            CreateButtonEnableChange();
            if(CheckWinGame()){
                timerDraw.Enabled = false;
                ResultWin();
            }
            if(CheckLoseGame()){
                timerDraw.Enabled = false;
                ResultLose();
            }
            for(int i=0; i<CreatePlayerBar.Length; i++){
                if(CreatePlayerBar[i].Value < BAR_MAX_NUM){
                    CreatePlayerBar[i].Value++;
                }
            }
            bool exsistsPlayer = false;
            bool exsistsEnemy = false;
            bool skip1 = false;
            bool skip2 = false;

            //自キャラ用ループ
            foreach(var player in _playerList){
                foreach(var enemy in _enemyList){
                    exsistsEnemy = true;
                    if((player.IntersectsWithEnemy(enemy) && player.charaState.isWalk) || player.charaState.isAttackAnimation){
                        if(player.IntersectsWithEnemy(enemy)){
                            player.charaState.isWalk = false;
                            player.charaState.isAttackAnimation = true;
                            skip1 = true;
                            continue;
                        }
                    }
                    if(!player.IntersectsWithEnemy(enemy) && !player.charaState.isWalk && player.charaState.isAttackAnimation){
                        if(!skip1){
                            player.charaState.isWalk = true;
                            player.charaState.isAttackAnimation = false;
                        }
                    }
                }
                if(!exsistsEnemy){
                    player.charaState.isWalk = true;
                    player.charaState.isAttackAnimation = false;
                }
                skip1 = false;
            }
            
            //敵キャラ用ループ
            foreach(var enemy in _enemyList){
                foreach(var player in _playerList){
                    exsistsPlayer = true;
                    if((enemy.IntersectsWithEnemy(player) && enemy.charaState.isWalk) || enemy.charaState.isAttackAnimation){
                        if(enemy.IntersectsWithEnemy(player)){
                            enemy.charaState.isWalk = false;
                            enemy.charaState.isAttackAnimation = true;
                            skip2 = true;
                            continue;
                        }
                    }
                    if(!enemy.IntersectsWithEnemy(player) && !enemy.charaState.isWalk && enemy.charaState.isAttackAnimation){
                        if(!skip2){
                            enemy.charaState.isWalk = true;
                            enemy.charaState.isAttackAnimation = false;
                        }
                    }
                }
                if(!exsistsPlayer){
                    enemy.charaState.isWalk = true;
                    enemy.charaState.isAttackAnimation = false;
                }
                skip2 = false;
            }
        }

        private void EnemyCreate_Tick(object sender, EventArgs e)
        {
            Enemy enemy = stage.CreateEnemy();
            if (enemy == null) return;
            screen.enemyList.Add(enemy);
            _enemyList.Add(enemy);
        }

        //ここでアニメーションや攻撃・防御判定をする
        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            bool exsistEnemy = false;
            foreach(var player in _playerList){
                player.AttackAnimation();
                if(player.StructureAttack(enemyStructure)){
                    textBox3.Text += "*";
                }
                foreach(var enemy in _enemyList){
                    exsistEnemy = true;
                    textBox4.Text += "*";
                    if(player.Attack(enemy) && player.IntersectsWithEnemy(enemy)){
                        textBox1.Text += "プレイヤー攻撃" + Environment.NewLine;
                        continue;
                    }
                }
                if (!exsistEnemy) player.charaState.isAttack = false;
            }
        }

        private void timerEnemyAnimation_Tick(object sender, EventArgs e)
        {
            bool exsistPlayer = false;
            foreach(var enemy in _enemyList){
                enemy.AttackAnimation();
                enemy.StructureAttack(playerStructure);
                foreach(var player in _playerList){
                    exsistPlayer = true;
                    if(enemy.Attack(player) && enemy.IntersectsWithEnemy(player)){
                        textBox2.Text += "エネミー攻撃" + Environment.NewLine;
                        continue;
                    }
                }
                if (exsistPlayer) enemy.charaState.isAttack = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player p1 = new PlayerChara12();
            screen.playerList.Add(p1);
            _playerList.Add(p1);
        }

        //死んだキャラクターをリストから消す
        private void DeleteCharacterList()
        {
            int enemyDeleteNum;
            _playerList.RemoveAll(x => x.isDead());
            screen.playerList.RemoveAll(x => x.isDead());
            enemyDeleteNum = _enemyList.RemoveAll(x => x.isDead());
            screen.enemyList.RemoveAll(x => x.isDead());

            stage.exsistEnemyNum -= enemyDeleteNum;
            screen.money.money += enemyDeleteNum * fm.gData.KnockdownBonus;
        }

        private void bt_CreatePlayer1_Click(object sender, EventArgs e)
        {
            if( CreatePlayerBar[0].Value == BAR_MAX_NUM){
                Player player = fm.gData.PlayerCharaSlot[0];
                if(screen.money.CheckCreateCharacter(player.charaState.ProductionCost, true)){
                    screen.playerList.Add(player);
                    this._playerList.Add(player);
                    fm.RefreshPlayerCharaSlot();
                    CreatePlayerBar[0].Value = 0;
                }
            }
        }

        private void bt_CreatePlayer2_Click(object sender, EventArgs e)
        {
            if( CreatePlayerBar[1].Value == BAR_MAX_NUM){
                Player player = fm.gData.PlayerCharaSlot[1];
                if(screen.money.CheckCreateCharacter(player.charaState.ProductionCost,true)){
                    screen.playerList.Add(player);
                    this._playerList.Add(player);
                    fm.RefreshPlayerCharaSlot();
                    CreatePlayerBar[1].Value = 0;
                }
            }
        }

        private void bt_CreatePlayer3_Click(object sender, EventArgs e)
        {
            if( CreatePlayerBar[2].Value == BAR_MAX_NUM){
                Player player = fm.gData.PlayerCharaSlot[2];
                if(screen.money.CheckCreateCharacter(player.charaState.ProductionCost, true)){
                    screen.playerList.Add(player);
                    this._playerList.Add(player);
                    fm.RefreshPlayerCharaSlot();
                    CreatePlayerBar[2].Value = 0;
                }
            }
        }

        private void bt_CreatePlayer4_Click(object sender, EventArgs e)
        {
            if( CreatePlayerBar[3].Value == BAR_MAX_NUM){
                Player player = fm.gData.PlayerCharaSlot[3];
                if(screen.money.CheckCreateCharacter(player.charaState.ProductionCost, true)){
                    screen.playerList.Add(player);
                    this._playerList.Add(player);
                    fm.RefreshPlayerCharaSlot();
                    CreatePlayerBar[3].Value = 0;
                }
            }
        }

        private void bt_CreatePlayer5_Click(object sender, EventArgs e)
        {
            if( CreatePlayerBar[4].Value == BAR_MAX_NUM){
                Player player = fm.gData.PlayerCharaSlot[4];
                if(screen.money.CheckCreateCharacter(player.charaState.ProductionCost, true)){
                    screen.playerList.Add(player);
                    this._playerList.Add(player);
                    fm.RefreshPlayerCharaSlot();
                    CreatePlayerBar[4].Value = 0;
                }
            }
        }

        private void bt_MoneyUp_Click(object sender, EventArgs e)
        {
            if(screen.money.CheckCreateCharacter(moneyLevelUpCost, true) && moneyLevelUpNum <= 8){
                screen.money.maxMoney += 400;
                moneyLevelUpCost += 160;
                //timerMoneyAnimation.Interval -= 2;
                bt_MoneyUp.Text = "お金上限Up！\n" + moneyLevelUpCost.ToString() + "円";
                moneyLevelUpNum++;
            }
        }

        private void timerMoneyAnimation_Tick(object sender, EventArgs e)
        {
            screen.money.animation();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
