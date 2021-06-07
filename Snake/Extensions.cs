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
    }
}
