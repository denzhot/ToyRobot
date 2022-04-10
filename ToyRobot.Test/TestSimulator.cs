using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot.App;

namespace ToyRobot.Test
{
    [TestClass]
    public class TestSimulator
    {
        [TestMethod]
        public void PlaceRobotValidLocation()
        {
            Table tableTop = new Table(4, 4);
            MovementSimulator instance = new MovementSimulator(tableTop);
            instance.Place(0, 0, "EAST");

            App.ToyRobot validrobotInstance = new App.ToyRobot
            {
                east = 0,
                north = 0,
                direction = "east",
            };

            Assert.AreEqual(validrobotInstance.east, instance.robot.east);
            Assert.AreEqual(validrobotInstance.north, instance.robot.north);
            Assert.AreEqual(validrobotInstance.direction, instance.robot.direction);
        }

        [TestMethod]
        public void PlaceRobotNotValidLocation()
        {
            Table tableTop = new Table(4, 4);
            MovementSimulator instance = new MovementSimulator(tableTop);
            instance.Place(5, 5, "WEST");
            
            Assert.IsNull(instance.robot);
        }
    }
}
