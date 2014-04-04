using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Interfaces.Static.Mastery;
using PortableLeagueApi.Static.Models.DTO.Mastery;

namespace PortableLeagueApi.Static.Models.Mastery
{
    public class Mastery : ApiModel, IMastery
    {
        public int Id { get; set; }
        
        public IList<string> Description { get; set; }
        
        public IImage Image { get; set; }

        public string Name { get; set; }

        public string Prereq { get; set; }

        public int Ranks { get; set; }

        public IList<string> SanitizedDescription { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            Models.Image.CreateMap(autoMapperService);

            autoMapperService.CreateApiModelMapWithInterface<MasteryDto, Mastery, IMastery>();
        }
    }
}
