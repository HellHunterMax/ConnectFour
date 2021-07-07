using ConnectFour.Models;

namespace ConnectFour.FrontEnd
{
    public interface IConnectFourFrontEnd
    {
        /// <summary>
        /// Shows the board and lets the user choose one of the collumns.
        /// </summary>
        /// <param name="board">board to be shown on screen.</param>
        /// <returns></returns>
        int GetCollumnChoice(Board board);

        /// <summary>
        /// Shows the message of who won
        /// </summary>
        /// <param name="message"></param>
        void ShowGameEndScreen(string message);
    }
}
