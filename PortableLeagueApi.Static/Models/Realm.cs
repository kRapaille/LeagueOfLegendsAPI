using System.Collections.Generic;
using AutoMapper;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Static.Models.DTO;

namespace PortableLeagueApi.Static.Models
{
    public class Realm : ApiModel, IRealm
    {
        public string BaseCdnUrl { get; set; }

        public string LatestChangedCssVersion { get; set; }

        public string LatestChangedDragonMagicVersion { get; set; }

        public string DefaultLanguage { get; set; }

        public string LegacyScript { get; set; }

        public IDictionary<string, string> LatestChangedVersionForEachDataType { get; set; }

        public int ProfileIconMax { get; set; }

        public object Store { get; set; }
        
        public string CurrentVersion { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            CreateMap<Realm>(autoMapperService);
            CreateMap<IRealm>(autoMapperService).As<Realm>();
        }

        private static IMappingExpression<RealmDto, T> CreateMap<T>(AutoMapperService autoMapperService)
            where T : IRealm
        {
            return autoMapperService.CreateApiModelMap<RealmDto, T>()
                .ForMember(x => x.BaseCdnUrl, x => x.MapFrom(z => z.Cdn))
                .ForMember(x => x.LatestChangedCssVersion, x => x.MapFrom(z => z.Css))
                .ForMember(x => x.LatestChangedDragonMagicVersion, x => x.MapFrom(z => z.Dd))
                .ForMember(x => x.DefaultLanguage, x => x.MapFrom(z => z.L))
                .ForMember(x => x.LegacyScript, x => x.MapFrom(z => z.Lg))
                .ForMember(x => x.LatestChangedVersionForEachDataType, x => x.MapFrom(z => z.N))
                .ForMember(x => x.ProfileIconMax, x => x.MapFrom(z => z.Profileiconmax))
                .ForMember(x => x.CurrentVersion, x => x.MapFrom(z => z.V));
        }
    }
}
