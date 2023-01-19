namespace PetCare.Api.Profiles
{
    using GetPet;
    using CreatePet;
    using UpdatePet;
    using DeletePet;
    using UpdatePartialPet;

    public class PetProfile : Profile
    {
        public PetProfile()
        {
            CreateMap<Pet, UpdatePetDto>();
            CreateMap<Pet, GetPetDto>()
                .ForMember(gpt => gpt.OwnerFullName, opt => opt.MapFrom(src => src.Owner.FirstName + " " + src.Owner.LastName));
            CreateMap<CreatePetDto, CreatePet>();
            CreateMap<UpdatePetDto, UpdatePet>();
            CreateMap<UpdatePet, PartialUpdatePet>();
            CreateMap<Pet, UpdatePet>();
        }
    }
}
