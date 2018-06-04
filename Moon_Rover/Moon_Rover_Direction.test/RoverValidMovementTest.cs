using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moon_Rover.Core.Model;

namespace Moon_Rover_Direction.test
{
    [TestClass]
    public class RoverValidMovementTest
    {
        [TestMethod]
        public void Map_Should_throw_error_when_boundry_crossed()
        {
            Map map = new Map(10,10);
            Coordinate coordinate = new Coordinate(10, 10);
            Rover rover = new Rover(new North(), coordinate, map);
            rover.move();
            Assert.IsFalse(map.IsValidMove(coordinate));

        }
    }
}
