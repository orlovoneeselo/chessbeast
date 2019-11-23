namespace ChessBeast.Models.Extensions
{
    using ChessBeast.Models.Enums;
    using System;
    using System.Linq;
    public static class CharacterExtensions
    {
        public static FigureNames GetFigureType(this char ch)
        {
            return ((FigureNames[])Enum.GetValues(typeof(FigureNames)))
                         .FirstOrDefault(x => x.Description().ToLower() == ch.ToString().ToLower());
        }
    }
}
