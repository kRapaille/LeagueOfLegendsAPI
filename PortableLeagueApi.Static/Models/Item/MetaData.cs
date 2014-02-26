using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.Item;
using PortableLeagueApi.Static.Models.DTO.Item;

namespace PortableLeagueApi.Static.Models.Item
{
    public class MetaData : ApiModel, IMetaData
    {
        public bool IsRune { get; set; }

        public string Tier { get; set; }

        public string Type { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMapWithInterface<MetaDataDto, MetaData, IMetaData>();
        }
    }
}
