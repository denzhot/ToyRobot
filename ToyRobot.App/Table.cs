namespace ToyRobot.App
{
    public class Table
    {
        public int width;
        public int length;
        public bool IsValidLocation(int east, int north, string direction )
        {
            bool isValid = false;
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
            if (east >= 0 && east < width && north >= 0 && north < length)
                isValid = true;
            return isValid;
        }
        public bool IsValidLocation(int east, int north)
        {
            bool isValid = false;
            if (east >= 0 && east < width && north >= 0 && north < length)
                isValid = true;
            return isValid;
        }
        public Table(int width, int length)
        {
            this.width = width;
            this.length = length;
        }
    }
}
