using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;

namespace 顔文字大戦争
{
    public abstract class Player : ICharacter
    {
        private Font font = new Font("MS UI Gothic", 10, FontStyle.Bold);
        private string[] charaData; //現在のキャラテキスト
        private string characomment = ""; //キャラのせりふ
        protected Point point;
        private const int stopPoint = 950;
        public string Name{get; set;}
        public string buttonText{get; set;}
        private Vector vec;
        public Size charaSize = new Size();

        private ActionStatus actionstate;
        public CharacterStatus charaState;
        private CharaDataIndex charaIndex = CharaDataIndex.Normal;
        private Rectangle NO_RECT = new Rectangle(0, 0, 0, 0);

        private PatternManager pm = new PatternManager();

        protected Player(string[] charaData, int x, int y, Size charaSize, Vector vec, CharacterStatus charaState)
        {
            this.charaData = charaData;
            this.charaState = charaState;
            this.characomment = charaData[(int)CharaDataIndex.Comment];
            point = new Point(x,y);
            this.vec = vec;
            this.charaSize = charaSize;
            this.charaState.isPlayer = true;
            actionstate = ActionStatus.Walk;
        }

        public void draw(Graphics g)
        {
            string drawingChara = pm.getCharaPattern(charaData, charaIndex);

             switch(actionstate){
                case ActionStatus.Walk:
                    g.DrawString(drawingChara, font, charaState.Color, point.X, point.Y);
                    break;
                case ActionStatus.Attack:
                     g.DrawString(drawingChara, font, Brushes.Red, point.X, point.Y);
                    break;
                 case ActionStatus.Wait:
                     g.DrawString(drawingChara, font, charaState.Color, point.X, point.Y);
                    break;
                case ActionStatus.Wince:
                     g.DrawString(drawingChara, font, Brushes.Blue, point.X, point.Y);
                    break;
                case ActionStatus.Dead:
                    g.DrawString(drawingChara, font, Brushes.Yellow, point.X, point.Y);
                    break;
            }
        }
        
        public void animation(ScreenPictureBox screen)
        {
            if(charaState.isWalk){
                point.X += vec.dx;
            }
            if (this.point.X > stopPoint -charaSize.Width) this.point.X = stopPoint - charaSize.Width;
            switch(actionstate){
                case ActionStatus.Walk:
                    charaIndex = CharaDataIndex.Normal;
                    break;
                case ActionStatus.Attack:
                    charaIndex = CharaDataIndex.Attack;
                    break;
                case ActionStatus.Wait:
                    charaIndex = CharaDataIndex.Normal;
                    break;
                case ActionStatus.Wince:
                    charaIndex = CharaDataIndex.Damege;
                    break;
                case ActionStatus.Dead:
                    charaIndex = CharaDataIndex.Damege;
                    break;
            }
        }

        public bool isDead()
        {
            if(this.charaState.HP <= 0){
                this.charaState.isDead = true;
            }else{
                this.charaState.isDead = false;
            }
            return this.charaState.isDead;
        }

        public ActionStatus getactionstate()
        {
            return actionstate;
        }
        public Rectangle getAttackRect()
        {
            return new Rectangle(point,charaSize);
        }

        public Rectangle getDefenseRect()
        {
            Rectangle result;
            switch(actionstate){
                case ActionStatus.Wince:
                    result = NO_RECT;
                    break;
                default:
                    result = new Rectangle(point,charaSize);
                    break;
            }
            return result;
        }

        /*自分のキャラの前にあるキャラのれくたんぐる*/
        public Rectangle FrontRect(Point frontpoint)
        {
            return new Rectangle(frontpoint, new Size(10, 10));
        }

        //攻撃可能かどうか判定
        public bool AbleToAttack(Enemy enemy){
            if(this.getAttackRect().IntersectsWith(enemy.getDefenseRect()) && actionstate != ActionStatus.Attack){
                return true;
            }else{
                return false;
            }
        }

