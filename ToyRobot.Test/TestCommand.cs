using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot.App;

namespace ToyRobot.Test
{
    [TestClass]
    public class TestCommand
    {
        [TestMethod]
        public void PlaceCommand()
        {
            RoboCommand command = new RoboCommand();
            Table table = new Table(5,5);
            command.movementSimulation = new MovementSimulator(table);
            command.ProcessCommand("PLACE 3,2,WEST");

            Assert.IsNotNull(command.movementSimulation.robot);
        }

        [TestMethod]
        public void InvalidPlaceCommand()
        {
            RoboCommand command = new RoboCommand();
            Table table = new Table(5, 5);
            command.movementSimulation = new MovementSimulator(table);
            command.ProcessCommand("PLACE 6,3,NORTH");

            Assert.AreSame(command._invalidInputText, command._message);
        }

        [TestMethod]
        public void MoveCommand()
        {
            RoboCommand command = new RoboCommand();
            Table table = new Table(5, 5);
            command.movementSimulation = new MovementSimulator(table);
            command.ProcessCommand("PLACE 2,3,EAST");
            command.ProcessCommand("MOVE");

            App.ToyRobot expected = new App.ToyRobot { east = 3, north = 3, direction = "east"};

            Assert.AreEqual(expected.east, command.movementSimulation.robot.east);
        }

        [TestMethod]
        public void MoveWallCommand()
        {
            RoboCommand command = new RoboCommand();
            Table table = new Table(5, 5);
            command.movementSimulation = new MovementSimulator(table);
            command.ProcessCommand("PLACE 4,4,EAST");
            command.ProcessCommand("MOVE");

            App.ToyRobot expected = new App.ToyRobot { east = 4, north = 4, direction = "east" };

            Assert.AreEqual(expected.east, command.movementSimulation.robot.east);
        }

        [TestMethod]
        public void LeftCommand()
        {
            RoboCommand command = new RoboCommand();
            Table table = new Table(5, 5);
            command.movementSimulation = new MovementSimulator(table);
            command.ProcessCommand("PLACE 2,3,EAST");
            command.ProcessCommand("LEFT");

            App.ToyRobot expected = new App.ToyRobot { east = 2, north = 3, direction = "north" };

            Assert.AreEqual(expected.direction, command.movementSimulation.robot.direction);
        }

        [TestMethod]
        public void RightCommand()
        {
            RoboCommand command = new RoboCommand();
            Table table = new Table(5, 5);
            command.movementSimulation = new MovementSimulator(table);
            command.ProcessCommand("PLACE 2,3,EAST");
            command.ProcessCommand("RIGHT");

            App.ToyRobot expected = new App.ToyRobot { east = 2, north = 3, direction = "south" };

            Assert.AreEqual(expected.direction, command.movementSimulation.robot.direction);
        }

 
        [TestMethod]
        public void ReportCommand()
        {
            RoboCommand command = new RoboCommand();
            Table table = new Table(5, 5);
            command.movementSimulation = new MovementSimulator(table);
            command.ProcessCommand("PLACE 3,3,EAST");
            command.ProcessCommand("REPORT");

            string expected = "3,3,EAST";

            Assert.AreEqual(expected, command._message);
        }

        [TestMethod]
        public void InvalidCommand()
        {
            RoboCommand command = new RoboCommand();
            Table table = new Table(5, 5);
            command.movementSimulation = new MovementSimulator(table);
            command.ProcessCommand("TESTING");

            string expected = command._invalidInputText;

            Assert.AreEqual(expected, command._message);
        }
    }
}
