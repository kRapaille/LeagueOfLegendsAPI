using AutoMapper;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.League.Models.DTO;

namespace PortableLeagueApi.League.Models
{
    public class MiniSeries : ApiModel, IMiniSeries
    {
        public int Losses { get; set; }
        public string Progress { get; set; }
        public int Target { get; set; }
        public int Wins { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            CreateMap<MiniSeries>(autoMapperService);
            CreateMap<IMiniSeries>(autoMapperService).As<MiniSeries>();
        }

        private static IMappingExpression<MiniSeriesDto, T> CreateMap<T>(AutoMapperService autoMapperService)
            where T : IMiniSeries
        {
            return autoMapperService.CreateApiModelMap<MiniSeriesDto, T>();
        }
    }
}
