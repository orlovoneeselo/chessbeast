namespace ChessBeast.IFactory
{
    public interface IChessFactory<out Tout> where Tout : class
    {
        Tout CreateEntity();
    }
}
