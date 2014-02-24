using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using PortableLeagueApi.Core.Constants;
using PortableLeagueApi.Core.Models;
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

        internal static void CreateMap(ILeagueAPI source)
        {
            Models.AggregatedStats.CreateMap(source);

            Mapper.CreateMap<string, PlayerStatsSummaryTypeEnum>()
                .ConvertUsing(s => PlayerStatsSummaryTypeConsts.PlayerStatsSummaryTypes
                    .First(x => x.Value == s).Key);

            Mapper.CreateMap<PlayerStatsSummaryListDto, IEnumerable<IPlayerStatsSummary>>()
                .ConvertUsing(x => x.PlayerStatSummaries
                    .Select(Mapper.Map<PlayerStatsSummaryDto, PlayerStatsSummary>));

            Mapper.CreateMap<PlayerStatsSummaryDto, IPlayerStatsSummary>().As<PlayerStatsSummary>();
            Mapper.CreateMap<PlayerStatsSummaryDto, PlayerStatsSummary>()
                .BeforeMap((s, d) =>
                {
                    d.Source = source;
                });
        }
    }
}
