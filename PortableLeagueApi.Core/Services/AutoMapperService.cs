using AutoMapper;
using AutoMapper.Mappers;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Core.Services
{
    public class AutoMapperService
    {
        private readonly ConfigurationStore _configurationStore;
        private readonly MappingEngine _mappingEngine;
        private readonly ILeagueApiConfiguration _apiConfiguration;

        internal AutoMapperService(ILeagueApiConfiguration apiConfiguration)
        {
            _configurationStore = new ConfigurationStore(new TypeMapFactory(), MapperRegistry.Mappers);
            _mappingEngine = new MappingEngine(_configurationStore);
            _apiConfiguration = apiConfiguration;
        }

        public void AssertConfigurationIsValid()
        {
            _configurationStore.AssertConfigurationIsValid();
        }

        public IMappingExpression<TSource, TDestination> CreateMap<TSource, TDestination>()
        {
            return _configurationStore.CreateMap<TSource, TDestination>();
        }

        public void CreateApiModelMapWithInterface<TSource, TDestination, T>()
            where T : IApiModel
            where TDestination : IApiModel, T
        {
            CreateApiModelMap<TSource, TDestination>();
            CreateApiModelMap<TSource, T>().As<TDestination>();
        }

        public IMappingExpression<TSource, TDestination> CreateApiModelMap<TSource, TDestination>()
            where TDestination : IApiModel
        {
            return CreateMap<TSource, TDestination>()
                .ForMember(x => x.ApiConfiguration, x => x.Ignore())
                .AfterMap((s, d) =>
                            {
                                d.ApiConfiguration = _apiConfiguration;
                            });
        }

        public TDestination Map<TSource, TDestination>(TSource item) 
            where TSource : class
        {
            return item == null 
                ? default(TDestination)
                : _mappingEngine.Map<TSource, TDestination>(item);
        }
    }
}
