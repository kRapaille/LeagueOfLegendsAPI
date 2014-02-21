using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Interfaces.Champion
{
    public interface IChampionService
    {
        Task<IEnumerable<IChampion>> GetChampionsAsync(
            bool freeToPlay,
            RegionEnum? region = null);
    }
}