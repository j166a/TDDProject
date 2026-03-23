using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class Compass
    {
        public Point Point;

        public Point Rotate(Point point, Direction direction)
        {
            switch (point)
            {
                case Point.WEST:
                    return Point.NORTH;
                case Point.NORTH:
                    return Point.EAST;
                case Point.EAST:
                    return Point.SOUTH;
                case Point.SOUTH:
                    return Point.WEST;
                default:
                    throw new ArgumentException("Invalid point");
            }
        }
     }
}
