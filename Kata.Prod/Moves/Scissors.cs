namespace Kata.Prod.Moves
{
    public class Scissors : IGameMove
    {
        public IGameMove Beats()
        {
            return new Paper();
        }
    }
}