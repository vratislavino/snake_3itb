using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Food : Square
    {
        public Food(int size, int x, int y, Color c) : base(size, x, y, c)
        {
        }

        public override void Draw(Graphics g)
        {
            g.FillEllipse(color, X * size, Y * size, size, size);
            g.DrawEllipse(Pens.Black, X * size, Y * size, size, size);
        }
    }
}
