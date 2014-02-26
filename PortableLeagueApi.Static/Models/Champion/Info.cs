using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.Champion;
using PortableLeagueApi.Static.Models.DTO.Champion;

namespace PortableLeagueApi.Static.Models.Champion
{
    public class Info : ApiModel, IInfo
    {
        public int Attack { get; set; }

        public int Defense { get; set; }

        public int Difficulty { get; set; }

        public int Magic { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMapWithInterface<InfoDto, Info, IInfo>();
        }
    }
}
