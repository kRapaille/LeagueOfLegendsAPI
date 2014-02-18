﻿using Newtonsoft.Json;
using PortableLeagueApi.Interfaces;

namespace PortableLeagueApi.Stats.Models.Stats
{
    public class ChampionStatsDto : IChampion
    {
        /// <summary>
        /// Champion id.
        /// </summary>
        [JsonProperty("id")]
        public int ChampionId { get; set; }

        /// <summary>
        /// Aggregated stats associated with the champion.
        /// </summary>
        [JsonProperty("stats")]
        public AggregatedStatsDto Stats { get; set; }

        /// <summary>
        /// Champion name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}