namespace ChessBeast.Models.Figures.Base
{
    using ChessBeast.Models.Enums;
    using System;

    public abstract class Figure
    {
        public FigureValues Value { get; set; }
        public Color Color { get; set; }

        public Figure(Color color)
        {
            this.Value = (FigureValues)Enum.Parse(typeof(FigureValues), this.GetType().Name);
            this.Color = color;
        }
    }
}
