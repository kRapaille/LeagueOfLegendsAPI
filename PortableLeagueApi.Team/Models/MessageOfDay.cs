using System;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.Team.Models.DTO;

namespace PortableLeagueApi.Team.Models
{
    public class MessageOfDay : LeagueApiModel, IMessageOfDay
    {
        public DateTime CreateDate { get; set; }

        public string Message { get; set; }

        public int Version { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService)
        {
            autoMapperService.CreateApiModelMap<MessageOfDayDto, IMessageOfDay>().As<MessageOfDay>();
            autoMapperService.CreateApiModelMap<MessageOfDayDto, MessageOfDay>();
        }
    }
}