namespace ToyRobot.App
{
    public class ToyRobot
    {
        public int east = 0;
        public int north = 0;
        public string direction;

        public ToyRobot()
        {
            
        }

        public void Move()
        {
            switch (direction)
            {
                case "east":
                    east += 1;
                    break;
                case "west":
                    east -= 1;
                    break;
                case "north":
                    north += 1;
                    break;
                case "south":
                    north -= 1;
                    break;
            }
        }

        public void RotateRight()
        {
            switch (direction)
            {
                case "north":
                    direction = "east";
                    break;
                case "east":
                    direction = "south";
                    break;
                case "south":
                    direction = "west";
                    break;
                case "west":
                    direction = "north";
                    break;

            }
        }

        public void RotateLeft()
        {
            switch (direction)
            {
                case "north":
                    direction = "west";
                    break;
                case "east":
                    direction = "north";
                    break;
                case "south":
                    direction = "east";
                    break;
                case "west":
                    direction = "south";
                    break;

            }
        }


        public string Report()
        {
            return east + "," + north + "," + direction.ToUpper();
        }
    }
}
