using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 顔文字大戦争
{
    public abstract class  Structure : ICharacter
    {
        private Font font = new Font("MS UI Gothic", 10,FontStyle.Bold);

        private string charadata = "";
        private Point point;
        private Vector vec = new Vector(0, 0);
        private Size size;
        public CharacterStatus charaState;
        private int MAX_HP;
        public Structure(string charaData, int x, int y, Size charaSize, CharacterStatus charaState)
        {
            point = new Point(x,y);
            size = charaSize;
            this.charaState = charaState;
            this.charadata = charaData;
            MAX_HP = charaState.HP;
        }
        public void draw(Graphics g)
        {
            g.DrawString(charadata, font, Brushes.Black, point.X, point.Y);
            g.DrawString(this.charaState.HP.ToString() + "/" + MAX_HP.ToString(), font, Brushes.Black, point.X+15, point.Y - 10);
        }

        public void animation(ScreenPictureBox screen)
        {
            if (this.charaState.HP <= 0) this.charaState.HP = 0;
        }

        public bool isDead()
        {
            if(this.charaState.HP <= 0){
                return true;
            }else{
                return false;
            }
        }

        public void Damege(int damege)
        {
            this.charaState.HP -= damege;
        }
        public Rectangle getMyRect()
        {
            return new Rectangle(this.point, this.size);
        }
    }

    public class Structure1 : Structure
    {
        private static string s = 
　　　　"       |＞\n"+
　　    "　　 ,i|i,\n"+
　　    "　　,i:: i,\n"+
　      "　 ,i: : : :i,\n"+
　      "　,i: : : : :.i,\n"+
　      "　{i,i_i,_i_i,i}\n";

        private static string tower =
        "　 ＿＿＿___  \n"+
        "_ lｴｴｴｴｴｴ, i_ \n"+
        "| ﾛ| ﾛ | ﾛ | ﾛ|\n"+
        "| .|  .|  .| .|\n"+
        "|.=========  .|\n"+
        "| ﾛ| ﾛ | ﾛ | ﾛ|\n"+
        "| .|  .|  .| .|\n"+
        "|.=========  .|\n"+
        "| ﾛ| ﾛ | ﾛ | ﾛ|\n"+
        "| .|  .|  .  .|\n"+
        "|.=========.  |\n"+
        "| ﾛ| ﾛ | ﾛ | ﾛ|\n"+
        "| .|　.|　.| .|\n"+
        "|.===■====  .|";
        public Structure1(int x, int y, bool isPlayer, int HP) : base(tower, x, y, new Size(100,1000), new CharacterStatus(HP, 0, Brushes.Black,isPlayer))
        {}
    }
}
