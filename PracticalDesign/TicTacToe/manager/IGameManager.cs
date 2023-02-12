using PracticalDesign.TicTacToe.models;

namespace PracticalDesign.TicTacToe.manager
{
    public interface IGameManager
    {
        public Game CreateGame();
        public void Play(Game game);
    }
}
