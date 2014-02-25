using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Static;
using PortableLeagueApi.Static.Models.DTO;

namespace PortableLeagueApi.Static.Models
{
    public class Image : ApiModel, IImage
    {
        public string Full { get; set; }

        public string Group { get; set; }

        public string Sprite { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateMap<ImageDto, Image>();
            autoMapperService.CreateMap<ImageDto, IImage>().As<Image>();
        }
    }
}
