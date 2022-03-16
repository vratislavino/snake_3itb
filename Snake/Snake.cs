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
        int initSize = 3;
        

        Color snakeColor;

        public int Score => parts.Count - initSize;

        public Snake(int size, int x, int y, Color color)
        {
            parts = new List<SnakePart>();
            snakeColor = color;

            for(int i = 0; i < initSize; i++)
            {
                parts.Add(new SnakePart(size, x - (i+1), y, color));
            }
        }

        public void FoodEaten()
        {
            SnakePart last = parts.Last();
            var dir = last.Direction.GetDirection();
            
            SnakePart sp = new SnakePart(last.Size, last.X + dir.Item1, last.Y + dir.Item2, Color.Red);
            sp.InitDirection(last.Direction);
            parts.Add(sp);
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

            Point headPos = new Point(head.RealX, head.RealY);
            // test smrti kvůli nárazu do zdi
            if(headPos.X < 0 || 
                headPos.Y < 0 ||
                headPos.X + size > width || 
                headPos.Y + size > height) 
                return true;

            // test smrti kvůli kousnutí
            if (parts.Exists(part => part.RealX == head.RealX && part.RealY == head.RealY && part != head))
                return true;
            
            return false;
        }

        public bool Contains(int x, int y)
        {
            return parts.Exists(part => part.X == x && part.Y == y);
        }

        public bool CollidedWithFood(Food food)
        {
            return parts.First().RealX == food.RealX && parts.First().RealY == food.RealY;
        }
    }
}
