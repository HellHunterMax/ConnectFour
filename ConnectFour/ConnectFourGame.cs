using ConnectFour.Exceptions;
using ConnectFour.Factories;
using ConnectFour.FrontEnd;
using ConnectFour.Models;
using ConnectFour.Service;
using System;

namespace ConnectFour
{
    public class ConnectFourGame
    {
        private readonly IGameService _gameService;
        private readonly IBoardService _boardService;
        private readonly ICheckerFactory _checkerFactory;
        private readonly IConnectFourFrontEnd _connectFourFrontEnd;

        public ConnectFourGame(IGameService gameService, IBoardService boardService, ICheckerFactory checkerFactory, IConnectFourFrontEnd connectFourFrontEnd)
        {
            _gameService = gameService;
            _boardService = boardService;
            _checkerFactory = checkerFactory;
            _connectFourFrontEnd = connectFourFrontEnd;
        }

        public void PlayGame()
        {
            bool isGamePlaying = true;
            string gameEndMessage = String.Empty;
            Board board = new();

            while (isGamePlaying)
            {
                try
                {
                    int collumnChoice = _connectFourFrontEnd.GetCollumnChoice(board);
                    Checker checker = _checkerFactory.Create(board);
                    try
                    {
                        _boardService.DropChecker(board, checker, collumnChoice);
                        _gameService.CheckGameEnd(board);
                    }
                    catch (InvalidPlacementException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadKey();
                    }
                }
                catch (GameEndException ex)
                {
                    isGamePlaying = false;
                    gameEndMessage = ex.Message;
                }
            }
            _connectFourFrontEnd.ShowGameEndScreen(board, gameEndMessage);
        }

    }
}
