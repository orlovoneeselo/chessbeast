using ChessBeast.Models.Basis;
using System;
namespace ChessBeast.Engine.BoardManager.Contract
{
    public interface IBoardManager
    {
        bool MakeMove(Move move);

    }
}