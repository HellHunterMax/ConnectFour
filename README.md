# ConnectFour
A console Connect Four game.

## What?
Personal project for a Job interview. Took me about 6 hours to make.

## How to play?
dotnet run will let you play one game of connect 4 on a 7x6 board with X's and O's.
White is X
Black is O.
 - White starts.
 - Move the Checker above the board with the arrow keys.
 - Press Enter to drop the checker.
 Game will end when one player has 4 checkers in a row.

### Given more time I would:
 - Make the Frontend more DRY.
 - Add color to the frontend
 - Add more tests.
 - Refactor some classes to make it more in line with Open Close Principle, right now this is terrible.
 - Add a BoardFactory and remake the Board Model so it works with multiple sizes and multiple games. (Connect 5 or 10x10 board)
 - Rafactor the EndGameCheck. way to big and unreadable. it does not adhere to Open Closed Principle.
 - Remove BoardService and place it in GameService.
