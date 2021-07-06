using ConnectFour.Exceptions;
using ConnectFour.Models;
using ConnectFour.Service;
using FluentAssertions;
using System;
using Xunit;

namespace ConnectFourTests
{
    public class BoardServiceTests
    {
        //TODO add test for failed placement in row.
        //TODO add test for wrong row.
        //TODO Create test suite for  CheckerFactory.

        private readonly BoardService _sut;

        public BoardServiceTests()
        {
            _sut = new();
        }

        [Fact]
        public void DropChecker_GivenBoardAndRowNumber_PlacesChecker_InCorrectPlace()
        {
            Board board = new();
            Checker checker = new(CheckerColor.White);

            _sut.DropChecker(board, checker, 0);

            board.Places[0][5].Should().Be(checker);
        }

        [Fact]
        public void DropChecker_GivenCheckerToFullCollumn()
        {
            Board board = new();
            Checker checkerWhite = new(CheckerColor.White);
            Checker checkerBlack = new(CheckerColor.Black);

            for (int i = 0; i < board.Places[0].Length; i++)
            {
                if (i % 2 == 0)
                {
                    _sut.DropChecker(board, checkerWhite, 0);
                }
                else
                {
                    _sut.DropChecker(board, checkerBlack, 0);
                }
            }
            Action action = () => _sut.DropChecker(board, checkerWhite, 0);

            action.Should().Throw<InvalidPlacementException>().WithMessage("Row is Full.");
        }
    }
}
