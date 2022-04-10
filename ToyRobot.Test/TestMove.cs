using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot.App;

namespace ToyRobot.Test
{
    [TestClass]
    public class TestMove
    {
        [TestMethod]
        public void MoveTwoTimesEast()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "east" };
            robot.Move();
            robot.Move();
            Assert.AreEqual(2, robot.east);
        }

        [TestMethod]
        public void MoveThreeTimesEast()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "east"};
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(3, robot.east);
        }

        [TestMethod]
        public void MoveFourTimesEast()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "east"};
            robot.Move();
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(4, robot.east);
        }

        [TestMethod]
        public void MoveTwoTimesWest()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "west" };
            robot.Move();
            robot.Move();
            Assert.AreEqual(-2, robot.east);
        }

        [TestMethod]
        public void MoveThreeTimesWest()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "west"};
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(-3, robot.east);
        }

        [TestMethod]
        public void MoveFourTimesWest()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "west" };
            robot.Move();
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(-4, robot.east);
        }

        [TestMethod]
        public void MoveTwoTimesNorth()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "north" };
            robot.Move();
            robot.Move();
            Assert.AreEqual(2, robot.north);
        }

        [TestMethod]
        public void MoveThreeTimesNorth()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "north" };
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(3, robot.north);
        }

        [TestMethod]
        public void MoveFourTimesNorth()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "north" };
            robot.Move();
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(4, robot.north);
        }

        [TestMethod]
        public void MoveTwoTimesSouth()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "south" };
            robot.Move();
            robot.Move();
            Assert.AreEqual(-2, robot.north);
        }

        [TestMethod]
        public void MoveThreeTimesSouth()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "south" };
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(-3, robot.north);
        }

        [TestMethod]
        public void MoveFourTimesSouth()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "south" };
            robot.Move();
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(-4, robot.north);
        }

        [TestMethod]
        public void TurnLeftWhenFacingNorth()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "north"};
            robot.RotateLeft();
            Assert.AreEqual("west", robot.direction);
        }

        [TestMethod]
        public void TurnRightWhenFacingNorth()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "north" };
            robot.RotateRight();
            Assert.AreEqual("east", robot.direction);
        }

        [TestMethod]
        public void TurnLeftWhenFacingEast()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "east" };
            robot.RotateLeft();
            Assert.AreEqual("north", robot.direction);
        }

        [TestMethod]
        public void TurnRightWhenFacingEast()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "east" };
            robot.RotateRight();
            Assert.AreEqual("south", robot.direction);
        }

        [TestMethod]
        public void TurnLeftWhenFacingSouth()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "south" };
            robot.RotateLeft();
            Assert.AreEqual("east", robot.direction);
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

        [TestMethod]
        public void TurnRightWhenFacingWest()
        {
            App.ToyRobot robot = new App.ToyRobot { direction = "west" };
            robot.RotateRight();
            Assert.AreEqual("north", robot.direction);
        }
    }
}
