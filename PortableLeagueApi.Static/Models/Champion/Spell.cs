using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Interfaces.Static.Champion;
using PortableLeagueApi.Static.Models.DTO.Champion;

namespace PortableLeagueApi.Static.Models.Champion
{
    public class Spell : ApiModel, ISpell
    {
        public IList<int> Cooldown { get; set; }

        public string CooldownBurn { get; set; }

        public IList<int> Cost { get; set; }

        public string CostBurn { get; set; }

        public string CostType { get; set; }

        public string Description { get; set; }

        public IList<IList<float>> Effect { get; set; }

        public IList<string> EffectBurn { get; set; }

        public string Id { get; set; }

        public IImage Image { get; set; }

        public ILevelTip Leveltip { get; set; }

        public int Maxrank { get; set; }

        public string Name { get; set; }

        public object Range { get; set; }

        public string RangeBurn { get; set; }

        public string Resource { get; set; }

        public string Tooltip { get; set; }

        public IList<ISpellVars> Vars { get; set; }
        
        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            Models.Image.CreateMap(autoMapperService);
            LevelTip.CreateMap(autoMapperService);
            SpellVars.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMapWithInterface<SpellDto, Spell, ISpell>();
        }
    }
}
