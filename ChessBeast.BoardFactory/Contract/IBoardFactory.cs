using ChessBeast.IFactory;
using ChessBeast.Models.Basis;

namespace ChessBeast.BoardFactory.Contract
{
    public interface IBoardFactory : IChessFactory<Board>
    {
    }
}
