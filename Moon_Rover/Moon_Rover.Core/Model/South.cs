using Moon_Rover.Core.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Rover.Core.Model
{
    public class South : IDirection
    {
        public string direction { get { return "South"; } }

        public IDirection Left()
        {
            return new East();
        }
        public IDirection Right()
        {
            return new West();
        }
        public Coordinate Move(Coordinate coordinate)
        {
            return new Coordinate(coordinate.XCoordinate, coordinate.YCoordinate - 1);
        }
    }
}
