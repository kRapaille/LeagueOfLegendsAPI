using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Interfaces.Static.Champion;
using PortableLeagueApi.Static.Models.DTO.Champion;

namespace PortableLeagueApi.Static.Models.Champion
{
    public class Champion : ApiModel, IChampion
    {
        public IList<string> AllyTips { get; set; }

        public string Blurb { get; set; }

        public IList<string> Enemytips { get; set; }

        public int Id { get; set; }

        public IImage Image { get; set; }

        public IInfo Info { get; set; }

        public string Key { get; set; }

        public string Lore { get; set; }

        public string Name { get; set; }

        public string Partype { get; set; }

        public IPassive Passive { get; set; }

        public IList<IRecommended> Recommended { get; set; }

        public IList<ISkin> Skins { get; set; }

        public IList<ISpell> Spells { get; set; }

        public IStats Stats { get; set; }

        public IList<string> Tags { get; set; }

        public string Title { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            Models.Image.CreateMap(autoMapperService);
            Models.Champion.Info.CreateMap(autoMapperService);
            Models.Champion.Passive.CreateMap(autoMapperService);
            Models.Champion.Recommended.CreateMap(autoMapperService);
            Skin.CreateMap(autoMapperService);
            Spell.CreateMap(autoMapperService);
            Models.Champion.Stats.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMapWithInterface<ChampionDto, Champion, IChampion>();
        }
    }
}
