using PortableLeagueAPI.Interfaces;

namespace PortableLeagueAPI.Models.IoC
{
    public class IoC
    {
        private static IResolver _resolver;

        public static T Resolve<T>() where T : class
        {
            return _resolver.Resolve<T>();
        }

        public static void Initialize(IResolver resolver)
        {
            _resolver = resolver;
        }
    }
}
