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
    public partial class Title : UserControl
    {
        private MainForm fm;
        public Title(MainForm fm)
        {
            InitializeComponent();
            this.fm = fm;
        }

        private void Title_Click(object sender, EventArgs e)
        {
            fm.nextScene(new Menu(fm));
        }
    }
}