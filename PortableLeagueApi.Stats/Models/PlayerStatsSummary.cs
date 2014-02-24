using System;
using System.Collections.Generic;
using System.Linq;
using PortableLeagueApi.Core.Constants;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Stats;
using PortableLeagueApi.Stats.Models.DTO;

namespace PortableLeagueApi.Stats.Models
{
    public class PlayerStatsSummary : LeagueApiModel, IPlayerStatsSummary
    {
        public PlayerStatsSummaryTypeEnum PlayerStatsSummaryType { get; set; }
        public IAggregatedStats AggregatedStats { get; set; }
        public int Losses { get; set; }
        public DateTime ModifyDate { get; set; }
        public int Wins { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService, ILeagueAPI source)
        {
            Models.AggregatedStats.CreateMap(autoMapperService, source);

            autoMapperService.CreateMap<string, PlayerStatsSummaryTypeEnum>()
                .ConvertUsing(s => PlayerStatsSummaryTypeConsts.PlayerStatsSummaryTypes
                    .First(x => x.Value == s).Key);

            autoMapperService.CreateMap<PlayerStatsSummaryListDto, IEnumerable<IPlayerStatsSummary>>()
                .ConvertUsing(x => x.PlayerStatSummaries
                    .Select(autoMapperService.Map<PlayerStatsSummaryDto, PlayerStatsSummary>));

            autoMapperService.CreateMap<PlayerStatsSummaryDto, IPlayerStatsSummary>().As<PlayerStatsSummary>();
            autoMapperService.CreateMap<PlayerStatsSummaryDto, PlayerStatsSummary>()
                .BeforeMap((s, d) =>
                {
                    d.Source = source;
                });
        }
    }
}
