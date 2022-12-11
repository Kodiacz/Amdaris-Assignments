namespace PetClinic.Api.Profiles
{
    using GetPet;
    using CreatePet;
    using UpdatePet;
    using DeletePet;

    public class PetProfile : Profile
    {
        public PetProfile()
        {
            CreateMap<Pet, GetPetDto>()
                .ForMember(gpt => gpt.OwnerFullName, opt => opt.MapFrom(src => src.Owner.FirstName + " " + src.Owner.LastName));
            CreateMap<CreatePetDto, CreatePet>();
        }
    }
}
