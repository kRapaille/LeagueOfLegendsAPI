using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.League.Models.DTO;

namespace PortableLeagueApi.League.Models
{
    public class League : LeagueApiModel, ILeague
    {
        public IList<ILeagueItem> LeagueItems { get; set; }
        public string Name { get; set; }
        public string ParticipantId { get; set; }

        // TODO : Transform to Enum
        public string Queue { get; set; }

        // TODO : Transform to Enum
        public string Tier { get; set; }

        internal static void CreateMap(ILeagueAPI source)
        {
            LeagueItem.CreateMap(source);

            Mapper.CreateMap<LeagueDto, ILeague>().As<League>();
            Mapper.CreateMap<LeagueDto, League>()
                .BeforeMap((s, d) =>
                           {
                               d.Source = source;
                           });
        }
    }
}
