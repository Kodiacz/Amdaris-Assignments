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
            CreateMap<Pet, GetPetDto>();
        }
    }
}
