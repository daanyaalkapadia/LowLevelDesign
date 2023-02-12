using PracticalDesign.TicTacToe.enums;
using PracticalDesign.TicTacToe.strategy;

namespace PracticalDesign.TicTacToe.factory
{
    public class BotPlayingStrategyFactory
    {
        public static IBotPlayingStrategy GetBotPlayingStrategy(BotPlayingStrategy botPlayingStrategy)
        {
            switch (botPlayingStrategy)
            {
                case BotPlayingStrategy.Sequential:
                    return new SequentialBotPlayingStrategy();
                default:
                    throw new ApplicationException("Bot playing strategy not available");
            }
        }
    }
}
