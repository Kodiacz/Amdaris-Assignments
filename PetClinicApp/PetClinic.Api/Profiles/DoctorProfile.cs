namespace PetClinic.Api.Profiles
{
    using AutoMapper;
    using PetClinic.Api.Dtos.DoctorDtos;
    using PetClinic.Domain.Entities;

    public class DoctorProfile : Profile
    {
        public DoctorProfile()
        {
            CreateMap<Doctor, GetDoctorDto>();
        }
    }
}
