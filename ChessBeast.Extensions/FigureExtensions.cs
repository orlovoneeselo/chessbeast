namespace ChessBeast.Extensions
{
    using System.Linq;
    using ChessBeast.Models.Enums;
    using ChessBeast.Models.Figures.Base;
    using System.Collections.Generic;

    public static class FigureExtensions
    {
        public static bool IsHorizontalOrVerticalAtackingFigure(this Figure figure)
        {
            IEnumerable<FigureValues> figures = new List<FigureValues> { FigureValues.Queen, FigureValues.Rook, FigureValues.Bishop };
            return figures.Any(x => x == figure.Value);
        }
        public static bool IsFriendyFigureWith(this Figure figure, Figure targetFigure)
        {
            return figure.Color == targetFigure.Color;
        }
    }
}
