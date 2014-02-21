using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Champion
{
    public interface IChampion: IChampionId, IChampionImage, ILeagueModel
    {
        bool IsBotMatchMadeEnabled { get; set; }
        bool IsBotEnabledForCustomGames { get; set; }
        bool IsAvailableInRanked { get; set; }
        bool IsActive { get; set; }
        bool IsFreeToPlay { get; set; }
        int MagicRank { get; set; }
        int DefenseRank { get; set; }
        int AttackRank { get; set; }
        int DifficultyRank { get; set; }
    }
}