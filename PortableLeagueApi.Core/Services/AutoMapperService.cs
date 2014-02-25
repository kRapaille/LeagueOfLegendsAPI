using AutoMapper;
using AutoMapper.Mappers;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Core.Services
{
    public class AutoMapperService
    {
        private readonly ConfigurationStore _configurationStore;
        private readonly MappingEngine _mappingEngine;
        private readonly ILeagueApiConfiguration _source;

        internal AutoMapperService(ILeagueApiConfiguration source)
        {
            _configurationStore = new ConfigurationStore(new TypeMapFactory(), MapperRegistry.Mappers);
            _mappingEngine = new MappingEngine(_configurationStore);
            _source = source;
        }

        public void AssertConfigurationIsValid()
        {
            _configurationStore.AssertConfigurationIsValid();
        }

        public IMappingExpression<TSource, TDestination> CreateMap<TSource, TDestination>()
        {
            return _configurationStore.CreateMap<TSource, TDestination>();
        }

        public IMappingExpression<TSource, TDestination> CreateApiModelMap<TSource, TDestination>()
            where TDestination : IApiModel
        {
            return _configurationStore.CreateMap<TSource, TDestination>()
                .ForMember(x => x.ApiConfiguration, x => x.Ignore())
                .AfterMap((s, d) =>
                            {
                                d.ApiConfiguration = _source;
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
