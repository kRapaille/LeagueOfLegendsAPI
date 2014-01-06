namespace PortableLeagueAPI.Interfaces
{
    public interface IResolver
    {
        T Resolve<T>() where T : class;
    }
}
