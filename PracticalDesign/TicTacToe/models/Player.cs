namespace PracticalDesign.TicTacToe.models
{
    public abstract class Player
    {
        public char? Symbol { get; set; }
        public string? Name { get; set; }

        public abstract Move MakeMove(Board board);

    }
}
