using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot;
using ToyRobot.App;

namespace ToyRobot.Test
{
    [TestClass]
    public class TestTurn
    {
        [TestMethod]
        public void TurnRightWhenFacingNorth()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "north" };
            robot.RotateRight();
            Assert.AreEqual("east", robot.direction);
        }

        [TestMethod]
        public void TurnLeftWhenFacingNorth()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "north" };
            robot.RotateLeft();
            Assert.AreEqual("west", robot.direction);
        }

        [TestMethod]
        public void TurnRightWhenFacingEast()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "east" };
            robot.RotateRight();
            Assert.AreEqual("south", robot.direction);
        }

        [TestMethod]
        public void EastTurnLeftWhenFacing()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "east" };
            robot.RotateLeft();
            Assert.AreEqual("north", robot.direction);
        }

        [TestMethod]
        public void TurnLeftWhenFacingSouth()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "south" };
            robot.RotateLeft();
            Assert.AreEqual("east", robot.direction);
        }

        [TestMethod]
        public void TurnRightWhenFacingWest()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "west" };
            robot.RotateRight();
            Assert.AreEqual("north", robot.direction);
        }

        [TestMethod]
        public void TurnRightWhenFacingSouth()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "south" };
            robot.RotateRight();
            Assert.AreEqual("west", robot.direction);
        }

        [TestMethod]
        public void TurnLeftWhenFacingWest()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "west" };
            robot.RotateLeft();
            Assert.AreEqual("south", robot.direction);
        }

    }
}
