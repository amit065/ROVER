using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Rover.Core.Model
{
    public class Coordinate
    {
        public int XCoordinate { get; set; }

        public int YCoordinate { get; set; }

        public Coordinate(int x, int y)
        {
            XCoordinate = x;

            YCoordinate = y;
        }
    }
}
