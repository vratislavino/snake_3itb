using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class SnakePart : Square
    {
        private Direction currentDirection = Direction.Right;
        private Direction newDirection = Direction.Right;

        public SnakePart(int size, int x, int y, Color c) : base(size, x, y, c)
        {
        }

        public Direction Direction => newDirection;

        public void InitDirection(Direction d)
        {
            currentDirection = d;
            newDirection = d;
        }

        public void Move()
        {
            if (newDirection == Direction.Right)
                x += 1;
            if (newDirection == Direction.Left)
                x -= 1;
            if (newDirection == Direction.Up)
                y -= 1;
            if (newDirection == Direction.Down)
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

        public override void Draw(Graphics g) {
            g.FillRectangle(color, X * size, Y * size, size, size);
            g.DrawRectangle(Pens.Black, X * size, Y * size, size, size);
        }
    }
}
