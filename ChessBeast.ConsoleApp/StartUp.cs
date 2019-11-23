using ChessBeast.Engine.BoardManager;
using ChessBeast.Models.Basis;
using ChessBeast.Models.Basis.Common;
using ChessBeast.Models.Enums;
using ChessBeast.Models.Figures.Base;
using System;

namespace ChessBeast.ConsoleApp
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var boardFactory = new BoardFactory.BoardFactory();
            var boardManager = new BoardManager(boardFactory);

            print(boardManager.Board.Matrix);

            var str = Console.ReadLine();

            while (str != "end")
            {
                var figureChar = str[0];
                var currentRow = str[1];
                var currentCol = str[2];

                var nextRow = str[4];
                var nextCol = str[5];

                var figure = new FigureFactory.FigureFactory(figureChar, figureChar > 90 ? Color.White : Color.Black).CreateEntity();
                var currentPositon = new Position((int)char.GetNumericValue(currentRow), (int)char.GetNumericValue(currentCol));
                var nextPosition = new Position((int)char.GetNumericValue(nextRow), (int)char.GetNumericValue(nextCol));

                var move = new Move(currentPositon, nextPosition, figure);
                var result = boardManager.MakeMove(move);

                Console.Clear();
                print(boardManager.Board.Matrix);
                str = Console.ReadLine();
            }
        }
        static void print(Square[,] arr)
        {

            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                Console.Write("|");
                for (int j = 0; j < colLength; j++)
                {
                    var figure = string.Format(i + "-" + j + "-" + "{0}{1}", new object[] { arr[i, j]?.Figure?.Color.ToString(), arr[i, j]?.Figure?.Name.ToString() });
                    Console.Write("|" + figure.PadRight(15) + "|");
                }
                Console.Write("|");
                Console.Write(Environment.NewLine + Environment.NewLine);

            }
        }
    }

}