        //止まるかどうか
        public bool IntersectsWithEnemy(Enemy enemy){
            if(this.getAttackRect().IntersectsWith(enemy.getDefenseRect())){
                return true;
            }else{
                return false;
            }
        }
        public bool IntersectsWithStructure(Structure structuer){
            if(this.getAttackRect().IntersectsWith(structuer.getMyRect())){
                return true;
            }else{
                return false;
            }
        }
        public bool Attack(Enemy enemy)
        {
            bool result = false;
            if(this.charaState.isAttack && this.charaState.isAttackAnimation && this.actionstate == ActionStatus.Attack){
                enemy.Damage(this.charaState.ATTACK); 
                result = true;
            }
            this.charaState.isAttack = false;
            return result;
        }

        public bool StructureAttack(Structure structure)
        {  
            bool result = false;
            if(this.charaState.isAttack && this.charaState.isAttackAnimation && this.actionstate == ActionStatus.Attack && this.IntersectsWithStructure(structure) && !structure.charaState.isPlayer){
                structure.Damege(this.charaState.ATTACK); 
                result = true;
            }
            return result;
        }
        
        public void Damage(int damege)
        {
            this.charaState.HP -= damege;
        }

        public void AttackAnimation()
        {
            if (this.point.X >= stopPoint - charaSize.Width){
                this.charaState.isAttackAnimation = true;
                this.charaState.isWalk = false;
            }
            this.charaState.isAttack = !this.charaState.isAttack;
            actionstate = pm.nextActionPattern(actionstate, charaState.isWalk);
        }

        public abstract Player Refresh();
        public abstract string CharacterInfo();
        public string getMyText()
        {
            return buttonText;
        }
    }

    public class PlayerChara1 : Player
    {
        private static string[] charaData = { "(∩`ω´)", "(∩`ω´)⊃))" ,"(∩ﾟω.)","しゅっしゅ"}; //通常・攻撃・被ダメ・テキスト
        private static Size _charaSize = new Size(65, 12);
        private static Vector vec = new Vector(3, 0);
        public PlayerChara1() : base(charaData, 50, 370, _charaSize, vec, new CharacterStatus(50,5,50,Brushes.Blue,true))
        {
            base.Name = "パンチマン";
            base.buttonText = charaData[1];
        }
        public override Player Refresh()
        {
            return new PlayerChara1();
        }

        public override string CharacterInfo()
        {
            string info = "最初から使える低コストの基本キャラ。\n数で圧倒しよう。\n体力：☆\n攻撃：☆";
            return info;
        }
    }

    public class PlayerChara2 : Player
    {
        private static string[] charaData = { "(# ・ω・)", "(# `)3')▃▃▃▅▆▇▉","(∩ﾟω.)", "ブオオオオオオオ" }; //通常・攻撃・被ダメ・テキスト
        private static Size _charaSize = new Size(65, 12);
        private static Vector vec = new Vector(3, 0);
        public PlayerChara2() : base(charaData, 50, 370, _charaSize, vec, new CharacterStatus(50,10,100, Brushes.OrangeRed,true))
        {
            base.Name = "ブオオオオオ";
            base.buttonText = charaData[1];
        }

        public override Player Refresh()
        {
            return new PlayerChara2();
        }

        public override string CharacterInfo()
        {
            string info = "攻撃がパンチマンよりちょっとだけ高いアタッカーキャラ。\n体力：☆\n攻撃：☆☆";
            return info;
        }
    }

    public class PlayerChara3 : Player
    {
        private static string[] charaData = { "(っ'ヮ'c)   ", "─=≡Σ((((っ’ヮ’c)","＜(｡ε°)＞", "ｳﾋｮｧｧｧｧｗｗｗ" }; //通常・攻撃・被ダメ・テキスト
        private static Size _charaSize = new Size(51, 13);
        private static Vector vec = new Vector(3, 0);
        public PlayerChara3() : base(charaData, 50, 370, _charaSize, vec, new CharacterStatus(70,12,120, Brushes.Pink,true))
        {
            base.Name = "テンション高い人";
            base.buttonText = charaData[1];
        }

