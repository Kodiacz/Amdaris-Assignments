namespace PetCare.Api.DtoProfiles
{
    using CreateAppointments;

    public class AppointmentProfile : Profile
    {
        public AppointmentProfile()
        {
            CreateMap<CreateAppointmentDto, CreateAppointmen>();
            CreateMap<Appointment, GetAppointmentDto>()
                .ForMember(gad => gad.OwnerFullName, opt => opt.MapFrom(src => src.Owner.FirstName + " " + src.Owner.LastName));

        }
    }
}
