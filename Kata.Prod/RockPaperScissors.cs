namespace Kata.Prod
{
    public class RockPaperScissors
    {
        public GameResult Play(GameInstrument player, GameInstrument opponent)
        {
            if (IsWinningMove(player, opponent))
            {
                return GameResult.Win;
            }

            if (IsDraw(player, opponent))
            {
                return GameResult.Draw;
            }

            return GameResult.Loose;
        }

        private bool IsWinningMove(GameInstrument player, GameInstrument opponent)
        {
            return ScissorsBeatsPaper(player, opponent) 
                   || PaperBeatRock(player, opponent)
                   || RockBeatScissors(player, opponent);
        }

        private bool RockBeatScissors(GameInstrument player, GameInstrument opponent)
        {
            return player == GameInstrument.Rock && opponent == GameInstrument.Scissors;
        }

        private bool ScissorsBeatsPaper(GameInstrument player, GameInstrument opponent)
        {
            return player == GameInstrument.Scissors && opponent == GameInstrument.Paper;
        }

        private bool PaperBeatRock(GameInstrument player, GameInstrument opponent)
        {
            return player == GameInstrument.Paper && opponent == GameInstrument.Rock;
        }

        private bool IsDraw(GameInstrument player, GameInstrument opponent)
        {
            return player.CompareTo(opponent) == 0;
        }
    }
}