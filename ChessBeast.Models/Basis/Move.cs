namespace ChessBeast.Models.Basis
{
    using ChessBeast.Models.Basis.Common;
    using ChessBeast.Models.Figures.Base;

    public class Move
    {
        public Position CurrentPosition { get; }
        public Position NextPosition { get; }
        public Figure Figure{ get;}

        public Move(Position currentPosition, Position nextPosition, Figure figure)
        {
            CurrentPosition = currentPosition;
            NextPosition = nextPosition;
            Figure = figure;
        }
    }
}