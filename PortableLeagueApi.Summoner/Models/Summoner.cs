using System;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Summoner.Models.DTO;

namespace PortableLeagueApi.Summoner.Models
{
    public class Summoner : LeagueApiModel, ISummoner
    {
        public long SummonerId { get; set; }

        public string Name { get; set; }

        public int ProfileIconId { get; set; }

        public DateTime RevisionDate { get; set; }

        public long SummonerLevel { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMap<SummonerDto, ISummoner>().As<Summoner>();
            autoMapperService.CreateApiModelMap<SummonerDto, Summoner>();
        }
    }
}
