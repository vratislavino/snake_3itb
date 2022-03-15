using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {
        List<SnakePart> parts;
        int initSize = 7;

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

        public bool Died(int width, int height)
        {
            SnakePart head = parts.First();
            int size = head.Size;

            Point headPos = new Point(head.X, head.Y);
            // test smrti kvůli nárazu do zdi
            if(headPos.X < 0 || 
                headPos.Y < 0 ||
                headPos.X + size > width || 
                headPos.Y + size > height) 
                return true;

            // test smrti kvůli kousnutí
            if (parts.Exists(part => part.X == head.X && part.Y == head.Y && part != head))
                return true;
            
            return false;
        }

        public bool Contains(int x, int y)
        {
            return parts.Exists(part => part.X == x && part.Y == y);
        }

        public bool CollidedWithFood(Food food)
        {
            return parts.First().X == food.X && parts.First().Y == food.Y;
        }
    }
}
