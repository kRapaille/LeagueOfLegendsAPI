﻿using Autofac;
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
            
            containerBuilder.RegisterType<HttpRequestService>().As<IHttpRequestService>();

            _container = containerBuilder.Build();
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
