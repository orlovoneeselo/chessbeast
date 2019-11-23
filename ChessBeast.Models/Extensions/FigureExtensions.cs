namespace ChessBeast.Models.Extensions
{
    using System.Linq;
    using ChessBeast.Models.Enums;
    using ChessBeast.Models.Figures.Base;
    using System.Collections.Generic;

    public static class FigureExtensions
    {
        public static bool IsHorizontalOrVerticalAtackingFigure(this Figure figure)
        {
            IEnumerable<FigureNames> figures = new List<FigureNames> { FigureNames.Queen, FigureNames.Rook, FigureNames.Bishop };
            return figures.Any(x => x == figure.Name);
        }
        public static bool IsFriendyFigureWith(this Figure figure, Figure targetFigure)
        {
            return figure.Color == targetFigure.Color;
        }
    }
}
