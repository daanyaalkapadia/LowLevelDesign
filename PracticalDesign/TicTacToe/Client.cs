using PracticalDesign.TicTacToe.manager;
using PracticalDesign.TicTacToe.models;

namespace PracticalDesign.TicTacToe
{
    public class Client
    {
        public static void TicTacToeMain()
        {
            IGameManager gm = new GameManager();
            Game game = gm.CreateGame();
            gm.Play(game);
        }
    }
}
