using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using ImagingSolution.Drawing;

namespace 顔文字大戦争
{
    public class ScreenPictureBox : PictureBox
    {
        private Bitmap BackImage;
        public Money money = new Money();
        private DoubleBuffer myDoubleBuffer;
        public List<ICharacter> playerList = new List<ICharacter>(); //自軍描画用リスト
        public List<ICharacter> enemyList = new List<ICharacter>();　//敵軍描画用リスト
        public List<ICharacter> structureList = new List<ICharacter>();　//タワー描画用リスト

        public ScreenPictureBox()
        {
            this.DoubleBuffered = true;
        }
        public void init()
        {
            myDoubleBuffer = new DoubleBuffer(this);
            BackImage = new Bitmap(@"media/graphic/field.png");
        }
        public void draw()
        {
            Graphics g = myDoubleBuffer.Graphics;
            g.Clear(this.BackColor);
            g.DrawImage(BackImage, 0, 0);
            foreach(var p in playerList){
                p.animation(this);
                p.draw(g);
            }
            foreach(var e in enemyList){
                e.draw(g);
                e.animation(this);
            }
            foreach(var s in structureList){
                s.draw(g);
                s.animation(this);
            }
            
            money.draw(g);

            myDoubleBuffer.Refresh();
        }
    }
}
