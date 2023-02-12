using PracticalDesign.TicTacToe.models;

namespace PracticalDesign.TicTacToe.strategy
{
    public class SequentialBotPlayingStrategy : IBotPlayingStrategy
    {
        public Move MakeMove(Player player, Board board)
        {
            for (int i = 0; i < board.CellMatrix.Count; i++)
            {
                for (int j = 0; j < board.CellMatrix.Count; j++)
                {
                    if (board.CellMatrix[i][j].State == enums.CellState.EMPTY)
                    {
                        return new Move(player, new Cell(i, j));
                    }
                }
            }
            return null;
        }
    }
}
