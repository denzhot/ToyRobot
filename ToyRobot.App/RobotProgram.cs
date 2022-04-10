using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ToyRobot.App
{
    class RobotProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Would you like to process from text file? (Y/N)");
            char keyValue =  ' ';
            for(; ; )//this will wait until Y or N was pressed.
            {
                ConsoleKeyInfo keypressed = Console.ReadKey(true);
                if (keypressed.KeyChar == 'Y' || keypressed.KeyChar == 'y' || keypressed.KeyChar == 'N' || keypressed.KeyChar == 'n')
                {
                    keyValue = keypressed.KeyChar;
                    Console.WriteLine(keyValue);
                    break;
                }
            }

            List<string> commandList = new List<string>();
            if (keyValue == 'y' || keyValue == 'Y')
            {
                Console.Write("Please enter filepath and filename: ");
                string fielname = Console.ReadLine();
                if (File.Exists(fielname) && (Path.GetExtension(fielname) == ".txt"))
                {
                    commandList = File.ReadAllLines(fielname).ToList();
                }
                else
                {
                    Console.WriteLine("Not a valid text file. Please try again.");
                    Console.Write(@"The correct command formats are as follows:
         ----------------------
         PLACE X,Y,DIRECTION  --- x and y should be 0-4 and direction should be NORTH, SOUTH, EAST or WEST 
         MOVE
         LEFT
         RIGHT
         REPORT -- This will terminate the simulation
         ---------------------
         Kindly check your file and try again.");
                    Console.WriteLine("\n\rpress any key to exit.");
                    Console.ReadKey(true);
                    return;
                }
            }
            else if (keyValue == 'n' || keyValue == 'N')
            {
                Console.Write("\n\r Please input series of command \r\n");
                string inputCommand = "";
                do
                {
                    inputCommand = Console.ReadLine();
                    commandList.Add(inputCommand);
                }
                while (inputCommand != "REPORT");
            }
            string[] commands = commandList.ToArray();
            RobotProgram robotProgram = new RobotProgram();
            Console.WriteLine(robotProgram.ExecuteCommand(commands));
            Console.WriteLine("\n\rpress any key to exit.");
            Console.ReadKey(true);

        }
        public string ExecuteCommand(string[] commands)
        {
            string _message = "";
            RoboCommand roboCommand = new RoboCommand();
            if (roboCommand != null)
            {
                _message = roboCommand.ProcessNow(commands);
            }
            return _message;
        }
    }
}
