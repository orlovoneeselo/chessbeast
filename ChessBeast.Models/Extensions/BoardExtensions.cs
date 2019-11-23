namespace ChessBeast.Models.Extensions
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
                    if (matrix[i, j].Figure.Name == FigureNames.King && matrix[i, j].Figure.Color == color)
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
            tempBoard[move.NextPosition.X, move.NextPosition.Y] = new Square(move.Figure);
            tempBoard[move.CurrentPosition.X, move.CurrentPosition.Y] = null;
            return tempBoard;
        }

        public static bool IsPositionInside(this Board board, Position position)
        {
            if(position.X > -1 && position.X < 8 && position.Y > -1 && position.Y < 8)
            {
                return true;
            }
            return false;
        }
    }
}
