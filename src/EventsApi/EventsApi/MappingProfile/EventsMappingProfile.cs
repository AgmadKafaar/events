using AutoMapper;
using Events.Shared.Models;
using EventsApi.ViewModel;

namespace EventsApi.MappingProfile
{
    public class EventsMappingProfile : Profile
    {
        public EventsMappingProfile()
        {
            CreateMap<AttendeeDto, Attendee>()
                .ForMember(dest => dest.AttendeeType, opt => opt.MapFrom(src => new AttendeeType() { Id = (int)src.AttendeeType }))
                .ReverseMap();
            CreateMap<EventDto, Event>().ReverseMap();
        }
    }
}