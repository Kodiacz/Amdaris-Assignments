namespace PetCare.Api.Profiles
{
    using GetOwner;
    using CreateOwner;
    using UpdateOwner;
    using DeleteOwner;

    public class OwnerProfile : Profile
    {
        public OwnerProfile()
        {
            CreateMap<Owner, GetOwnerDto>(); 
            CreateMap<UpdateOwnerDto, UpdateOwner>(); 
            CreateMap<CreateOwnerDto, CreateOwner>(); 
        }
    }
}
