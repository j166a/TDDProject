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
            if (direction == Direction.RIGHT)
            {
                return (Point)(((int)point + 1) % 4);
            }
            else if (direction == Direction.LEFT)
            {
                return (Point)(((int)point + 3) % 4);
            }
            else
            {
                throw new ArgumentException("Invalid direction");
            }
            //    {
            //        switch (point)
            //        {
            //            case Point.WEST:
            //                return Point.NORTH;
            //            case Point.NORTH:
            //                return Point.EAST;
            //            case Point.EAST:
            //                return Point.SOUTH;
            //            case Point.SOUTH:
            //                return Point.WEST;
            //            default:
            //                throw new ArgumentException("Invalid point");
            //        }
            //    }
            //    else if (direction == Direction.LEFT)
            //    {
            //        switch (point)
            //        {
            //            case Point.WEST:
            //                return Point.SOUTH;
            //            case Point.NORTH:
            //                return Point.WEST;
            //            case Point.EAST:
            //                return Point.NORTH;
            //            case Point.SOUTH:
            //                return Point.EAST;
            //            default:
            //                throw new ArgumentException("Invalid point");
            //        }
            //    }
            //    else
            //    {
            //        throw new ArgumentException("Invalid direction");
            //    }
        }
    }
}
