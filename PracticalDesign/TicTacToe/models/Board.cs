using PracticalDesign.TicTacToe.enums;

namespace PracticalDesign.TicTacToe.models
{
    public class Board
    {
        public List<List<Cell>>? CellMatrix { get; set; }
        private Board()
        {

        }
        public void DisplayBoard()
        {
            foreach (var cellList in CellMatrix)
            {
                foreach (var cell in cellList)
                {
                    if (cell.Player != null)
                    {
                        Console.Write(" " + cell.Player.Symbol + " ");
                    }
                    else
                    {
                        Console.Write(" _ ");
                    }
                }
                Console.WriteLine();
            }
        }
        public bool IsBoardFull()
        {
            foreach (var cellList in CellMatrix)
            {
                foreach (var cell in cellList)
                {
                    if (cell.State == CellState.EMPTY)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static BoardBuilder GetBuilder()
        {
            return new BoardBuilder();
        }
        public class BoardBuilder
        {
            Board board = new Board();
            public BoardBuilder SetBoard(int dimension)
            {
                if (dimension > 2)
                {
                    board.CellMatrix = new List<List<Cell>>();
                    for (int i = 0; i < dimension; i++)
                    {
                        List<Cell> row = new List<Cell>();
                        for (int j = 0; j < dimension; j++)
                        {
                            Cell cell = new Cell(i, j);
                            row.Add(cell);
                        }
                        board.CellMatrix.Add(row);
                    }
                }
                return this;
            }
            public Board Build()
            {
                if (board.CellMatrix == null)
                {
                    throw new ApplicationException("Board not build. There were incorrect dimension.");
                }
                return board;
            }
        }
    }
}
