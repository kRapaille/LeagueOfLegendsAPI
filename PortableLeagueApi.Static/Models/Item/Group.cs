using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.Item;
using PortableLeagueApi.Static.Models.DTO.Item;

namespace PortableLeagueApi.Static.Models.Item
{
    public class Group : ApiModel, IGroup
    {
        public string MaxGroupOwnable { get; set; }

        public string Id { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMapWithInterface<GroupDto, Group, IGroup>();
        }
    }
}
