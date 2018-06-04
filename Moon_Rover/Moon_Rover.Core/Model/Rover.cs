using Moon_Rover.Core.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Rover.Core.Model
{
    public class Rover
    {
        public IDirection Direction { get; set; }
        public Coordinate CurrentCoordinate;
        private Map _map;

        public Rover()
        {

        }
        public void TurnLeft()
        {
            Direction = Direction.Left();
        }
        public void TurnRight()
        {
            Direction = Direction.Right();
        }
        public void move()
        {
            var move = Direction.Move(CurrentCoordinate);
            if (_map.IsValidMove(move))
            {
                CurrentCoordinate = Direction.Move(CurrentCoordinate);
            }
        }
        public Rover(IDirection direction, Coordinate current, Map map)
        {
            Direction = direction;
            CurrentCoordinate = current;
            _map = map;
        }
    }
}
