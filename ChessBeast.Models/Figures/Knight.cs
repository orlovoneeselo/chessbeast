namespace ChessBeast.Models.Figures
{
    using System.Collections.Generic;
    using ChessBeast.Models.Basis;
    using ChessBeast.Models.Basis.Common;
    using ChessBeast.Models.Enums;
    using ChessBeast.Models.Figures.Base;

    public class Knight : Figure
    {
        public Knight(Color color) : base(color)
        {
        }

        public override IEnumerable<Position> GetValidMoves(int x, int y, Board board)
        {
            throw new System.NotImplementedException();
        }
    }
}