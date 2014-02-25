using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.Champion;
using PortableLeagueApi.Static.Models.DTO.Champion;

namespace PortableLeagueApi.Static.Models.Champion
{
    public class Skin : ApiModel, ISkin
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Num { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMapWithInterface<SkinDto, Skin, ISkin>();
        }
    }
}
