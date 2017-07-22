using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ImagingSolution
{
    namespace Drawing
    {
        class DoubleBuffer : IDisposable
        {
            BufferedGraphics myBuffer;

            Control _Control;

            public DoubleBuffer(Control control)
            {
                _Control = control;

                this.Dispose();

                System.Drawing.BufferedGraphicsContext currentContext;

                currentContext = BufferedGraphicsManager.Current;

                myBuffer = currentContext.Allocate(control.CreateGraphics(),
                   control.DisplayRectangle);

                _Control.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint);

            }

            ~DoubleBuffer()
            {
                Dispose();
            }

            public void Dispose()
            {
                if (myBuffer != null)
                {
                    myBuffer.Dispose();
                    myBuffer = null;
                }
                _Control.Paint -= new System.Windows.Forms.PaintEventHandler(this.Paint);
            }

            private void Paint(object sender, PaintEventArgs e)
            {
                Refresh();
            }

            public void Refresh()
            {
                if (myBuffer != null)
                    myBuffer.Render();
            }

            public Graphics Graphics
            {
                get { return myBuffer.Graphics; }
            }
        }
    }
}
