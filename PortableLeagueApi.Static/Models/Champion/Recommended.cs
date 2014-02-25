using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.Champion;
using PortableLeagueApi.Static.Models.DTO.Champion;

namespace PortableLeagueApi.Static.Models.Champion
{
    public class Recommended : ApiModel, IRecommended
    {
        public IBlock[] Blocks { get; set; }

        public string Champion { get; set; }

        public string Map { get; set; }

        public string Mode { get; set; }

        public bool Priority { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            Block.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMapWithInterface<RecommendedDto, Recommended, IRecommended>();
        }
    }
}
