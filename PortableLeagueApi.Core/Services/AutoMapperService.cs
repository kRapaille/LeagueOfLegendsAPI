using AutoMapper;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Core.Services
{
    public static class AutoMapperService
    {
        public static TDestination Map<TSource, TDestination>(TSource item, ILeagueAPI source) 
            where TSource : class 
        {
            return item == null 
                ? default(TDestination) 
                : Mapper.Map<TSource, TDestination>(item);
        }
    }
}
