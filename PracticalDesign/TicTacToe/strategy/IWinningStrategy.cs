using PracticalDesign.TicTacToe.models;

namespace PracticalDesign.TicTacToe.strategy
{
    public interface IWinningStrategy
    {
        bool UpdateAndCheckWinner(Move move);
    }
}
