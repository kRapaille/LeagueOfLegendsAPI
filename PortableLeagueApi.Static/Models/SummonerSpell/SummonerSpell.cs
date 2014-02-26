using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Interfaces.Static.SummonerSpell;
using PortableLeagueApi.Static.Models.DTO.SummonerSpell;

namespace PortableLeagueApi.Static.Models.SummonerSpell
{
    public class SummonerSpell : ApiModel, ISummonerSpell
    {
        public IList<int> Cooldown { get; set; }

        public string CooldownBurn { get; set; }

        public IList<int> Cost { get; set; }

        public string CostBurn { get; set; }

        public string CostType { get; set; }

        public string Description { get; set; }

        public IList<object> Effect { get; set; }

        public IList<string> EffectBurn { get; set; }

        public string Id { get; set; }

        public IImage Image { get; set; }

        public string Key { get; set; }

        public ILevelTip Leveltip { get; set; }
        
        public int MaxRank { get; set; }

        public IList<string> Modes { get; set; }

        public string Name { get; set; }

        public int Range { get; set; }

        public string RangeBurn { get; set; }

        public string Resource { get; set; }

        public int SummonerLevel { get; set; }

        public string Tooltip { get; set; }

        public IList<ISummonerSpellVars> Vars { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            SummonerSpellVars.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMapWithInterface<SummonerSpellDto, SummonerSpell, ISummonerSpell>();
        }
    }
}
