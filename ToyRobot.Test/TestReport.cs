using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot.App;

namespace ToyRobot.Test
{
    [TestClass]
    public class TestReport
    {
        [TestMethod]
        public void ReportLocation()
        {
            App.ToyRobot robot = new App.ToyRobot
            {
                direction = "north",
                east = 4,
                north = 3
            };

            string expected = "4,3,NORTH";

            string position = robot.Report();
            
            Assert.AreEqual(expected, position);
        }
    }
}