        public override Player Refresh()
        {
            return new PlayerChara3();
        }
        public override string CharacterInfo()
        {
            string info = "パンチマンがハイテンションになった姿。ＨＰと攻撃がちょっと上がった。\n体力：☆☆\n攻撃：☆";
            return info;
        }
    }

    public class PlayerChara4 : Player
    {
        private static string[] charaData = { "(@ ・ω・@)", "٩(๑`^´๑)۶༄༅༄༅༄༅༄༅","＜(｡ε°)＞", "ムカ着火ファイアー！" }; //通常・攻撃・被ダメ・テキスト
        private static Size _charaSize = new Size(72, 12);
        private static Vector vec = new Vector(3, 0);
        public PlayerChara4() : base(charaData, 50, 370, _charaSize, vec, new CharacterStatus(65,20,500, Brushes.MediumVioletRed, true))//強キャラ
        {
            base.Name = "激おこプンプン丸";
            base.buttonText = charaData[1];
        }

        public override Player Refresh()
        {
            return new PlayerChara4();
        }
        public override string CharacterInfo()
        {
            string info = "ムカ着火ファイアー。攻撃力が高い。\n体力：☆☆\n攻撃：☆☆☆☆";
            return info;
        }
    }

    public class PlayerChara5 : Player
    {
        private static string[] charaData = { "（m(|||Д||)m", "（m(|||Дﾟ)彡怨怨怨怨怨","＜(｡ε°)＞", "ムカ着火ファイアー！" }; //通常・攻撃・被ダメ・テキスト
        private static Size _charaSize = new Size(81, 12);
        private static Vector vec = new Vector(1, 0);
        public PlayerChara5() : base(charaData, 50, 370, _charaSize, vec, new CharacterStatus(70,25,650, Brushes.Violet, true))//強キャラ
        {
            base.Name = "さだこ";
            base.buttonText = charaData[1];
        }

        public override Player Refresh()
        {
            return new PlayerChara5();
        }
        public override string CharacterInfo()
        {
            string info = "不遇な倒され方をした顔文字が悪霊になった姿。能力はトップクラスだが鈍足。\n体力：☆☆☆\n攻撃：☆☆☆☆☆";
            return info;
        }
    }

    public class PlayerChara6 : Player
    {
        private static string[] charaData = { "(#ﾟωﾟ)", "(#ﾟ0《《《炎炎炎","＜(｡ε°)＞", "ムカ着火ファイアー！" }; //通常・攻撃・被ダメ・テキスト
        private static Size _charaSize = new Size(47, 12);
        private static Vector vec = new Vector(2, 0);
        public PlayerChara6() : base(charaData, 50, 370, _charaSize, vec, new CharacterStatus(25,25,150, Brushes.Violet, true))
        {
            base.Name = "火吹き男";
            base.buttonText = charaData[1];
        }

        public override Player Refresh()
        {
            return new PlayerChara6();
        }
        public override string CharacterInfo()
        {
            string info = "攻撃はトップクラスだが体力が絶望的に低い。使えるかは正直微妙。\n体力：▲\n攻撃:☆☆☆☆☆";
            return info;
        }
    }

    public class PlayerChara7 : Player
    {
        private static string[] charaData = { "(#ΦwΦ)", "(#ΦwΦ)==○)","＜(｡ε°)＞", "ムカ着火ファイアー！" }; //通常・攻撃・被ダメ・テキスト
        private static Size _charaSize = new Size(62, 12);
        private static Vector vec = new Vector(6, 0);
        public PlayerChara7() : base(charaData, 50, 370, _charaSize, vec, new CharacterStatus(60,17,140, Brushes.Violet, true))
        {
            base.Name = "ネコパンチ";
            base.buttonText = charaData[1];
        }

        public override Player Refresh()
        {
            return new PlayerChara7();
        }
        public override string CharacterInfo()
        {
            string info = "とっても足が速い。\n体力：☆\n攻撃：☆☆";
            return info;
        }
    }

