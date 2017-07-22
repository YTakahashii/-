using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 顔文字大戦争
{
    public interface ICharacter
    {
        void draw(Graphics g);
        void animation(ScreenPictureBox screen);
        bool isDead(); //CharacterStatus...isDead取得用
    }

    public enum ActionStatus{
        /*キャラクターの状態*/
        Walk, Attack, Wait, Wince, Dead
    }
    public enum CharaDataIndex{
        /*charaData[]の添え字用*/
        Normal, Attack, Damege, Comment
    }
    
    public class CharacterStatus
    {
        //Player
        public CharacterStatus(int HP, int ATTACK,int ProductionCost, Brush Color, bool isPlayer)
        {
            this.HP = HP;
            this.ATTACK = ATTACK;
            isAttack = false;
            isAttackAnimation = false;
            isWalk = true;
            isDead = false;
            this.isPlayer = isPlayer;
            this.ProductionCost = ProductionCost;
            this.Color = Color;
        }
        //Enemy
        public CharacterStatus(int HP, int ATTACK, Brush Color, bool isPlayer)
        {
            this.HP = HP;
            this.ATTACK = ATTACK;
            isAttack = false;
            isAttackAnimation = false;
            isWalk = true;
            isDead = false;
            this.isPlayer = isPlayer;
            this.Color = Color;
        }
        //キャラのステータス変数は大文字にする
        public int HP{get; set;}
        public int ATTACK{get; set;}
        public bool isAttack{get; set;}
        public bool isWalk{get; set;}
        public bool isAttackAnimation{get; set;}
        public bool isDead{get; set;}
        public bool isPlayer{get; set;}
        public int ProductionCost{get; set;}
        public Brush Color{get; set;}
    }
}
