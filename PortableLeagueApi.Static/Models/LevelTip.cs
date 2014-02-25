using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Static.Models.DTO;

namespace PortableLeagueApi.Static.Models
{
    public class LevelTip : ApiModel, ILevelTip
    {
        public IList<string> Effect { get; set; }

        public IList<string> Label { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMapWithInterface<LevelTipDto, LevelTip, ILevelTip>();
        }
    }
}
