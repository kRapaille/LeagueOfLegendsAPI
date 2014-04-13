using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Interfaces.Static.Champion;
using PortableLeagueApi.Static.Models.DTO.Champion;

namespace PortableLeagueApi.Static.Models.Champion
{
    public class Passive : ApiModel, IPassive
    {
        public string Description { get; set; }

        public string SanitizedDescription { get; set; }

        public IImage Image { get; set; }

        public string Name { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            Models.Image.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMapWithInterface<PassiveDto, Passive, IPassive>();
        }
    }
}
