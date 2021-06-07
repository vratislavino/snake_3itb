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

        private Direction currentDirection = Direction.Right;
        private Direction newDirection = Direction.Right;

        public Direction Direction => newDirection;

        public SnakePart(int size, int x, int y, Color c)
        {
            this.size = size;
            this.x = x;
            this.y = y;
            this.color = new SolidBrush(c);
        }

        public void Move()
        {
            if (currentDirection == Direction.Right)
                x += 1;
            if (currentDirection == Direction.Left)
                x -= 1;
            if (currentDirection == Direction.Up)
                y -= 1;
            if (currentDirection == Direction.Down)
                y += 1;
        }

        public void ChangeDirection(Direction newDir)
        {
            if(!newDir.IsOpposite(currentDirection))
            {
                newDirection = newDir;
            }
        }

        public void UpdateDirection()
        {
            currentDirection = newDirection;
        }

        public void Draw(Graphics g) {
            g.FillRectangle(color, x * size, y * size, size, size);
            g.DrawRectangle(Pens.Black, x * size, y * size, size, size);
        }
    }
}
