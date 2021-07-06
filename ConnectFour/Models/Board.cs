namespace ConnectFour.Models
{
    public class Board
    {
        public bool IsItWhitesTurn { get; private set; } = true;
        public int[] LastPlacedChecker { get; private set; } = new int[2];
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
            this.Places[collumn][row] = checker;
            this.IsItWhitesTurn = !this.IsItWhitesTurn;
            this.LastPlacedChecker[0] = collumn;
            this.LastPlacedChecker[1] = row;
            this.CheckersPlaced++;
        }
        //TODO add valid placement check
    }
}
