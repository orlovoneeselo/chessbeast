using ChessBeast.Models.Basis;

namespace ChessBeast.Models.Extensions
{
    public static class SquareExtensions
    {
        public static bool IsEmpty(this Square square)
        {
            if(square.Figure == null)
            {
                return true;
            }
            return false;
        }
    }
}
