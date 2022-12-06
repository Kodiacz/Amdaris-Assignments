namespace PetClinic.Api.Profiles
{
    using AutoMapper;

    using PetClinic.Domain.Entities;
    using PetClinic.Api.Dtos.DoctorDtos;
    using PetClinic.Doctors.Commands.Create;
    using PetClinic.Application.Doctors.Commands.Update;

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
