using PracticalDesign.TicTacToe.enums;
using PracticalDesign.TicTacToe.factory;
using PracticalDesign.TicTacToe.strategy;

namespace PracticalDesign.TicTacToe.models
{
    public class Game
    {
        private Game()
        {
            PlayerList = new List<Player>();
        }
        public int _nextPlayerIndex { get; private set; }
        private IWinningStrategy? _winningStrategy;
        public List<Player> PlayerList { get; private set; }
        private List<Move> moveList = new List<Move>();
        public GameStatus Status { get; set; }
        public Board? BoardGrid { get; private set; }
        public Player? Winner { get; set; }

        public void MakeMove()
        {
            Player currentPlayer = PlayerList[_nextPlayerIndex];
            Move currentMove = currentPlayer.MakeMove(BoardGrid);

            BoardGrid.CellMatrix[currentMove.Cell.Row][currentMove.Cell.Col].State = CellState.FILLED;
            BoardGrid.CellMatrix[currentMove.Cell.Row][currentMove.Cell.Col].Player = currentPlayer;

            moveList.Add(currentMove);

            bool isWin = _winningStrategy.UpdateAndCheckWinner(currentMove);
            if (isWin)
            {
                Winner = currentPlayer;
                Status = GameStatus.FINISHED;
            }
            bool isDraw = BoardGrid.IsBoardFull();
            if (isDraw)
            {
                Status = GameStatus.FINISHED;
            }

            _nextPlayerIndex++;
            _nextPlayerIndex = _nextPlayerIndex % PlayerList.Count;
        }

        public static GameBuilder GetBuilder()
        {
            return new GameBuilder();
        }
        public class GameBuilder
        {
            private Game game = new Game();

            public GameBuilder SetBoard(int dimension)
            {
                game.BoardGrid = Board.GetBuilder().SetBoard(dimension).Build();
                return this;
            }
            public GameBuilder SetWinningStrategy(string winningStrategy, int dimension)
            {
                game._winningStrategy = WinningStrategyFactory.GetWinningStrategy(winningStrategy, 1);
                return this;
            }
            public GameBuilder SetPlayers(List<Player> players)
            {
                game.PlayerList.AddRange(players);
                return this;
            }
            public Game Build()
            {
                if (game.BoardGrid == null)
                {
                    throw new ApplicationException("Board Not Found");
                }
                if (game.BoardGrid.CellMatrix.Count <= 2)
                {
                    throw new ApplicationException("Please enter board size greater then 2.");
                }
                if (game.PlayerList.Count != (game.BoardGrid.CellMatrix.Count - 1))
                {
                    throw new ApplicationException("Board dimension and player count mismatch");
                }
                if (game._winningStrategy == null)
                {
                    throw new ApplicationException("Winning strategy not mapped");
                }
                game.Status = GameStatus.INPROGRESS;
                return game;
            }
        }
    }
}
