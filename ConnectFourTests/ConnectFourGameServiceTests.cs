using ConnectFour.Exceptions;
using ConnectFour.Models;
using ConnectFour.Service;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConnectFourTests
{
    //TODO create Other Vertical Win check
    //TODO create Black win Check.
    public class ConnectFourGameServiceTests
    {
        private readonly ConnectFourGameService _sut;

        public ConnectFourGameServiceTests()
        {
            _sut = new();
        }

        [Fact]
        public void CheckGameEnd_Given7Checkers_ToEndGameVertical_ThrowsGameEndException()
        {
            Board board = new();
            Checker checkerWhite = new(CheckerColor.White);
            Checker checkerBlack = new(CheckerColor.Black);
            string ExceptionMessage = "Game ended White Wins!!!";

            int row = 5;
            for (int i = 0; i < 7; i++)
            {
                if (i % 2 == 0)
                {
                    board.PlaceChecker(checkerWhite, 0, row);
                }
                else
                {
                    board.PlaceChecker(checkerBlack, 1, row);
                    row -= 1;
                }
            }
            Action action = () => _sut.CheckGameEnd(board);

            action.Should().Throw<GameEndException>().WithMessage(ExceptionMessage);
        }

        [Fact]
        public void CheckGameEnd_Given7Checkers_ToEndGameHorizontal_ThrowsGameEndException()
        {
            Board board = new();
            Checker checkerWhite = new(CheckerColor.White);
            Checker checkerBlack = new(CheckerColor.Black);
            string ExceptionMessage = "Game ended White Wins!!!";

            int collumn = 0;
            for (int i = 0; i < 7; i++)
            {
                if (i % 2 == 0)
                {
                    board.PlaceChecker(checkerWhite, collumn, 5);
                }
                else
                {
                    board.PlaceChecker(checkerBlack, collumn, 4);
                    collumn += 1;
                }
            }
            Action action = () => _sut.CheckGameEnd(board);

            action.Should().Throw<GameEndException>().WithMessage(ExceptionMessage);
        }

        [Fact]
        public void CheckGameEnd_Given7Checkers_ToEndGameDiagonal_ThrowsGameEndException()
        {
            Board board = new();
            Checker checkerWhite = new(CheckerColor.White);
            Checker checkerBlack = new(CheckerColor.Black);
            string ExceptionMessage = "Game ended White Wins!!!";

            board.PlaceChecker(checkerWhite, 0, 5); //1
            board.PlaceChecker(checkerBlack, 1, 5); //2
            board.PlaceChecker(checkerWhite, 1, 4); //3
            board.PlaceChecker(checkerBlack, 2, 5);//4
            board.PlaceChecker(checkerWhite, 2, 4);//5
            board.PlaceChecker(checkerBlack, 3, 5);//6
            board.PlaceChecker(checkerWhite, 2, 3);//7
            board.PlaceChecker(checkerBlack, 3, 4);//8
            board.PlaceChecker(checkerWhite, 3, 3);//9
            board.PlaceChecker(checkerBlack, 0, 4);//10
            board.PlaceChecker(checkerWhite, 3, 2);//11

            Action action = () => _sut.CheckGameEnd(board);

            action.Should().Throw<GameEndException>().WithMessage(ExceptionMessage);
        }
    }
}
