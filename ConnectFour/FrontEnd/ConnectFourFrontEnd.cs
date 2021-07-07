using ConnectFour.Models;
using System;
using System.Text;

namespace ConnectFour.FrontEnd
{
    public class ConnectFourFrontEnd : IConnectFourFrontEnd
    {
        private const string emptyCollumn = "   ", arrowWhite = " X ", arrowBlack = " O ";
        public int GetCollumnChoice(Board board)
        {
            ConsoleKey key = ConsoleKey.A;
            int selectedCollumn = 0;
            while (key != ConsoleKey.Enter)
            {
                key = ConsoleKey.A;
                Console.Clear();
                PrintArrowToCollumn(selectedCollumn, board);
                PrintBoard(board);
                while (key != ConsoleKey.Enter && key != ConsoleKey.LeftArrow && key != ConsoleKey.RightArrow)
                {
                    key = Console.ReadKey().Key;
                }
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (selectedCollumn > 0)
                        {
                            selectedCollumn--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (selectedCollumn < board.Places.Length -1)
                        {
                            selectedCollumn++;
                        }
                        break;
                }
            }
            return selectedCollumn;
        }

        private void PrintBoard(Board board)
        {
            for (int row = 0; row < board.Places[0].Length; row++)
            {
                StringBuilder row1 = new(), row2 = new(), row3 = new();
                for (int coll = 0; coll < board.Places.Length; coll++)
                {
                    char checkerOrNot = ' ';
                    if (board.Places[coll][row] == null)
                    {

                    }
                    else if (board.Places[coll][row].Color == CheckerColor.White)
                    {
                        checkerOrNot = 'X';
                    }
                    else if (board.Places[coll][row].Color == CheckerColor.Black)
                    {
                        checkerOrNot = 'O';
                    }

                    row1.Append("===");
                    row2.Append($"|{checkerOrNot}|");
                    row3.Append("===");
                }
                if (row == board.Places[0].Length -1)
                {
                    Console.WriteLine(row1);
                    Console.WriteLine(row2);
                    Console.WriteLine(row3);
                }
                else
                {
                    Console.WriteLine(row1);
                    Console.WriteLine(row2);
                }
            }
        }

        private void PrintArrowToCollumn(int selectedCollumn, Board board)
        {
            for (int i = 0; i < board.Places.Length; i++)
            {
                if (i != selectedCollumn)
                {
                    Console.Write(emptyCollumn);
                }
                else
                {
                    string arrow = board.IsItWhitesTurn ? arrowWhite : arrowBlack;
                    Console.Write(arrow);
                }
            }
            Console.WriteLine();
        }

        public void ShowGameEndScreen(Board board, string message)
        {
            Console.Clear();
            PrintBoard(board);
            Console.WriteLine(message);
        }
    }
}
