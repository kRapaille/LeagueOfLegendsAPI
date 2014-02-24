using AutoMapper;
using AutoMapper.Mappers;

namespace PortableLeagueApi.Core.Services
{
    public class AutoMapperService
    {
        private readonly ConfigurationStore _configurationStore;
        private readonly MappingEngine _mappingEngine;

        internal AutoMapperService()
        {
            _configurationStore = new ConfigurationStore(new TypeMapFactory(), MapperRegistry.Mappers);
            _mappingEngine = new MappingEngine(_configurationStore);
        }

        public IMappingExpression<TSource, TDestination> CreateMap<TSource, TDestination>()
        {
            return _configurationStore.CreateMap<TSource, TDestination>();
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
