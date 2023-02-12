using PracticalDesign.TicTacToe.enums;
using PracticalDesign.TicTacToe.models;

namespace PracticalDesign.TicTacToe.manager
{
    public class GameManager : IGameManager
    {
        public Game CreateGame()
        {
            List<Player> players = new List<Player>();
            Console.WriteLine("Enter Dimensions of board");
            bool isValidDimension = false;
            int dimension = 0;
            while (!isValidDimension)
            {
                isValidDimension = Int32.TryParse(Console.ReadLine(), out dimension);
                if (!isValidDimension)
                {
                    Console.WriteLine("Invalid Dimension. Please enter integer");
                }
            }
            for (int i = 1; i < dimension; i++)
            {
                string playerTypeInitial = GetPlayerTypeFromUser(i);
                char symbol = GetSymbolFromUser();
                if (playerTypeInitial == "h")
                {
                    string? name = GetPlayerName();
                    Player humanPlayer = HumanPlayer.GetBuilder().SetName(name).SetSymbol(symbol).Build();
                    players.Add(humanPlayer);
                }
                else
                {
                    Player humanPlayer = BotPlayer.GetBuilder().SetPlayingStrategy(BotPlayingStrategy.Sequential).SetSymbol(symbol).Build();
                    players.Add(humanPlayer);
                }
            }
            return Game.GetBuilder().SetWinningStrategy("default", dimension).SetPlayers(players).SetBoard(dimension).Build();
        }

        public void Play(Game game)
        {
            Console.WriteLine("Game Started!!");
            while (game.Status == GameStatus.INPROGRESS)
            {
                string name = game.PlayerList[game._nextPlayerIndex].Name;
                Console.WriteLine(name + "'s turn");
                game.MakeMove();
                game.BoardGrid.DisplayBoard();
            }
            if (game.Winner == null)
            {
                Console.WriteLine("Match Draw");
            }
            else
            {
                Console.WriteLine("Winner is " + game.Winner.Name + " " + game.Winner.Symbol);
            }
        }

        private string GetPlayerTypeFromUser(int playerCounter)
        {
            Console.WriteLine("Player " + playerCounter.ToString() + " is bot or human?");
            Console.WriteLine("Type b -> bot h -> human");
            string? playerTypeInitial = null;
            bool isValidPlayerTypeInitial = false;
            while (!isValidPlayerTypeInitial)
            {
                playerTypeInitial = Console.ReadLine();
                if (!(playerTypeInitial == null || (playerTypeInitial != "b" && playerTypeInitial != "h")))
                {
                    isValidPlayerTypeInitial = true;
                }
                else
                {
                    Console.WriteLine("Invalid Initial");
                }
            }

            return playerTypeInitial;
        }

        private char GetSymbolFromUser()
        {
            Console.WriteLine("Enter Symbol");
            bool isValidSymbol = false;
            char playerSymbol = '\0';
            while (!isValidSymbol)
            {
                isValidSymbol = char.TryParse(Console.ReadLine(), out playerSymbol);
                if (!isValidSymbol)
                {
                    Console.WriteLine("Invalid symbol");
                }
            }
            return playerSymbol;
        }
        public string? GetPlayerName()
        {
            Console.WriteLine("Enter player name");
            return Console.ReadLine();
        }
    }
}
