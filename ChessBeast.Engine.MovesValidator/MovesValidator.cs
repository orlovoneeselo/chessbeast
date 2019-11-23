namespace ChessBeast.Engine.MovesValidator
{
    using ChessBeast.Engine.MovesValidator.Contract;
    using ChessBeast.Models.Basis;

    public class MovesValidator : IMovesValidator
    {
        public MovesValidator()
        {
            //
        }
        public bool ValidateMove(Board board, Move move)
        {
            return Validate(board , move);
        }

        private bool Validate(Board board, Move move)
        {
            return ValidateMove(board, move);
        }
    }
}