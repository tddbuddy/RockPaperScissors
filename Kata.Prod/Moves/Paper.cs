using Kata.Domain;

namespace Kata.Prod.Moves
{
    public class Paper : IGameMove
    {
        public IGameMove Beats()
        {
            return new Rock();
        }
    }
}