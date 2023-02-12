using PracticalDesign.TicTacToe.enums;

namespace PracticalDesign.TicTacToe.models
{
    public class Cell
    {
        public Cell(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            State = CellState.EMPTY;
        }
        public int Row { get; set; }
        public int Col { get; set; }
        public CellState State { get; set; }
        public Player? Player { get; set; }
    }
}
