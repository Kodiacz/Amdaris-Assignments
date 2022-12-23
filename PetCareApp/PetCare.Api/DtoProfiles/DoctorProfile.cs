namespace PetCare.Api.Profiles
{
    using GetDoctor;
    using CreateDoctor;
    using UpdateDoctor;
    using DeleteDoctor;
using PetCare.Application.Doctors.Commands.PartialUpdate;

    public class DoctorProfile : Profile
    {
        public DoctorProfile()
        {
            CreateMap<Doctor, GetDoctorDto>();
            CreateMap<Doctor, UpdateDoctorDto>();
            CreateMap<CreateDoctorDto, CreateDoctor>();
            CreateMap<UpdateDoctorDto, UpdateDoctor>();
            CreateMap<UpdateDoctorDto, PartialUpdateDoctor>();
        }
    }
}
