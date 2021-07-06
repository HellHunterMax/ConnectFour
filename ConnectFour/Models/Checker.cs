namespace ConnectFour.Models
{
    public enum CheckerColor
    {
        White,
        Black
    }
    public class Checker
    {
        public CheckerColor Color { get; init; }

        public Checker()
        {

        }
        public Checker(CheckerColor color)
        {
            Color = color;
        }
    }
}
