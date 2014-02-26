using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Static.Models.DTO;

namespace PortableLeagueApi.Static.Models
{
    public class Gold : ApiModel, IGold
    {
        public int Base { get; set; }

        public bool Purchasable { get; set; }

        public int Sell { get; set; }

        public int Total { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMapWithInterface<GoldDto, Gold, IGold>();
        }
    }
}
