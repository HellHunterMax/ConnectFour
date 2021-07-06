using ConnectFour.Exceptions;

namespace ConnectFour.Models
{
    public class Board
    {
        public bool IsItWhitesTurn { get; private set; } = true;
        public int LastPlacedCheckerCollumn { get; private set; }
        public int LastPlacedCheckerRow { get; private set; }
        public int CheckersPlaced { get; private set; }
        public Checker[][] Places { get; private set; } = new Checker[7][] {
            new Checker[6],
            new Checker[6],
            new Checker[6],
            new Checker[6],
            new Checker[6],
            new Checker[6],
            new Checker[6]
        };

        public void PlaceChecker(Checker checker, int collumn, int row)
        {
            VerifyValidPlacement(collumn, row);

            this.Places[collumn][row] = checker;
            this.IsItWhitesTurn = !this.IsItWhitesTurn;
            this.LastPlacedCheckerCollumn = collumn;
            this.LastPlacedCheckerRow = row;
            this.CheckersPlaced++;
        }

        public void VerifyValidPlacement(int collumn, int row)
        {
            if (collumn < 0 || collumn >= Places.Length)
            {
                throw new InvalidPlacementException($"{nameof(collumn)} : {collumn} is an invalid collumn.");
            }
            if (row < 0 || row >= Places[collumn].Length)
            {
                throw new InvalidPlacementException($"{nameof(row)} : {row} is an invalid row.");
            }
            if (Places[collumn][row] != null)
            {
                throw new InvalidPlacementException("There is already a checker in this spot.");
            }
        }
    }
}
