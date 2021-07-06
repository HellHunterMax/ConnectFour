using ConnectFour.Models;

namespace ConnectFour.Service
{
    public interface IBoardService
    {
        void DropChecker(Board board, Checker checker, int collumn);
    }
}
