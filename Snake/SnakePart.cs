using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class SnakePart
    {
        private int size;
        private SolidBrush color;
        private int x;
        private int y;

        public SnakePart(int size, int x, int y, Color c)
        {
            this.size = size;
            this.x = x;
            this.y = y;
            this.color = new SolidBrush(c);
        }

        public void Draw(Graphics g) {
            g.FillRectangle(color, x * size, y * size, size, size);
            g.DrawRectangle(Pens.Black, x * size, y * size, size, size);
        }
    }
}
