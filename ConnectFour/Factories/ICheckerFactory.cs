using ConnectFour.Models;

namespace ConnectFour.Factories
{
    public interface ICheckerFactory
    {
        Checker Create(Board board);
    }
}
