namespace Kata.Prod.Moves
{
    public class Rock : IGameMove
    {
        public IGameMove Beats()
        {
            return new Scissors();
        }
    }
}