using PracticalDesign.TicTacToe.models;

namespace PracticalDesign.TicTacToe.strategy
{
    public class DefaultWinningStrategy : IWinningStrategy
    {
        int dimension;
        private List<Dictionary<char, int>> rowSymbolCount = new List<Dictionary<char, int>>();
        private List<Dictionary<char, int>> colSymbolCount = new List<Dictionary<char, int>>();
        private Dictionary<char, int> topleftDiagnolSymbolCount = new Dictionary<char, int>();
        private Dictionary<char, int> topRightDiagnolSymbolCount = new Dictionary<char, int>();
        public DefaultWinningStrategy(int dimension)
        {
            for (int i = 0; i < dimension; i++)
            {
                rowSymbolCount.Add(new Dictionary<char, int>());
                colSymbolCount.Add(new Dictionary<char, int>());
            }
            this.dimension = dimension;
        }
        private bool IsTopLeftDiagnol(Move move)
        {
            return move.Cell.Row == move.Cell.Col;
        }
        private bool IsTopRightDiagnol(Move move)
        {
            return move.Cell.Row + move.Cell.Col == dimension - 1;
        }
        public bool UpdateAndCheckWinner(Move move)
        {
            int row = move.Cell.Row;
            int col = move.Cell.Col;
            if (!rowSymbolCount[row].ContainsKey(move.Player.Symbol.Value))
            {
                rowSymbolCount[row].Add(move.Player.Symbol.Value, 0);
            }
            rowSymbolCount[row][move.Player.Symbol.Value] += 1;
            if (!colSymbolCount[col].ContainsKey(move.Player.Symbol.Value))
            {
                colSymbolCount[col].Add(move.Player.Symbol.Value, 0);
            }
            colSymbolCount[col][move.Player.Symbol.Value] += 1;
            if (IsTopLeftDiagnol(move))
            {
                if (!topleftDiagnolSymbolCount.ContainsKey(move.Player.Symbol.Value))
                {
                    topleftDiagnolSymbolCount.Add(move.Player.Symbol.Value, 0);
                }
                topleftDiagnolSymbolCount[move.Player.Symbol.Value] += 1;
            }
            if (IsTopRightDiagnol(move))
            {
                if (!topRightDiagnolSymbolCount.ContainsKey(move.Player.Symbol.Value))
                {
                    topRightDiagnolSymbolCount.Add(move.Player.Symbol.Value, 0);
                }
                topRightDiagnolSymbolCount[move.Player.Symbol.Value] += 1;
            }
            return CheckWinner(move);
        }
        private bool CheckWinner(Move move)
        {
            if (rowSymbolCount[move.Cell.Row].ContainsKey(move.Player.Symbol.Value) && rowSymbolCount[move.Cell.Row][move.Player.Symbol.Value] == dimension)
            {
                return true;
            }
            else if (colSymbolCount[move.Cell.Col].ContainsKey(move.Player.Symbol.Value) && colSymbolCount[move.Cell.Col][move.Player.Symbol.Value] == dimension)
            {
                return true;
            }
            else if (topleftDiagnolSymbolCount.ContainsKey(move.Player.Symbol.Value) && topleftDiagnolSymbolCount[move.Player.Symbol.Value] == dimension)
            {
                return true;
            }
            else if (topRightDiagnolSymbolCount.ContainsKey(move.Player.Symbol.Value) && topRightDiagnolSymbolCount[move.Player.Symbol.Value] == dimension)
            {
                return true;
            }
            return false;
        }
    }
}