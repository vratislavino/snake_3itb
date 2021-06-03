using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        List<SnakePart> parts;
        int initSize = 3;

        Color snakeColor;

        public Snake(int size, int x, int y, Color color)
        {
            parts = new List<SnakePart>();
            snakeColor = color;

            for(int i = 0; i < initSize; i++)
            {
                parts.Add(new SnakePart(size, x, y, color));
            }
        }

        public void Draw(Graphics g)
        {
            parts.ForEach(part => part.Draw(g));
        }
    }
}
