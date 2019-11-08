namespace ChessBeast.Engine.MovesValidator.Contract
{
    using ChessBeast.Models.Basis;
    public interface IMovesValidator
    {
        bool ValidateMove(Board board, Move move);
    }
}
