namespace ChessBeast
{
    using System;
    using Trash;

    public class Program
    {
        public static void Main()
        {
            BoardFactory.BoardFactory boardFactory = new BoardFactory.BoardFactory();
            var board = boardFactory.CreateEntity();

            var arr = board.Matrix;

            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    var str = string.Format("{0}{1}", new object[] { arr[i, j]?.Figure?.Color.ToString(), arr[i, j]?.Figure?.Value.ToString() });
                    Console.Write(str.PadRight(15));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }


            ///////////////////////////////////////////////////////////////////////
            //
            //TicTacoToeAIExample.Start();
        }
    }
}
