using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_12
{
    class CRectangle : CFigure
    {
        private int _Side;

        public int Side
        {
            get
            {
                return _Side;
            }
            set
            {
                _Side = value >= 200 ? 200 : value;
                _Side = value <= 5 ? 5 : value;
            }
        }

        public CRectangle(Graphics graphics, int X, int Y, int Side, 
            int SideB)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Side = Side;
        }

        protected override void Draw(Pen pen)
        {
            Rectangle rectangle = new Rectangle(X - Side / 2,  Y - Side / 2, Side, Side);
            graphics.DrawRectangle(pen, rectangle);
        }

        override public void Expand(int dX)
        {
            Hide();
            Side = Side + dX;
            Show();
        }

        override public void Collapse(int dX)
        {
            Hide();
            Side = Side - dX;
            Show();
        }

    }
}
