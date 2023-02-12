using PracticalDesign.TicTacToe.models;

namespace PracticalDesign.TicTacToe.strategy
{
    public interface IBotPlayingStrategy
    {
        Move MakeMove(Player player, Board board);
    }
}
