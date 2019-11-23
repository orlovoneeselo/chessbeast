namespace ChessBeast.FigureFactory
{
    using ChessBeast.FigureFactory.Contract;
    using ChessBeast.Models.Figures.Base;
    using ChessBeast.Models.Enums;
    using System;
    using System.Linq;
    using ChessBeast.Models.Basis;
    using ChessBeast.Models.Extensions;
    using ChessBeast.IFactory;

    public class FigureFactory : IFigureFactory
    {
        private readonly string typeAssembly;
        public FigureFactory(FigureNames figureType, Color color)
        {
            this.FigureType = figureType;
            this.Color = color;
            this.typeAssembly = $"ChessBeast.Models.Figures.{figureType.ToString()}, ChessBeast.Models";
        }

        public FigureFactory(char figureType, Color color)
        {
            this.FigureType = figureType.GetFigureType();
            this.Color = color;
            this.typeAssembly = $"ChessBeast.Models.Figures.{FigureType.ToString()}, ChessBeast.Models";
        }

        private FigureNames FigureType { get; set; }
        private Color Color { get; set; }
        public Figure CreateEntity()
        {
            FigureNames type = ((FigureNames[])Enum.GetValues(typeof(FigureNames)))
                .FirstOrDefault(x => x == FigureType);
            return (Figure)Activator.CreateInstance(Type.GetType(typeAssembly), new object[] { Color });
        }
    }

}
