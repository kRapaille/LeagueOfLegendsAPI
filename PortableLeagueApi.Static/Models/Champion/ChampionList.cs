using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static.Champion;
using PortableLeagueApi.Static.Models.DTO.Champion;
using IChampion = PortableLeagueApi.Interfaces.Static.Champion.IChampion;

namespace PortableLeagueApi.Static.Models.Champion
{
    public class ChampionList : ApiModel, IChampionList
    {
        public string Type { get; set; }

        public string Format { get; set; }

        public string Version { get; set; }

        public IDictionary<string, string> Keys { get; set; }

        public IDictionary<string, IChampion> Data { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            Champion.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMapWithInterface<ChampionListDto, ChampionList, IChampionList>();
        }
    }
}