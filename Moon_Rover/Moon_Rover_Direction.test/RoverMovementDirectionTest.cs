using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moon_Rover.Core.Model;
using Moon_Rover.Core.Contract;

namespace Moon_Rover_Direction.test
{
    [TestClass]
    public class RoverMovementDirectionTest
    {
        [TestMethod]
        public void Rover_Should_Move_Properly_While_Facing_North()
        {
            Map map = new Map(10, 10);
            Coordinate coordinate = new Coordinate(4, 5);
            Rover rover = new Rover(new North(), coordinate, map);
            rover.move();
            Assert.AreEqual(6, rover.CurrentCoordinate.YCoordinate);

            IDirection direction = new North();
            Assert.AreEqual("East", direction.Right().direction);
            Assert.AreEqual("West", direction.Left().direction);
        }

        [TestMethod]
        public void Rover_Should_Move_Properly_While_Facing_South()
        {
            Map map = new Map(10, 10);
            Coordinate coordinate = new Coordinate(5, 5);
            Rover rover = new Rover(new South(), coordinate, map);
            rover.move();
            Assert.AreEqual(4, rover.CurrentCoordinate.YCoordinate);

            IDirection direction = new South();
            Assert.AreEqual("West", direction.Right().direction);
            Assert.AreEqual("East", direction.Left().direction);
        }

        [TestMethod]
        public void Rover_Should_Move_Properly_While_Facing_East()
        {
            Map map = new Map(10, 10);
            Coordinate coordinate = new Coordinate(4, 4);
            Rover rover = new Rover(new East(), coordinate, map);
            rover.move();
            Assert.AreEqual(5, rover.CurrentCoordinate.XCoordinate);

            IDirection direction = new East();
            Assert.AreEqual("South", direction.Right().direction);
            Assert.AreEqual("North", direction.Left().direction);
        }

        [TestMethod]
        public void Rover_Should_Move_Properly_While_Facing_West()
        {
            Map map = new Map(10, 10);
            Coordinate coordinate = new Coordinate(8, 8);
            Rover rover = new Rover(new West(), coordinate, map);
            rover.move();
            Assert.AreEqual(7, rover.CurrentCoordinate.XCoordinate);

            IDirection direction = new West();
            Assert.AreEqual("North", direction.Right().direction);
            Assert.AreEqual("South", direction.Left().direction);
        }
    }
}
