using Newtonsoft.Json;

namespace PortableLeagueAPI.Champion.Models.DTO
{
    internal class ChampionListDto
    {
        [JsonProperty("champions")]
        internal ChampionDto[] Champions { get; set; }
    }

    internal class ChampionDto
    {
        [JsonProperty("botMmEnabled")]
        internal bool BotMmEnabled { get; set; }

        [JsonProperty("defenseRank")]
        internal int DefenseRank { get; set; }

        [JsonProperty("attackRank")]
        internal int AttackRank { get; set; }

        [JsonProperty("id")]
        internal int ChampionId { get; set; }

        [JsonProperty("rankedPlayEnabled")]
        internal bool RankedPlayEnabled { get; set; }

        [JsonProperty("name")]
        internal string Name { get; set; }

        [JsonProperty("botEnabled")]
        internal bool BotEnabled { get; set; }

        [JsonProperty("difficultyRank")]
        internal int DifficultyRank { get; set; }

        [JsonProperty("active")]
        internal bool Active { get; set; }

        [JsonProperty("freeToPlay")]
        internal bool FreeToPlay { get; set; }

        [JsonProperty("magicRank")]
        internal int MagicRank { get; set; }
    }
}
