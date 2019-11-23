using ChessBeast.BoardFactory.Contract;
using ChessBeast.Engine.BoardManager.Contract;
using ChessBeast.Models.Basis;
using ChessBeast.Models.Figures.Base;

namespace ChessBeast.Engine.BoardManager
{
    public class BoardManager : IBoardManager
    {
        private readonly IBoardFactory _boardFactory;
        public BoardManager(IBoardFactory boardFactory)
        {
            _boardFactory = boardFactory;
            Board = _boardFactory.CreateEntity();
        }
        public Board Board { get; }
        public bool MakeMove(Move move)
        {
            Board[move.CurrentPosition.X, move.CurrentPosition.Y] = null;
            Board[move.NextPosition.X, move.NextPosition.Y] = new Square(move.Figure);

            return true;
        }

    }
}