    public class PlayerChara8 : Player
    {
        private static string s =
            "       三→\n" +
            "Ɛ(*ﾟДﾟ)三→→\n" +
            "       三→";
        private static string[] charaData = { "Ɛ(*ﾟｰﾟ)_†", s,"＜(｡ε°)＞", "ムカ着火ファイアー！" }; //通常・攻撃・被ダメ・テキスト
        private static Size _charaSize = new Size(62, 12);
        private static Vector vec = new Vector(4, 0);
        public PlayerChara8() : base(charaData, 50, 370, _charaSize, vec, new CharacterStatus(80,25,800, Brushes.Violet, true))
        {
            base.Name = "エンジェル";
            base.buttonText = charaData[0];
        }

        public override Player Refresh()
        {
            return new PlayerChara8();
        }
        public override string CharacterInfo()
        {
            string info = "体力・攻撃共に優秀なキャラ。\n体力：☆☆☆☆\n攻撃：☆☆☆☆☆";
            return info;
        }
    }

    public class PlayerChara9 : Player
    {
        private static string s1 =
            "　 　 　　       ,／⌒ノ⌒ノ＾ﾍﾍ\n"+
            "　 　　　     ／＜)＜) ノ 　。　〉\n"+
            "　 　      γ＜）ノヘヘ　ヘ_､__ﾉ\n"+
            "　 　    ＜)_ノ＾＾Ｙ　 （ ・３・） ヽ、\n"+
            "　       ＜）ノ＾ノ Lmｲ三ﾉへ_m}\n"+
            " ∧∧___＜)ノ＾ｲ 　ｨ三イ＾ヽ、\n"+
            "（＿人<)<)ﾉ＾_/|_ｍ|￣｀L_ｍ|\n";

        private static string s2 =
            "   　 　 　　       ,／⌒ノ⌒ノ＾ﾍﾍ\n"+
            "   　 　　　     ／＜)＜) ノ 　`　〉\n"+
            "   　 　      γ＜）ノヘヘ　ヘ_､__ﾉ\n"+
            "   　 　    ＜)_ノ＾＾Ｙ　 （ `Д） ヽ、\n"+
            "   　       ＜）ノ＾ノ Lmｲ三ﾉへ_m}\n"+
            "    ∧∧___＜)ノ＾ｲ 　ｨ三イ＾ヽ、\n"+
            "   （＿人<)<)ﾉ＾_/|_ｍ|￣｀L_ｍ|\n";
        private static string s3 =
            "      　 　 　　       ,／⌒ノ⌒ノ＾ﾍﾍ\n"+
            "      　 　　　     ／＜)＜) ノ 　`　〉\n"+
            "      　 　      γ＜）ノヘヘ　ヘ_､__ﾉ\n"+
            "      　 　    ＜)_ノ＾＾Ｙ　 （ `Д） ヽ、\n"+
            "      　       ＜）ノ＾ノ Lmｲ三ﾉへ_m}\n"+
            "       ∧∧___＜)ノ＾ｲ 　ｨ三イ＾ヽ、\n"+
            "      （＿人<)<)ﾉ＾_/|_ｍ|￣｀L_ｍ|\n";
        private static string[] charaData = { s1, s3,"＜(｡ε°)＞", "ムカ着火ファイアー！" }; //通常・攻撃・被ダメ・テキスト
        private static Size _charaSize = new Size(165, 100);
        private static Vector vec = new Vector(1, 0);
        public PlayerChara9() : base(charaData, -100, 300, _charaSize, vec, new CharacterStatus(200,50,1300, Brushes.DarkBlue, true))
        {
            base.Name = "アンキロサウルス";
            base.buttonText = "アンキロサウルス";
        }
        

        public override Player Refresh()
        {
            return new PlayerChara9();
        }
        public override string CharacterInfo()
        {
            string info = "強靭な体力と攻撃を身につけた恐竜。\n体力：☆☆☆☆☆☆☆☆\n攻撃：☆☆☆☆☆☆☆☆☆☆";
            return info;
        }
    }

