namespace ChessBeast.Models.Figures
{
    using ChessBeast.Models.Basis;
    using ChessBeast.Models.Basis.Common;
    using ChessBeast.Models.Enums;
    using ChessBeast.Models.Figures.Base;
    using System.Collections.Generic;

    public class Bishop : Figure
    {
        public Bishop(Color color) : base(color)
        {

        }

        public override IEnumerable<Position> GetValidMoves(int x, int y, Board board)
        {
            List<Position> positions = new List<Position>();

            return null;
        }
    }
}