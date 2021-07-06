using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using ConnectFour.Models;
using ConnectFour.Exceptions;

namespace ConnectFourTests
{
    public class BoardTests
    {
        private readonly Board _sut;

        public BoardTests()
        {
            _sut = new Board();
        }

        [Theory]
        [InlineData(-1, 0, "collumn : -1 is an invalid collumn.")]
        [InlineData(7, 0, "collumn : 7 is an invalid collumn.")]
        [InlineData(0, -1, "row : -1 is an invalid row.")]
        [InlineData(0, 6, "row : 6 is an invalid row.")]
        public void PlaceChecker_Given_InvalidParameters_ThrowsInvalidPlacementException(int collumn, int row, string ExceptionMessage)
        {
            Checker checker = new(CheckerColor.White);

            Action action = () => _sut.PlaceChecker(checker, collumn, row);

            action.Should().Throw<InvalidPlacementException>().WithMessage(ExceptionMessage);
        }
        [Fact]
        public void PlaceChecker_GivenInvalidCheckerPlace_ThrowsInvalidPlacementException()
        {
            //Arrange
            Checker checkerWhite = new(CheckerColor.White);
            Checker checkerBlack = new(CheckerColor.White);

            //Act
            _sut.PlaceChecker(checkerWhite, 0, 0);
            Action action = () => _sut.PlaceChecker(checkerBlack, 0, 0);

            //Assert
            action.Should().Throw<InvalidPlacementException>().WithMessage("There is already a checker in this spot.");
        }
    }
}
