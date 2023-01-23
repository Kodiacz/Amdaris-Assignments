namespace PetCare.Api.DtoProfiles
{
    using CreateAppointments;

    public class AppointmentProfile : Profile
    {
        public AppointmentProfile()
        {
            CreateMap<CreateAppointmentDto, CreateAppointmen>();
            CreateMap<Appointment, GetAppointmentDto>();

        }
    }
}
