namespace ChessBeast.FigureFactory.Contract
{
    using ChessBeast.IFactory;
    using ChessBeast.Models.Figures.Base;

    public interface IFigureFactory : IChessFactory<Figure>
    {
    }
}
