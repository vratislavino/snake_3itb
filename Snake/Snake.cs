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
                parts.Add(new SnakePart(size, x - (i+1), y, color));
            }
        }

        public void Move()
        {
            parts.ForEach(x => x.Move());
        }

        // pokaždé, když se zmáčkne klávesa
        public void ChangeDirection(Direction dir)
        {
            parts.First().ChangeDirection(dir);
        }

        // na každý tick
        public void UpdateDirections()
        {
            for(int i = parts.Count - 1; i > 0; i--)
            {
                parts[i].ChangeDirection(parts[i - 1].Direction);
            }
            parts.ForEach(x => x.UpdateDirection());
        }

        public void Draw(Graphics g)
        {
            parts.ForEach(part => part.Draw(g));
        }
    }
}
