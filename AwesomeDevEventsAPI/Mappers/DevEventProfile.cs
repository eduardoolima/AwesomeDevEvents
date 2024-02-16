using AutoMapper;
using AwesomeDevEventsAPI.Entities;
using AwesomeDevEventsAPI.Models;

namespace AwesomeDevEventsAPI.Mappers
{
    public class DevEventProfile : Profile
    {
        protected DevEventProfile()
        {
            CreateMap<DevEvent, DevEventViewModel>();
            CreateMap<DevEventSpeaker, DevEventSpeakerViewModel>();

            CreateMap<DevEventInputModel, DevEvent>();
            CreateMap<DevEventSpeakerInputModel, DevEventSpeaker>();
        }
    }
}
