namespace ChessBeast.Models.Basis
{
    using ChessBeast.Models.Figures.Base;
    public sealed class Board
    {
        public Board(Square<Figure>[,] matrix)
        {
            this.Matrix = matrix;
        }
        public Square<Figure>[,] Matrix { get; set; }
    }
}
