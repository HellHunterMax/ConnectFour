using ConnectFour.Models;
using ConnectFour.Service;
using FluentAssertions;
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
        public void BoardService_GivenBoardAndRowNumber_PlacesChecker_InCorrectPlace()
        {

            Board board = new();
            Checker checker = new(CheckerColor.White);

            _sut.DropChecker(board, checker, 0);

            board.Places[0][5].Should().Be(checker);
        }
    }
}
