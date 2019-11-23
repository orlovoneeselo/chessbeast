namespace ChessBeast.BoardFactory
{
    using ChessBeast.BoardFactory.Contract;
    using ChessBeast.IFactory;
    using ChessBeast.Models.Basis;
    using ChessBeast.Models.Enums;
    using ChessBeast.Models.Extensions;
    using ChessBeast.Models.Figures.Base;
    using System;
    using System.Linq;

    public class BoardFactory : IBoardFactory
    {
        private const string STARTING_POSITION = "rnbqkbnr/pppppppp/PPPPPPPP/RNBQKBNR";
        private const int ROWS = 8;
        private const int COLS = 8;

        public Board CreateEntity()
        {
            return new Board(GenerateMatrix());
        }
        private Square[,] GenerateMatrix()
        {
            var matrix = new Square[ROWS, COLS];
            var args = STARTING_POSITION.Split('/');

            bool shanoLogic = false;
            for (int i = 0, s = 7; i < args.Length; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    matrix[s, j] = GetFigureBySignature(args[i][j].ToString());
                }

                if (shanoLogic)
                {
                    s -= 5;
                    shanoLogic = !shanoLogic;
                }
                else
                {
                    s--;
                    shanoLogic = !shanoLogic;
                }
            }

            return matrix;
        }

        private Square GetFigureBySignature(string ch)
        {
            FigureNames figureType = ((FigureNames[])Enum.GetValues(typeof(FigureNames)))
                          .FirstOrDefault(x => x.Description().ToLower() == ch.ToLower());

            Color color = ch[0] > 90 ? Color.White : Color.Black;

            IChessFactory<Figure> figureFactory = new FigureFactory.FigureFactory(figureType, color);
            return new Square(figureFactory.CreateEntity());
        }
    }
}
