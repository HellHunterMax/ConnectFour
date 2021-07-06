using ConnectFour.Models;

namespace ConnectFour.Service
{
    public interface IGameService
    {
        public void CheckGameEnd(Board board);
    }
}
