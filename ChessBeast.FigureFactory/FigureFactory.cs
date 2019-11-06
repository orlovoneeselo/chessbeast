namespace ChessBeast.FigureFactory
{
    using ChessBeast.FigureFactory.Contract;
    using ChessBeast.Models.Figures.Base;
    using ChessBeast.Models.Enums;
    using System;
    using System.Linq;

    public class FigureFactory : IFigureFactory
    {
        private readonly string typeAssembly;
        public FigureFactory(FigureValues figureType, Color color)
        {
            this.FigureType = figureType;
            this.Color = color;
            this.typeAssembly = $"ChessBeast.Models.Figures.{figureType.ToString()}, ChessBeast.Models";
        }

        private FigureValues FigureType { get; set; }
        private Color Color { get; set; }
        public Figure CreateEntity()
        {
            Figure entity = null;
            var type = ((FigureValues[])Enum.GetValues(typeof(FigureValues)))
                .FirstOrDefault(x => x == FigureType);
            var figureType = Type.GetType(typeAssembly);
            entity = (Figure)Activator.CreateInstance(figureType, new object[] { Color });

            return entity;
        }
    }

}
