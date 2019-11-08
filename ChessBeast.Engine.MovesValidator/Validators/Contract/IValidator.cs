namespace ChessBeast.Engine.MovesValidator.Validators.Contract
{
    using ChessBeast.Models.Basis;

    public interface IValidator
    {
        bool Validate(Board board, Move move);
    }
}
