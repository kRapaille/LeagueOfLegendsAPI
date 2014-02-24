using System;
using AutoMapper;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Interfaces.Core;
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

        internal static void CreateMap(ILeagueAPI source)
        {
            
            Mapper.CreateMap<SummonerDto, ISummoner>().As<Summoner>();
            Mapper.CreateMap<SummonerDto, Summoner>()
                .BeforeMap((s, d) =>
                           {
                               d.Source = source;
                           });
        }
    }
}
