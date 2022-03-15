﻿using System;
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
        public int X => x * size;

        protected int y;
        public int Y => y * size;

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
