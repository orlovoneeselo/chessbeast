namespace ChessBeast.Engine.MovesValidator.Validators
{
    using ChessBeast.Engine.MovesValidator.Validators.Contract;
    using ChessBeast.Extensions;
    using ChessBeast.Models.Basis;
    using ChessBeast.Models.Enums;

    public class KingLineAbandonmentValidator : IValidator
    {
        public bool Validate(Board board, Move move)
        {
            var kingPosition = board.KingPosition(move.Figure.Color);
            var temporaryBoard = board.ApplyMove(move);

            var valid = true;

            //White move scenario
            if (move.Figure.Color == Color.White)
            {
                //King opening forward 3:)
                for (int i = kingPosition.Y; i < 8; i++)
                {
                    var currentFigure = temporaryBoard[kingPosition.X, i].Figure;
                    if (currentFigure.Color == Color.White)
                    {
                        break;
                    }
                    if (currentFigure.IsHorizontalOrVerticalAtackingFigure())
                    {

                    }
                }
            }
            else //Black move scenario
            {

            }

            return valid;
        }
    }
}