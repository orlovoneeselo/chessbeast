namespace ChessBeast.Models.Enums
{
    using System.ComponentModel;
    public enum FigureNames
    {
        [Description("K")]
        King = int.MaxValue / 2,
        [Description("Q")]
        Queen = 100000,
        [Description("R")]
        Rook = 50000,
        [Description("N")]
        Knight = 30000,
        [Description("B")]
        Bishop = 29999,
        [Description("P")]
        Pawn = 10000,
    }
}
