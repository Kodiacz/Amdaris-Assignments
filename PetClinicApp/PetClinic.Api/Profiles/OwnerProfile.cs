namespace PetClinic.Api.Profiles
{
    public class OwnerProfile : Profile
    {
        public OwnerProfile()
        {
            CreateMap<Owner, GetOwnerDto>(); 
        }
    }
}
