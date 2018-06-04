using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moon_Rover.Core.Model;

namespace Moon_Rover_Direction.test
{
    [TestClass]
    public class RoverMovementAfterGivingCommandsTest
    {
        [TestMethod]
        public void Rover_Should_Move_Properly_After_Giving_Commands()
        {
            Map map = new Map(10, 10);
            Coordinate coordinate = new Coordinate(5, 5);
            Rover rover = new Rover(new North(), coordinate, map);
            Command command = new Command();

        }
    }
}
