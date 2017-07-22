using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 顔文字大戦争
{
    public abstract class Enemy : ICharacter
    {
        private Font font = new Font("MS UI Gothic", 10,FontStyle.Bold);
        private string[] charaData; //現在のキャラテキスト
        private string characomment = ""; //キャラのせりふ
        private Point point;
        private const int stopPoint = 80;
        public void setPointX(int newPointX)
        {
            point.X = newPointX;
        }
        public int getPointX()
        {
            return point.X;
        }
        private Vector vec;
        private Size charaSize = new Size();

        private ActionStatus actionstate;
        public CharacterStatus charaState;
        private CharaDataIndex charaIndex = CharaDataIndex.Normal;
        private Rectangle NO_RECT = new Rectangle(0, 0, 0, 0);

        private PatternManager pm = new PatternManager();

        protected Enemy(string[] charaData, int x, int y, Size charaSize, Vector vec, CharacterStatus charaState)
        {
            this.charaData = charaData;
            this.charaState = charaState;
            this.characomment = charaData[(int)CharaDataIndex.Comment];
            point = new Point(x,y);
            this.vec = vec;
            this.charaSize = charaSize;
            this.charaState.isPlayer = false;
            actionstate = ActionStatus.Walk;
        }

        public void draw(Graphics g)
        {
            string drawingChara = pm.getCharaPattern(charaData, charaIndex);
            g.DrawString(drawingChara, font, charaState.Color, point.X, point.Y);
            /*
             switch(actionstate){
                case ActionStatus.Walk:
                    g.DrawString(drawingChara, font, charaState.Color, point.X, point.Y);
                    break;
                case ActionStatus.Attack:
                    //攻撃判定
                     g.DrawString(drawingChara, font, Brushes.Red, point.X, point.Y);
                    break;
                 case ActionStatus.Wait:
                     g.DrawString(drawingChara, font, charaState.Color, point.X, point.Y);
                    break;
                case ActionStatus.Wince:
                    //後ろにちょっとだけ飛ぶ
                     g.DrawString(drawingChara, font, Brushes.Blue, point.X, point.Y);
                    break;
                case ActionStatus.Dead:
                    g.DrawString(drawingChara, font, Brushes.Yellow, point.X, point.Y);
                    break;
            }
            */
            
        }

        public void animation(ScreenPictureBox pic)
        {
            if(this.charaState.isWalk){
                point.X += vec.dx;
            }
            if (this.point.X <= stopPoint) this.point.X = stopPoint;
            
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
        public Rectangle getAttackRect_Structure()
        {
            return new Rectangle(point.X + 5, point.Y, charaSize.Width, charaSize.Height);
        }

        public Rectangle getAttackRect()
        {
            return new Rectangle(point, charaSize);
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

        //止まるかどうか
        public bool IntersectsWithEnemy(Player player){
            if(this.getAttackRect().IntersectsWith(player.getDefenseRect())){
                return true;
            }else{
                return false;
            }
        }

        public bool IntersectsWithStructure(Structure structure){
            if(this.getAttackRect_Structure().IntersectsWith(structure.getMyRect())){
                return true;
            }else{
                return false;
            }
        }

        public bool Attack(Player player)
        {
            bool result = false;
            if(this.charaState.isAttack && this.charaState.isAttackAnimation && this.actionstate == ActionStatus.Attack){
                player.Damage(this.charaState.ATTACK); 
                result = true;
            }
            this.charaState.isAttack = false;
            return result;
        }

        public bool StructureAttack(Structure structure)
        {
            bool result = false;
            if(this.charaState.isAttack && this.charaState.isAttackAnimation && this.actionstate == ActionStatus.Attack && this.IntersectsWithStructure(structure) && structure.charaState.isPlayer){
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
            if(this.point.X <= stopPoint){
                this.charaState.isAttackAnimation = true;
                this.charaState.isWalk = false;
            }
            this.charaState.isAttack = !this.charaState.isAttack;
            actionstate = pm.nextActionPattern(actionstate, charaState.isWalk);
        }

        public abstract Enemy Refresh();
    }

    public class EnemyChara1 : Enemy
    {
        private static string[] charaData = {"(`ω´∩)", "((⊂(`ω´∩)", "(。ωﾟ∩)", "しゅっしゅ"};
        private static Size charaSize = new Size(48, 12);
        
        public EnemyChara1() : base(charaData, 900, 370, charaSize, new Vector(-5,0), new CharacterStatus(50,5, Brushes.Blue ,false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara1();
        }
    }

    public class EnemyChara1Ex : Enemy
    {
        private static string[] charaData = {"(`ω´∩)", "((⊂(`ω´∩)", "(。ωﾟ∩)", "しゅっしゅ"};
        private static Size charaSize = new Size(48, 12);

        public EnemyChara1Ex() : base(charaData, 900, 370, charaSize, new Vector(-5,0), new CharacterStatus(60,7, Brushes.DarkOrange, false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara1Ex();
        }
    }

    public class EnemyChara2 : Enemy
    {
        private static string[] charaData = {"      (✧ω✧ ∩)", "▒▒▓█▇▅▂(✧Д(✧∩)", "(。ωﾟ∩)", "ブオオオオ"};
        private static Size charaSize = new Size(90, 12);

        public EnemyChara2() : base(charaData, 900, 370, charaSize, new Vector(-4,0), new CharacterStatus(50,8, Brushes.Yellow, false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara4();
        }
    }

    public class EnemyChara2Ex : Enemy
    {
        private static string[] charaData = {"      (✧ω✧ ∩)", "▒▒▓█▇▅▂(✧Д(✧∩)", "(。ωﾟ∩)", "ブオオオオ"};
        private static Size charaSize = new Size(90, 12);

        public EnemyChara2Ex() : base(charaData, 900, 370, charaSize, new Vector(-4,0), new CharacterStatus(60,12, Brushes.Yellow, false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara4Ex();
        }
    }

    public class EnemyChara3 : Enemy
    {
        private static string[] charaData = { "      (・8・*)", "炎炎炎炎>(◇´*)", "(。ωﾟ∩)", "ｶﾈｶﾈｶﾈｶﾈ" };

        public EnemyChara3() : base(charaData, 900, 370, new Size(100,20), new Vector(-4,0), new CharacterStatus(40,15, Brushes.DarkRed, false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara3();
        }
    }

    public class EnemyChara3Ex : Enemy
    {
        private static string[] charaData = { "      (・8・*)", "炎炎炎炎>(◇´*)", "(。ωﾟ∩)", "ｶﾈｶﾈｶﾈｶﾈ" };

        public EnemyChara3Ex() : base(charaData, 900, 370, new Size(100,20), new Vector(-4,0), new CharacterStatus(50,20, Brushes.DarkRed, false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara3Ex();
        }
    }

    public class EnemyChara4 : Enemy
    {
        private static string[] charaData = { "      (@・ω・ @)", "￥￥￥￥٩(๑`ȏ´๑)۶", "(。ωﾟ∩)", "ｶﾈｶﾈｶﾈｶﾈ" };

        public EnemyChara4() : base(charaData, 900, 370, new Size(100,20), new Vector(-4,0), new CharacterStatus(55,15, Brushes.Orange, false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara4();
        }
    }

    public class EnemyChara4Ex : Enemy
    {
        private static string[] charaData = { "      (@・ω・ @)", "￥￥￥￥٩(๑`ȏ´๑)۶", "(。ωﾟ∩)", "ｶﾈｶﾈｶﾈｶﾈ" };

        public EnemyChara4Ex() : base(charaData, 900, 370, new Size(100,20), new Vector(-4,0), new CharacterStatus(65,18, Brushes.Orange, false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara4Ex();
        }
    }

    public class EnemyChara5 : Enemy
    {
        private static string[] charaData = { "      ┗(⌒)(╬´ﾟДﾟ` ╬)(⌒)┛", "○ ≡（⌒)（ﾟДﾟ╬）=○", "(。ωﾟ∩)", "ｼｬｱｱｱｧｧｧｧ" };
        private static Size charaSize = new Size(140, 20);

        public EnemyChara5() : base(charaData, 900, 370, charaSize, new Vector(-4,0), new CharacterStatus(35,20, Brushes.Chocolate, false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara5();
        }
    }

    public class EnemyChara5Ex : Enemy
    {
        private static string[] charaData = { "      ┗(⌒)(╬´ﾟДﾟ` ╬)(⌒)┛", "○ ≡（⌒)（ﾟДﾟ╬）=○", "(。ωﾟ∩)", "ｼｬｱｱｱｧｧｧｧ" };
        private static Size charaSize = new Size(140, 20);

        public EnemyChara5Ex() : base(charaData, 900, 370, charaSize, new Vector(-4,0), new CharacterStatus(50,20, Brushes.Chocolate, false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara5Ex();
        }
    }

    public class EnemyChara6 : Enemy
    {
        private static string[] charaData = {"      ┗(⌒)(╬´◓ω◔` ╬)(⌒)┛", "○ ≡（⌒)（◓Д◓╬）=○", "(。ωﾟ∩)", "ﾄﾞｰｰｰﾝ"};
        private static Size charaSize = new Size(140, 12);

        public EnemyChara6() : base(charaData, 900, 370, charaSize, new Vector(-2,0), new CharacterStatus(30,25,Brushes.BurlyWood, false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara6();
        }
    }

    public class EnemyChara6Ex : Enemy
    {
        private static string[] charaData = {"      ┗(⌒)(╬´◓ω◔` ╬)(⌒)┛", "○ ≡（⌒)（◓Д◓╬）=○", "(。ωﾟ∩)", "ﾄﾞｰｰｰﾝ"};
        private static Size charaSize = new Size(140, 12);

        public EnemyChara6Ex() : base(charaData, 900, 370, charaSize, new Vector(-2,0), new CharacterStatus(40,30,Brushes.BurlyWood, false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara6Ex();
        }
    }

    public class EnemyChara7 : Enemy
    {
        private static string[] charaData = {"      ┏(◞≼థ≽◟◞౪◟◞≼థ≽◟┓)┓", "┏(◞≼థ≽◟◞Д◟◞≼థ≽◟┓)┓三", "(。ωﾟ∩)", "ｼｬｱｱｱｧｧｧｧ"};
        private static Size charaSize = new Size(140, 20);

        public EnemyChara7() : base(charaData, 900, 370, charaSize, new Vector(-4,0), new CharacterStatus(60,15, Brushes.Purple, false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara7();
        }
    }

    public class EnemyChara7Ex : Enemy
    {
        private static string[] charaData = {"      ┏(◞≼థ≽◟◞౪◟◞≼థ≽◟┓)┓", "┏(◞≼థ≽◟◞Д◟◞≼థ≽◟┓)┓三", "(。ωﾟ∩)", "ｼｬｱｱｱｧｧｧｧ"};
        private static Size charaSize = new Size(140, 20);

        public EnemyChara7Ex() : base(charaData, 900, 370, charaSize, new Vector(-4,0), new CharacterStatus(70,18, Brushes.Purple, false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara7Ex();
        }
    }

    public class EnemyChara8 : Enemy
    {
        private static string[] charaData = { "      Щ(◣д◢)艸", "((◣囲◢╬))y━･~", "(。ωﾟ∩)", "ｶﾈｶﾈｶﾈｶﾈ" };

        public EnemyChara8() : base(charaData, 900, 370, new Size(100,20), new Vector(-4,0), new CharacterStatus(55,18, Brushes.BlueViolet, false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara8();
        }
    }

    public class EnemyChara8Ex : Enemy
    {
        private static string[] charaData = { "      Щ(◣д◢)艸", "((◣囲◢╬))y━･~", "(。ωﾟ∩)", "ｶﾈｶﾈｶﾈｶﾈ" };

        public EnemyChara8Ex() : base(charaData, 900, 370, new Size(100,20), new Vector(-4,0), new CharacterStatus(65,23, Brushes.BlueViolet, false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara8Ex();
        }
    }

    public class EnemyChara9 : Enemy
    {
       
        private static string s =
            " ←三\n" +
            "←←三(◣д◢)β\n" +
            " ←三";
        private static string[] charaData = { "      †_(◣д◢)β", s, "(。ωﾟ∩)", "ｶﾈｶﾈｶﾈｶﾈ" };
        public EnemyChara9() : base(charaData, 900, 370, new Size(100,20), new Vector(-4,0), new CharacterStatus(65,20, Brushes.DarkCyan, false))
        {
            
        }

        public override Enemy Refresh()
        {
            return new EnemyChara9();
        }
    }

    public class EnemyChara9Ex : Enemy
    {
       
        private static string s =
            " ←三\n" +
            "←←三(◣д◢)β\n" +
            " ←三";
        private static string[] charaData = { "      †_(◣д◢)β", s, "(。ωﾟ∩)", "ｶﾈｶﾈｶﾈｶﾈ" };
        public EnemyChara9Ex() : base(charaData, 900, 370, new Size(100,20), new Vector(-4,0), new CharacterStatus(80,25, Brushes.DarkCyan, false))
        {
            
        }

        public override Enemy Refresh()
        {
            return new EnemyChara9Ex();
        }
    }

    public class EnemyChara10 : Enemy
    {
        private static string s = 
　　　　　　　　"     /)　/) \n"+
　　　　　　　"    .,/ノ,/ ﾉ_,,.-/)-.., \n"+
　　　　　   　"  /・　 ・　 フ,.　　　｀~`'ヽ、 \n"+
　          　"   (　　　_,,.ノ　>＿_(_　)　 ) \n"+
　　　　　　　　"   ￣￣　^^^　　 ^^^ノ ノ ";
        
        private static string ss = 
　　　　　　　　 "/)　/) \n"+
　　　　　　　".,/ノ,/ ﾉ_,,.-/)-.., \n"+
　　　　　   　"/`　 ´　 フ,.　　　｀~`'ヽ、 \n"+
　          　"(　　　_,,.ノ　>＿_(_　)　 ) \n"+
　　　　　　　"^^^^^^　^^^　　 ^^^ノ ノ ";
        private static string[] charaData = {s, ss, "(。ωﾟ∩)", "しゅっしゅ"};
        private static Size charaSize = new Size(48, 12);

        public EnemyChara10() : base(charaData, 900, 370, charaSize, new Vector(-1,0),new CharacterStatus(100,30,Brushes.DarkGreen,false))
        {

        }

        public override Enemy Refresh()
        {
            return new EnemyChara10();
        }
    }
}