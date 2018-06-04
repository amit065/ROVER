using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Rover.Core.Model
{
    public class Map
    {
        public int MaxXCoordinate { get; set; }

        public int MaxYCoordinate { get; set; }

        public Map(int maxX, int maxY)
        {
            MaxXCoordinate = maxX;

            MaxYCoordinate = maxY;
        }
        public bool IsValidMove(Coordinate currentCoordinate)
        {
            return (currentCoordinate.XCoordinate >= 0 && currentCoordinate.XCoordinate <= MaxXCoordinate
                     && currentCoordinate.YCoordinate >= 0 && currentCoordinate.YCoordinate <= MaxYCoordinate);
        }
    }
}
