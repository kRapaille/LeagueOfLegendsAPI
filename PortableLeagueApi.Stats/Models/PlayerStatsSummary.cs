using System;
using System.Collections.Generic;
using System.Linq;
using PortableLeagueApi.Core.Constants;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Stats.Models.DTO;

namespace PortableLeagueApi.Stats.Models
{
    public class PlayerStatsSummary : ApiModel, IPlayerStatsSummary
    {
        public PlayerStatSummaryTypeEnum PlayerStatSummaryType { get; set; }
        public IAggregatedStats AggregatedStats { get; set; }
        public int Losses { get; set; }
        public DateTime ModifyDate { get; set; }
        public int Wins { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            Models.AggregatedStats.CreateMap(autoMapperService);

            autoMapperService.CreateMap<string, PlayerStatSummaryTypeEnum>()
                .ConvertUsing(s => PlayerStatsSummaryTypeConsts.PlayerStatsSummaryTypes
                    .First(x => x.Value == s).Key);

            autoMapperService.CreateMap<PlayerStatsSummaryListDto, IEnumerable<IPlayerStatsSummary>>()
                .ConvertUsing(x => x.PlayerStatSummaries
                    .Select(autoMapperService.Map<PlayerStatsSummaryDto, PlayerStatsSummary>));

            autoMapperService.CreateApiModelMap<PlayerStatsSummaryDto, IPlayerStatsSummary>().As<PlayerStatsSummary>();
            autoMapperService.CreateApiModelMap<PlayerStatsSummaryDto, PlayerStatsSummary>();
        }
    }
}
