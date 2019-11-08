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

        public Square<Figure> this[int x, int y]
        {
            get
            {
                return Matrix[x, y];
            }
            set
            {
                Matrix[x, y] = value;
            }
        }
    }
}
