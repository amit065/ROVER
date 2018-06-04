using Moon_Rover.Core.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Rover.Core.Model
{
    public class North : IDirection
    {
        public string direction { get { return "North"; } }

        public IDirection Left()
        {
            return new West();
        }

        public IDirection Right()
        {
            return new East();
        }
        public Coordinate Move(Coordinate coordinate)
        {

            return new Coordinate(coordinate.XCoordinate, coordinate.YCoordinate + 1);
        }
    }
}
