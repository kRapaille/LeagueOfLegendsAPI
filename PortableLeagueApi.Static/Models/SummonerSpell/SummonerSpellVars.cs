using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.SummonerSpell;
using PortableLeagueApi.Static.Models.DTO.SummonerSpell;

namespace PortableLeagueApi.Static.Models.SummonerSpell
{
    public class SummonerSpellVars : ApiModel, ISummonerSpellVars
    {
        public IList<float> Coeff { get; set; }

        public string Key { get; set; }

        public string Link { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMapWithInterface<SummonerSpellVarsDto, SummonerSpellVars, ISummonerSpellVars>();
        }
    }
}