    public class PlayerChara10 : Player
    {
        private static string s1 =
            "        |＼＿＿＿ \n" +
            "        / :::::::｡::::::;;;;;;>\n" +
            "      /::::::::ﾒ::;;;www\n" +
            " )ヽ/ とノ （ ・３・)つ\n" +
            "ﾒノ'＼ 　　　／\n" +
            " 　　　^U^U\n";

        private static string s2 =
            "                  ____\n"+
            "           |＼/ ::::::;;;;;;>\n"+
            "           / :::::::/ `\n"+
            "         /::::::::ﾒ::;;;www\n"+
            "    )ヽ/ とノ （ `Д)つ\n"+
            "   ﾒノ'＼ 　　　／\n"+
            "    　　　^U^U\n";
        private static string[] charaData = { s1, s2,"＜(｡ε°)＞", "ムカ着火ファイアー！" }; //通常・攻撃・被ダメ・テキスト
        private static Size _charaSize = new Size(125, 75);
        private static Vector vec = new Vector(5, 0);
        public PlayerChara10() : base(charaData, -100, 300, _charaSize, vec, new CharacterStatus(65,30,900, Brushes.Blue, true))
        {
            base.Name = "サメ";
            base.buttonText =  "サメ";
        }

        public override Player Refresh()
        {
            return new PlayerChara10();
        }
        public override string CharacterInfo()
        {
            string info = "足の速さと攻撃の高さが際立つキャラ。\n体力：☆☆\n攻撃：☆☆☆☆☆☆";
            return info;
        }
    }

    public class PlayerChara11 : Player
    {
        private static string[] charaData = { "(ﾉ)・ω・(ヾ)", "(ﾉ)・ω・(ヾ)","＜(｡ε°)＞", "ムカ着火ファイアー！" }; //通常・攻撃・被ダメ・テキスト
        private static Size _charaSize = new Size(125, 75);
        private static Vector vec = new Vector(3, 0);
        public PlayerChara11() : base(charaData, 50, 370, _charaSize, vec, new CharacterStatus(100,0,100, Brushes.Blue, true))
        {
            base.Name = "ムニムニ";
            base.buttonText =  "(ﾉ)・ω・(ヾ)";
        }

        public override Player Refresh()
        {
            return new PlayerChara11();
        }
        public override string CharacterInfo()
        {
            string info = "体力が高い壁用キャラ。攻撃はできない。\n体力：☆☆☆☆☆\n攻撃：×";
            return info;
        }
    }

    public class PlayerChara12 : Player
    {
        private static string s1 =
            "　　,,Λ＿＿Λ\n"+
            "　 /;;;;:::::.・３・::;ヽ\n"+
            "　/;;;;::::::;;;:::::::;;;:;;;:ヽつ\n"+
            "/;;:::::（/▲ ▲ ▲ .|\n"+
            "i;;;::::::;;\" .▲ ▲ ▲.i\n"+
            "|;;;;;:::::i　　　　　　　l\n"+
            "'ヽ;;;;;;;＿＿＿＿_/\n";

        private static string[] charaData = { s1, s1,"＜(｡ε°)＞", "ムカ着火ファイアー！" }; //通常・攻撃・被ダメ・テキスト
        private static Size _charaSize = new Size(125, 75);
        private static Vector vec = new Vector(3, 0);
        public PlayerChara12() : base(charaData, -100, 300, _charaSize, vec, new CharacterStatus(300,0,250, Brushes.Blue, true))
        {
            base.Name = "トトロ";
            base.buttonText =  "トトロ";
        }

        public override Player Refresh()
        {
            return new PlayerChara12();
        }
        public override string CharacterInfo()
        {
            string info = "ムニムニの3倍の体力を持つキャラ。攻撃はできない。\n体力：☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆\n攻撃：×";
            return info;
        }
    }
}

