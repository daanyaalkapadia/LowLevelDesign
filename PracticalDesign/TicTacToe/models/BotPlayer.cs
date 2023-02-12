using PracticalDesign.TicTacToe.enums;
using PracticalDesign.TicTacToe.factory;
using PracticalDesign.TicTacToe.strategy;

namespace PracticalDesign.TicTacToe.models
{
    public class BotPlayer : Player
    {
        private BotPlayer(string name)
        {
            Name = name;
        }
        public IBotPlayingStrategy? _playingStrategy { get; private set; }
        public static BotPlayerBuilder GetBuilder()
        {
            return new BotPlayerBuilder();
        }
        public override Move MakeMove(Board board)
        {
            return _playingStrategy.MakeMove(this, board);
        }
        public class BotPlayerBuilder
        {
            BotPlayer bot = new BotPlayer("tictac");

            public BotPlayerBuilder SetPlayingStrategy(BotPlayingStrategy botPlayingStrategy)
            {
                bot._playingStrategy = BotPlayingStrategyFactory.GetBotPlayingStrategy(botPlayingStrategy);
                return this;
            }
            public BotPlayerBuilder SetSymbol(char symbol)
            {
                bot.Symbol = symbol;
                return this;
            }
            public BotPlayer Build()
            {
                if (bot._playingStrategy == null)
                {
                    throw new ApplicationException("Bot playing strategy not selected");
                }
                if (bot.Symbol == null)
                {
                    throw new ApplicationException("Symbol not selected.");
                }
                return bot;
            }
        }
    }
}
