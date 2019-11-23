namespace ChessBeast.Models.Basis
{
    using ChessBeast.Models.Basis.Common;
    using ChessBeast.Models.Figures.Base;

    public class Square
    {
        public Square(Figure figure)
        {
            this.Figure = figure;
        }
        public Figure Figure { get; set; }
        public Position Position{ get; }
        public bool IsLocked { get; set; }
    }
}