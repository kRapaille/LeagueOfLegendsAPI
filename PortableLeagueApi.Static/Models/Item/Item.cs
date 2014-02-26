using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Interfaces.Static.Item;
using PortableLeagueApi.Static.Models.DTO.Item;

namespace PortableLeagueApi.Static.Models.Item
{
    public class Item : ApiModel, IItem
    {
        public string Colloq { get; set; }

        public bool ConsumeOnFull { get; set; }

        public bool Consumed { get; set; }

        public int Depth { get; set; }

        public string Description { get; set; }

        public IList<string> From { get; set; }

        public IGold Gold { get; set; }

        public string Group { get; set; }

        public bool HideFromAll { get; set; }

        public IImage Image { get; set; }

        public bool InStore { get; set; }

        public IList<string> Into { get; set; }

        public Dictionary<string, bool> Maps { get; set; }

        public string Name { get; set; }

        public string Plaintext { get; set; }

        public string RequiredChampion { get; set; }

        public IMetaData Rune { get; set; }

        public int SpecialRecipe { get; set; }

        public int Stacks { get; set; }

        public IBasicDataStats Stats { get; set; }

        public IList<string> Tags { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            Models.Gold.CreateMap(autoMapperService);
            Models.Image.CreateMap(autoMapperService);
            MetaData.CreateMap(autoMapperService);
            BasicDataStats.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMapWithInterface<ItemDto, Item, IItem>();
        }
    }
}
