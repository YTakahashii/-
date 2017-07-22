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
    public partial class UnitChange : UserControl
    {
        private MainForm fm;
        private ComboBox[] comboList;
        private Label[] imageLabelList, costLabelList;
        public UnitChange(MainForm fm)
        {
            InitializeComponent();
            this.fm = fm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fm.nextScene(new Menu(fm));
        }

        private void UnitChange_Load(object sender, EventArgs e)
        {
            comboList = new ComboBox[]{
                comboBox1, comboBox2, comboBox3, comboBox4, comboBox5
            };

            imageLabelList = new Label[]{
                lb_characterImage1, lb_characterImage2, lb_characterImage3, lb_characterImage4, lb_characterImage5
            };

            costLabelList = new Label[]{
                lb_Cost1, lb_Cost2, lb_Cost3, lb_Cost4, lb_Cost5
            };

            for (int i = 0; i < comboList.Length; i++)
            {
                foreach (string s in fm.gData.playerUnLockedList.Keys)
                {
                    comboList[i].Items.Add(s);
                }

                if (fm.gData.PlayerCharaSlot[i] != null)
                {
                    comboList[i].Text = fm.gData.PlayerCharaSlot[i].Name;
                }
            }
            for(int i=0; i<comboList.Length; i++){
                if(comboList[i].Text == ""){
                    imageLabelList[i].Text = "No Image";
                    costLabelList[i].Text = "0円";
                }
            }

        }

        private void comboListRefresh(int i)
        {
            comboList[i].Items.Clear();
            foreach(string s in fm.gData.playerUnLockedList.Keys){
                comboList[i].Items.Add(s);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player player = (Player)fm.gData.playerUnLockedList[comboBox1.Text];
            if(comboBox1.Text != ""){
                lb_characterImage1.Text = player.getMyText();
                lb_Cost1.Text = player.charaState.ProductionCost.ToString() + "円";
            }else{
                return;
            }

            int index = 0;
            if(comboList[index].Text != ""){
                for(int i=0; i<comboList.Length; i++){
                    if(i != index && comboList[index].Text == comboList[i].Text){
                        comboListRefresh(index);
                        imageLabelList[index].Text = "No Image";
                        costLabelList[index].Text = "0円";
                        MessageBox.Show("同じキャラクターを複数のスロットに設定することはできません！","コラコラコラコラ～ッ！(`o´)");
                        break;
                    }else{
                        fm.gData.PlayerCharaSlot[index] = player;
                    }
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player player = (Player)fm.gData.playerUnLockedList[comboBox2.Text];
            if(comboBox2.Text != ""){
                lb_characterImage2.Text = player.getMyText();
                lb_Cost2.Text = player.charaState.ProductionCost.ToString() + "円";
            }else{
                return;
            }

            int index = 1;
            
            if(comboList[index].Text != ""){
                for(int i=0; i<comboList.Length; i++){
                    if(i != index && comboList[index].Text == comboList[i].Text){
                        comboListRefresh(index);
                        imageLabelList[index].Text = "No Image";
                        costLabelList[index].Text = "0円";
                        fm.gData.PlayerCharaSlot[index] = null;
                        MessageBox.Show("同じキャラクターを複数のスロットに設定することはできません！","コラコラコラコラ～ッ！(`o´)");
                        break;
                    }else{
                        fm.gData.PlayerCharaSlot[index] = player;
                    }
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player player = (Player)fm.gData.playerUnLockedList[comboBox3.Text];
            if(comboBox3.Text != ""){            
                lb_characterImage3.Text = player.getMyText();
                lb_Cost3.Text = player.charaState.ProductionCost.ToString() + "円";
            }else{
                return;
            }

            int index = 2;
            if(comboList[index].Text != ""){
                for(int i=0; i<comboList.Length; i++){
                    if(i != index && comboList[index].Text == comboList[i].Text){
                        comboListRefresh(index);
                        imageLabelList[index].Text = "No Image";
                        costLabelList[index].Text = "0円";
                        fm.gData.PlayerCharaSlot[index] = null;
                        MessageBox.Show("同じキャラクターを複数のスロットに設定することはできません！","コラコラコラコラ～ッ！(`o´)");
                        break;
                    }else{
                        fm.gData.PlayerCharaSlot[index] = player;
                    }
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player player = (Player)fm.gData.playerUnLockedList[comboBox4.Text];
            if(comboBox4.Text != ""){      
                lb_characterImage4.Text = player.getMyText();
                lb_Cost4.Text = player.charaState.ProductionCost.ToString() + "円";
            }else{
                return;
            }

            int index = 3;
            if(comboList[index].Text != ""){
                for(int i=0; i<comboList.Length; i++){
                    if(i != index && comboList[index].Text == comboList[i].Text){
                        comboListRefresh(index);
                        imageLabelList[index].Text = "No Image";
                        costLabelList[index].Text = "0円";
                        fm.gData.PlayerCharaSlot[index] = null;
                        MessageBox.Show("同じキャラクターを複数のスロットに設定することはできません！","コラコラコラコラ～ッ！(`o´)");
                        break;
                    }else{
                        fm.gData.PlayerCharaSlot[index] = player;
                    }
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player player = (Player)fm.gData.playerUnLockedList[comboBox5.Text];
            if(comboBox5.Text != ""){  
                lb_characterImage5.Text = player.getMyText();
                lb_Cost5.Text = player.charaState.ProductionCost.ToString() + "円";
            }else{
                return;
            }

            int index = 4;
            if(comboList[index].Text != ""){
                for(int i=0; i<comboList.Length; i++){
                    if(i != index && comboList[index].Text == comboList[i].Text){
                        comboListRefresh(index);
                        imageLabelList[index].Text = "No Image";
                        costLabelList[index].Text = "0円";
                        fm.gData.PlayerCharaSlot[index] = null;
                        MessageBox.Show("同じキャラクターを複数のスロットに設定することはできません！","コラコラコラコラ～ッ！(`o´)");
                        break;
                    }else{
                        fm.gData.PlayerCharaSlot[index] = player;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ここではユニットの編成を行えます。\n「スロット1～5」の下にあるリストをクリックすると、現在取得しているキャラクターをセットできます。\n" +
                "キャラクターはステージをクリアすることで取得することができます。お気に入りの5体で遊びましょう！", "ヘルプ", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void bt_Showinfo1_Click(object sender, EventArgs e)
        {
            if(fm.gData.PlayerCharaSlot[0] == null){
                MessageBox.Show("キャラクターがセットされていません。","キャラクター情報",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(fm.gData.PlayerCharaSlot[0].CharacterInfo(),"キャラクター情報");
        }

        private void bt_Showinfo2_Click(object sender, EventArgs e)
        {
            if(fm.gData.PlayerCharaSlot[1] == null){
                MessageBox.Show("キャラクターがセットされていません。","キャラクター情報",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(fm.gData.PlayerCharaSlot[1].CharacterInfo(),"キャラクター情報");
        }

        private void bt_Showinfo3_Click(object sender, EventArgs e)
        {
            if(fm.gData.PlayerCharaSlot[2] == null){
                MessageBox.Show("キャラクターがセットされていません。","キャラクター情報",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(fm.gData.PlayerCharaSlot[2].CharacterInfo(),"キャラクター情報");
        }

        private void bt_Showinfo4_Click(object sender, EventArgs e)
        {
            if(fm.gData.PlayerCharaSlot[3] == null){
                MessageBox.Show("キャラクターがセットされていません。","キャラクター情報",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(fm.gData.PlayerCharaSlot[3].CharacterInfo(),"キャラクター情報");
        }

        private void bt_Showinfo5_Click(object sender, EventArgs e)
        {
            if(fm.gData.PlayerCharaSlot[4] == null){
                MessageBox.Show("キャラクターがセットされていません。","キャラクター情報",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(fm.gData.PlayerCharaSlot[4].CharacterInfo(),"キャラクター情報");
        }
    }
}
