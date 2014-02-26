using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.SummonerSpell;
using PortableLeagueApi.Static.Models.DTO.SummonerSpell;

namespace PortableLeagueApi.Static.Models.SummonerSpell
{
    public class SummonerSpellList : ApiModel, ISummonerSpellList
    {
        public IDictionary<string, ISummonerSpell> Data { get; set; }

        public string Type { get; set; }

        public string Version { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            SummonerSpell.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMapWithInterface<SummonerSpellListDto, SummonerSpellList, ISummonerSpellList>();
        }
    }
}