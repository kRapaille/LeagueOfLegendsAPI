using Autofac;
using LeagueAPI.PCL.Interfaces;
using LeagueAPI.PCL.Services;

namespace LeagueAPI.PCL.Models.IoC
{
    public class AutoFacResolver : IResolver
    {
        private readonly IContainer _container;

        public AutoFacResolver()
        {
            var containerBuilder = new ContainerBuilder();

            Load(containerBuilder);

            _container = containerBuilder.Build();
        }

        private void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<HttpRequestService>().As<IHttpRequestService>();
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
