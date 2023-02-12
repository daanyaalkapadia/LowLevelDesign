using PracticalDesign.TicTacToe.enums;

namespace PracticalDesign.TicTacToe.models
{
    public class HumanPlayer : Player
    {
        private HumanPlayer()
        {

        }
        public override Move MakeMove(Board board)
        {
            bool isValidMove = false;
            int row = 0;
            int column = 0;
            while (!isValidMove)
            {
                Console.WriteLine("Enter a row");
                Int32.TryParse(Console.ReadLine(), out row);
                Console.WriteLine("Enter a column");
                Int32.TryParse(Console.ReadLine(), out column);
                if (board.CellMatrix[row][column].State == CellState.FILLED)
                {
                    Console.WriteLine("Already Filled Cell");
                }
                else
                {
                    isValidMove = true;
                }
            }
            return new Move(this, board.CellMatrix[row][column]);
        }
        public static HumanPlayerBuilder GetBuilder()
        {
            return new HumanPlayerBuilder();
        }
        public class HumanPlayerBuilder
        {
            HumanPlayer player = new HumanPlayer();

            public HumanPlayerBuilder SetName(string? name)
            {
                player.Name = name;
                return this;
            }
            public HumanPlayerBuilder SetSymbol(char symbol)
            {
                player.Symbol = symbol;
                return this;
            }
            public HumanPlayer Build()
            {
                if (player.Symbol == null)
                {
                    throw new ApplicationException("Symbol not selected");
                }
                if (player.Name == null)
                {
                    throw new ApplicationException("Name not selected");
                }
                return player;
            }
        }
    }
}