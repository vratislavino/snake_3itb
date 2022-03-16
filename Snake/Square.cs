using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public abstract class Square
    {
        protected int size;
        public int Size => size;

        protected SolidBrush color;
        protected int x;
        public int RealX => x * size;

        protected int y;
        public int RealY => y * size;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Square(int size, int x, int y, Color c)
        {
            this.size = size;
            this.x = x;
            this.y = y;
            this.color = new SolidBrush(c);
        }

        public abstract void Draw(Graphics g);
    }
}
