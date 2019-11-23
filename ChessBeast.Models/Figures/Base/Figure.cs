namespace ChessBeast.Models.Figures.Base
{
    using ChessBeast.Models.Basis;
    using ChessBeast.Models.Basis.Common;
    using ChessBeast.Models.Enums;
    using System;
    using System.Collections.Generic;

    public abstract class Figure
    {

        public Figure(Color color)
        {
            Name = (FigureNames)Enum.Parse(typeof(FigureNames), GetType().Name);
            Color = color;
        }

        public FigureNames Name { get; set; }
        public Color Color { get; set; }
        public bool HasMoved { get; set; }

        public abstract IEnumerable<Position> GetValidMoves(int x, int y, Board board);
    }
}
