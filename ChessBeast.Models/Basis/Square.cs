namespace ChessBeast.Models.Basis
{
    using ChessBeast.Models.Figures.Base;

    public class Square<T> where T : Figure
    {
        public T Figure { get; set; }
    }
}