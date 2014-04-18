using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.Champion;
using PortableLeagueApi.Static.Models.DTO.Champion;

namespace PortableLeagueApi.Static.Models.Champion
{
    public class SpellVars : ApiModel, ISpellVars
    {
        public IList<float> Coeff { get; set; }

        public string Dyn { get; set; }

        public string Key { get; set; }

        public string Link { get; set; }

        public string RanksWith { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMapWithInterface<SpellVarsDto, SpellVars, ISpellVars>();
        }
    }
}