using System;
using System.Text.RegularExpressions;

namespace ToyRobot.App
{
    public class RoboCommand
    {
        public Table Table = new Table(5, 5);//hard coded this since the instruction says it is always 5x5
        public MovementSimulator movementSimulation;
        
        public bool IsOnTableTop;
        public string _message = string.Empty;
        public string _invalidInputText = "The inputs are not correct";

        public string ProcessNow(string[] commands)
        {
            movementSimulation = new MovementSimulator(Table);
            foreach (string command in commands)
            {
                if (IsOnTableTop)
                {
                    ProcessCommand(command);
                }
                else if (Regex.IsMatch(command, "[PLACE]"))
                {
                    IsOnTableTop = true;
                    ProcessCommand(command);
                }
                if (_message == _invalidInputText)
                {
                    break;
                }
                if (_message.Length > 1)
                {
                    Console.WriteLine(_message);
                    _message = "";
                }
            }
            return _message;
        }

        public void ProcessCommand(string command)
        {
            if (Regex.IsMatch(command, "^PLACE"))
            {
                string[] locationCoordinates = command.Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
                if (locationCoordinates.Length == 4)
                {
                    int east;
                    int north;
                    bool eastTest = Int32.TryParse(locationCoordinates[1], out east);
                    bool northTest = Int32.TryParse(locationCoordinates[2], out north);
                    if (eastTest && northTest)
                    {
                        movementSimulation.Place(east, north, locationCoordinates[3]);
                    }
                }
                if (movementSimulation.robot == null)
                {
                    _message = _invalidInputText;
                }
            }
            else if (Regex.IsMatch(command, "^MOVE") || Regex.IsMatch(command, "^RIGHT") || Regex.IsMatch(command, "^LEFT"))
            {
                movementSimulation.Move(command.ToLower());
            }
            else if (Regex.IsMatch(command, "^REPORT"))
            {
                _message = movementSimulation.Report();
            }
            else
            {
                _message = _invalidInputText;
            }
        }
    }
}
