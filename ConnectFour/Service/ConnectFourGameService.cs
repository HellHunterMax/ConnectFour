using ConnectFour.Exceptions;
using ConnectFour.Models;

namespace ConnectFour.Service
{
    //TODO create Game.
    public class ConnectFourGameService : IGameService
    {
        public void CheckGameEnd(Board board)
        {
            if (board.CheckersPlaced < 7)
            {
                return;
            }

            if (board.CheckersPlaced == board.Places.Length * board.Places[0].Length)
            {
                throw new GameEndException("Game is a Draw");
            }


            CheckerColor color = board.IsItWhitesTurn ? CheckerColor.Black : CheckerColor.White;
            if (CheckHorizontal(board, color) || CheckVertical(board, color) || CheckDiagonalLeftToUp(board, color) || CheckDiagonalLeftToDown(board, color))
            {
                throw new GameEndException($"Game ended {color} Wins!!!");
            }
        }

        private static bool CheckDiagonalLeftToDown(Board board, CheckerColor color)
        {
            int numberOfConnectedCheckers = 1;
            int collumnLeft = board.LastPlacedCheckerCollumn - 1;
            int collumnRight = board.LastPlacedCheckerCollumn + 1;
            int rowUp = board.LastPlacedCheckerRow - 1;
            int rowDown = board.LastPlacedCheckerRow + 1;

            while (collumnLeft >= 0 && rowUp >= 0)
            {
                if (board.Places[collumnLeft][rowUp] == null)
                {
                    break;
                }
                else if (board.Places[collumnLeft][rowUp].Color == color)
                {
                    numberOfConnectedCheckers++;
                    if (numberOfConnectedCheckers == 4)
                    {
                        return true;
                    }
                }
                else
                {
                    break;
                }

                collumnLeft--;
                rowUp--;
            }
            while (collumnRight < 7 && rowDown < 6)
            {
                if (board.Places[collumnRight][rowDown] == null)
                {
                    break;
                }
                else if (board.Places[collumnRight][rowDown].Color == color)
                {
                    numberOfConnectedCheckers++;
                    if (numberOfConnectedCheckers == 4)
                    {
                        return true;
                    }
                }
                else
                {
                    break;
                }
                collumnRight++;
                rowDown++;
            }
            return false;

        }

        private static bool CheckDiagonalLeftToUp(Board board, CheckerColor color)
        {
            int numberOfConnectedCheckers = 1;
            int collumnLeft = board.LastPlacedCheckerCollumn - 1;
            int collumnRight = board.LastPlacedCheckerCollumn + 1;
            int rowUp = board.LastPlacedCheckerRow - 1;
            int rowDown = board.LastPlacedCheckerRow + 1;

            while (collumnLeft >= 0 && rowDown < 6)
            {
                if (board.Places[collumnLeft][rowDown] == null)
                {
                    break;
                }
                else if (board.Places[collumnLeft][rowDown].Color == color)
                {
                    numberOfConnectedCheckers++;
                    if (numberOfConnectedCheckers == 4)
                    {
                        return true;
                    }
                }
                else
                {
                    break;
                }

                collumnLeft--;
                rowDown++;
            }
            while (collumnRight < 7 && rowUp >= 0)
            {
                if (board.Places[collumnRight][rowUp] == null)
                {
                    break;
                }
                else if (board.Places[collumnRight][rowUp].Color == color)
                {
                    numberOfConnectedCheckers++;
                    if (numberOfConnectedCheckers == 4)
                    {
                        return true;
                    }
                }
                else
                {
                    break;
                }
                collumnRight++;
                rowUp--;
            }
            return false;
        }

        private static bool CheckHorizontal(Board board, CheckerColor color)
        {
            int numberOfConnectedCheckers = 1;
            int collumnLeft = board.LastPlacedCheckerCollumn - 1;
            int collumnRight = board.LastPlacedCheckerCollumn + 1;
            int row = board.LastPlacedCheckerRow;

            while (collumnLeft >= 0)
            {
                if (board.Places[collumnLeft][row] == null)
                {
                    break;
                }
                else if (board.Places[collumnLeft][row].Color == color)
                {
                    numberOfConnectedCheckers++;
                    if (numberOfConnectedCheckers == 4)
                    {
                        return true;
                    }
                }
                else
                {
                    break;
                }
                collumnLeft--;
            }
            while (collumnRight < 7)
            {
                if (board.Places[collumnRight][row] == null)
                {
                    break;
                }
                else if (board.Places[collumnRight][row].Color == color)
                {
                    numberOfConnectedCheckers++;
                    if (numberOfConnectedCheckers == 4)
                    {
                        return true;
                    }
                }
                else
                {
                    break;
                }
                collumnRight++;
            }
            return false;
        }

        private static bool CheckVertical(Board board, CheckerColor color)
        {
            int numberOfConnectedCheckers = 1;

            if (board.LastPlacedCheckerRow > 2)
            {
                return false;
            }
            else
            {
                int locationTocheck = board.LastPlacedCheckerRow + 1;
                while (locationTocheck < 6)
                {
                    if (board.Places[board.LastPlacedCheckerCollumn][locationTocheck].Color == color)
                    {
                        numberOfConnectedCheckers++;
                        locationTocheck++;
                        if (numberOfConnectedCheckers == 4)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
        }
    }
}
