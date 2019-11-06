namespace ChessBeast.Models.Enums
{
    public struct StartingPosition
    {
        public int X { get; }
        public int Y { get; }

        public StartingPosition(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
