namespace ToyRobot.App
{
    public class MovementSimulator
    {
        public ToyRobot robot;
        public Table Table;

        public MovementSimulator(Table _table)
        {
            Table = _table;
        }

        public void Place(int east, int north, string direction)
        {
            if (Table.IsValidLocation(east, north))
            {
                robot = new ToyRobot
                {
                    direction = direction.ToLower(),
                    east = east,
                    north = north
                };
            }
        }

        public void Move(string movement)
        {
            switch (movement)
            {
                case "move":
                    if (Table.IsValidLocation(robot.east , robot.north, robot.direction ))
                    {
                        robot.Move();
                    }
                    break;
                case "right":
                    robot.RotateRight();
                    break;
                case "left":
                    robot.RotateLeft();
                    break;
            }
        }
        
        public string Report()
        {
            return robot.Report();
        }
    }
}
