using System.Collections.Generic;
using AutoMapper;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Interfaces.Static.Rune;
using PortableLeagueApi.Static.Models.DTO.Rune;

namespace PortableLeagueApi.Static.Models.Rune
{
    public class Rune : ApiModel, IRune
    {
        public string Colloq { get; set; }

        public bool ConsumeOnFull { get; set; }

        public bool Consumed { get; set; }

        public int Depth { get; set; }

        public string Description { get; set; }

        public IList<string> From { get; set; }

        public IGold Gold { get; set; }

        public string Group { get; set; }

        public bool HideFromAll { get; set; }
        
        public IImage Image { get; set; }

        public bool InStore { get; set; }

        public IList<string> Into { get; set; }

        public IDictionary<string, bool> Maps { get; set; }

        public string Name { get; set; }

        public object Plaintext { get; set; }

        public string RequiredChampion { get; set; }

        public IRuneType RuneType { get; set; }

        public int SpecialRecipe { get; set; }

        public int Stacks { get; set; }

        public IBasicDataStats Stats { get; set; }

        public IList<string> Tags { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            Models.Gold.CreateMap(autoMapperService);
            Models.Image.CreateMap(autoMapperService);
            Models.Rune.RuneType.CreateMap(autoMapperService);
            BasicDataStats.CreateMap(autoMapperService);

            CreateMap<Rune>(autoMapperService);
            CreateMap<IRune>(autoMapperService).As<Rune>();
        }

        private static IMappingExpression<RuneDto, T> CreateMap<T>(AutoMapperService autoMapperService)
            where T : IRune
        {
            return autoMapperService.CreateApiModelMap<RuneDto, T>()
                .ForMember(x => x.RuneType, x => x.MapFrom(z => z.Rune));
        }
    }
}
