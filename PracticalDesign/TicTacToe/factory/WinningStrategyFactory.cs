using PracticalDesign.TicTacToe.strategy;

namespace PracticalDesign.TicTacToe.factory
{
    public class WinningStrategyFactory
    {
        public static IWinningStrategy GetWinningStrategy(string strategy, int? dimension = null)
        {
            switch (strategy)
            {
                case "default":
                    return new DefaultWinningStrategy(dimension.Value);
                default:
                    throw new ApplicationException("Winning strategy not available");
            }
        }
    }
}
