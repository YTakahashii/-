using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 顔文字大戦争
{
    public class Money
    {
        public int maxMoney { get; set; }
        public int money{get; set;}
        private Font font = new Font("メイリオ", 16);
        private Point point = new Point(900,30);
        public Money()
        {
            money = 0;   
        }

        public void draw(Graphics g)
        {
            g.DrawString(money.ToString() + "/" + maxMoney.ToString()+"円",font,Brushes.DarkOrange, point.X ,point.Y);
        }

        public void animation()
        {
            if (money > maxMoney-1) money = maxMoney-1;
            money++;
        }

        public bool CheckCreateCharacter(int cost, bool production)
        {
            if(money < cost){
                return false;
            }else{
                if(production) money -= cost;
                return true;
            }
        }

    }
}
