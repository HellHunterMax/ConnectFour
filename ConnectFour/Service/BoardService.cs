using ConnectFour.Exceptions;
using ConnectFour.Models;
using System;

namespace ConnectFour.Service
{
    public class BoardService : IBoardService
    {
        /// <summary>
        /// Drop Checker into the collumn. this method with determen where it will be placed on the board.
        /// </summary>
        /// <param name="board">board where the checker is to be placed.</param>
        /// <param name="checker">the checker to be placed.</param>
        /// <param name="collumn">the collumn the checker will be palced in.</param>
        public void DropChecker(Board board, Checker checker, int collumn)
        {
            int rows = board.Places[collumn].Length;

            for (int row = 0; row < rows; row++)
            {
                if (board.Places[collumn][row] != null)
                {
                    if (row == 0)
                    {
                        throw new InvalidPlacementException("Row is Full.");
                    }
                    board.PlaceChecker(checker, collumn, row - 1);
                    break;
                }
                else if (row == rows - 1)
                {
                    board.PlaceChecker(checker, collumn, row);
                    break;
                }
            }
        }
        public static void VerifyValidinput(Board board, Checker checker, int collumn)
        {
            if (collumn < 0 || collumn >= board.Places.Length)
            {
                throw new InvalidPlacementException($"{nameof(collumn)} : {collumn} is an invalid collumn.");
            }
        }
        //TODO add check for win.
        //TODO add check for draw.

    }
}
