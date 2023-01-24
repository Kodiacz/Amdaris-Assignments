namespace PetCare.Api.Profiles
{
    using GetOwner;
    using CreateOwner;
    using UpdateOwner;
    using DeleteOwner;
    using PartialUpdateOwner;

    public class OwnerProfile : Profile
    {
        public OwnerProfile()
        {
            CreateMap<Owner, GetOwnerDto>(); 
            CreateMap<Owner, UpdateOwnerDto>(); 
            CreateMap<Owner, UpdateOwner>(); 
            CreateMap<UpdateOwnerDto, UpdateOwner>(); 
            CreateMap<CreateOwnerDto, CreateOwner>(); 
            CreateMap<UpdateOwnerDto, PartialUpdateOwner>(); 
        }
    }
}
