using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.Mastery;
using PortableLeagueApi.Static.Models.DTO.Mastery;

namespace PortableLeagueApi.Static.Models.Mastery
{
    public class MasteryTree : ApiModel, IMasteryTree
    {
        public IList<object> Defense { get; set; }

        public IList<object> Offense { get; set; }

        public IList<object> Utility { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMapWithInterface<MasteryTreeDto, MasteryTree, IMasteryTree>();
        }
    }
}
