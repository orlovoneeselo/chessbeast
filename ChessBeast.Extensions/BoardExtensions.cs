namespace ChessBeast.Extensions
{
    using ChessBeast.Models.Basis;
    using ChessBeast.Models.Basis.Common;
    using ChessBeast.Models.Enums;
    using ChessBeast.Models.Figures.Base;
    using System;

    public static class BoardExtensions
    {
        public static Position KingPosition(this Board board, Color color)
        {
            var matrix = board.Matrix;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matrix[i, j].Figure.Value == FigureValues.King && matrix[i, j].Figure.Color == color)
                    {
                        return new Position(i, j);
                    }
                }
            }
            throw new Exception("King not found.");
        }

        public static Board ApplyMove(this Board board, Move move)
        {
            var tempBoard = board.DeepClone();
            tempBoard[move.NextPosition.X, move.NextPosition.Y] = new Square<Figure>(move.Figure);
            tempBoard[move.CurrentPosition.X, move.CurrentPosition.Y] = null;
            return tempBoard;
        }
    }
}
