using Newtonsoft.Json;
using PortableLeagueApi.Interfaces;

namespace PortableLeagueAPI.Champion.Models.Champion
{
    public class ChampionListDto
    {
        /// <summary>
        /// Gets or sets the champions.
        /// </summary>
        /// <summary>
        /// The list of champion information.
        /// </summary>
        [JsonProperty("champions")]
        public ChampionDto[] Champions { get; set; }
    }

    public class ChampionDto : IChampion
    {
        /// <summary>
        /// Bot Match Made enabled flag (for Co-op vs. AI games).
        /// </summary>
        [JsonProperty("botMmEnabled")]
        public bool BotMmEnabled { get; set; }

        /// <summary>
        /// Champion defense rank.
        /// </summary>
        [JsonProperty("defenseRank")]
        public int DefenseRank { get; set; }

        /// <summary>
        /// Champion attack rank.
        /// </summary>
        [JsonProperty("attackRank")]
        public int AttackRank { get; set; }

        /// <summary>
        /// Champion Id.
        /// </summary>
        [JsonProperty("id")]
        public int ChampionId { get; set; }

        /// <summary>
        /// Ranked play enabled flag.
        /// </summary>
        [JsonProperty("rankedPlayEnabled")]
        public bool RankedPlayEnabled { get; set; }

        /// <summary>
        /// Champion name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Bot Match Made enabled flag (for Co-op vs. AI games).
        /// </summary>
        [JsonProperty("botEnabled")]
        public bool BotEnabled { get; set; }

        /// <summary>
        /// Champion difficulty rank.
        /// </summary>
        [JsonProperty("difficultyRank")]
        public int DifficultyRank { get; set; }

        /// <summary>
        /// Indicates if the champion is active.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Indicates if the champion is free to play. Free to play champions are rotated periodically.
        /// </summary>
        [JsonProperty("freeToPlay")]
        public bool FreeToPlay { get; set; }

        /// <summary>
        /// Champion magic rank.
        /// </summary>
        [JsonProperty("magicRank")]
        public int MagicRank { get; set; }
    }
}
