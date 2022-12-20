namespace PetCare.Api.Profiles
{
    using GetDoctor;
    using CreateDoctor;
    using UpdateDoctor;
    using DeleteDoctor;

    public class DoctorProfile : Profile
    {
        public DoctorProfile()
        {
            CreateMap<Doctor, GetDoctorDto>();
            CreateMap<CreateDoctorDto, CreateDoctor>();
            CreateMap<UpdateDoctorDto, UpdateDoctor>();
        }
    }
}
