namespace ChessBeast.IFactory
{
    public interface IChessFactory<Tout> where Tout : class
    {
        Tout CreateEntity();
    }
}
