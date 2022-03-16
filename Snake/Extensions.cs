using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public static class Extensions
    {
        public static bool IsOpposite(this Direction dir, Direction dir2)
        {
            return (dir == Direction.Up && dir2 == Direction.Down)
                || (dir == Direction.Down && dir2 == Direction.Up)
                || (dir == Direction.Left && dir2 == Direction.Right)
                || (dir == Direction.Right && dir2 == Direction.Left);
        }

        public static (int, int) GetDirection(this Direction dir)
        {
            if (dir == Direction.Up)
                return (0, 1);

            if (dir == Direction.Left)
                return (1, 0);

            if (dir == Direction.Right)
                return (-1, 0);

            if (dir == Direction.Down)
                return (0, -1);

            return (0, 0);
        }
    }
}
