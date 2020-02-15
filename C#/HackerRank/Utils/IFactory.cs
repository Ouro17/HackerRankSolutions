namespace HackerRank.Utils
{
    public interface IFactory<TEnum, T>
    {
        T GetObject(TEnum type);

        T GetObject(TEnum type, object[] paramaters);
    }
}
