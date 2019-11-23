namespace ChessBeast.Models.Basis
{
    using ChessBeast.Models.Figures.Base;

    public class Board
    {
        public Board(Square[,] matrix)
        {
            this.Matrix = matrix;
        }
        public Square[,] Matrix { get; set; }

        public Square this[int x, int y]
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
