using AutoMapper;
using Events.Shared.Models;
using EventsApi.ViewModel;
using System.Collections.Generic;

namespace EventsApi.MappingProfile
{
    /// <summary>
    /// The events mapping profile class
    /// </summary>
    /// <seealso cref="Profile"/>
    public class EventsMappingProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventsMappingProfile"/> class
        /// </summary>
        public EventsMappingProfile()
        {
            CreateMap<AttendeeDto, Attendee>()
                .ForMember(dest => dest.AttendeeType, opt => opt.MapFrom(src => new AttendeeType() { Id = (int)src.AttendeeType }))
                .ReverseMap();
            CreateMap<EventDto, Event>()
                .ForMember(dest => dest.Attendees, opt => opt.MapFrom(src => new List<Attendee>(2)
                {
                    new(){Id = src.DoctorAttendeeId},
                    new(){Id = src.PatientAttendeeId},
                }))
                .ReverseMap();
        }
    }
}