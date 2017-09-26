using Kata.Domain;

namespace Kata.Prod
{
    public class GameEngine
    {
        public GameResult Play(IGameMove player, IGameMove opponent)
        {
           
            if (PlayerWins(player, opponent))
            {
                return GameResult.Win;
            }

            if (PlayerDraws(player, opponent))
            {
                return GameResult.Draw;
            }

            return GameResult.Loose;
        }

        private bool PlayerDraws(IGameMove player, IGameMove opponent)
        {
            return player.GetType() == opponent.GetType();
        }

        private bool PlayerWins(IGameMove player, IGameMove opponent)
        {
            var playerWinsIfOpponentIs = player.Beats();

            return playerWinsIfOpponentIs.GetType() == opponent.GetType();
        }
    }
}