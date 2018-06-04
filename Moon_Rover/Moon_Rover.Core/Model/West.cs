using Moon_Rover.Core.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Rover.Core.Model
{
    public class West : IDirection
    {
        public string direction { get { return "West"; } }

        public IDirection Left()
        {
            return new South();
        }

        public IDirection Right()
        {
            return new North();
        }
        public Coordinate Move(Coordinate coordinate)
        {
            return new Coordinate(coordinate.XCoordinate - 1, coordinate.YCoordinate);
        }
    }
}
