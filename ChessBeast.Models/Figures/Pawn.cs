namespace ChessBeast.Models.Figures
{
    using ChessBeast.Models.Basis;
    using ChessBeast.Models.Basis.Common;
    using ChessBeast.Models.Enums;
    using ChessBeast.Models.Figures.Base;
    using System.Collections.Generic;

    public class Pawn : Figure
    {
        public Pawn(Color color) : base(color)
        {
        }

        public override IEnumerable<Position> GetValidMoves(int x, int y, Board board)
        {
            List<Position> positions = new List<Position>();

            if(Color == Color.White)
            {
                Square squareForward = board[x - 1, y];
                Square twoSquaresForward = board[x - 2, y];

                //if (squareForward.IsEmpty() && board.IsPositionInside(new Position(x-1, y))
                //{

                //}
            }
            return positions;
        }
    }
}