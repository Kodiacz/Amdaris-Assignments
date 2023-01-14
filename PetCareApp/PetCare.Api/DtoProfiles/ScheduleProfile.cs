namespace PetCare.Api.DtoProfiles
{
    public class ScheduleProfile : Profile
    {
        public ScheduleProfile()
        {
            CreateMap<Schedule, GetScheduleDto>()
                .ForMember(gsd => gsd.FullName, opt => opt.MapFrom(src => src.Doctor.FirstName + " " + src.Doctor.LastName));
        }
    }
}
