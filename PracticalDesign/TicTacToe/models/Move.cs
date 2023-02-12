namespace PracticalDesign.TicTacToe.models
{
    public class Move
    {
        public Move(Player player, Cell cell)
        {
            Player = player;
            Cell = cell;
        }

        public Player Player { get; set; }
        public Cell Cell { get; set; }
    }
}
