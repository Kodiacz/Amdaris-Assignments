namespace PetCare.Api.Profiles
{
    using GetReceptionist;
    using CreateReceptionist;
    using UpdateReceptionist;
    using DeleteReceptionist;

    public class ReceptionistProfile : Profile
    {
        public ReceptionistProfile()
        {
            CreateMap<UpdateReceptionistDto, UpdateReceptionist>();
            CreateMap<CreateReceptionistDto, CreateReceptionist>();
            CreateMap<Receptionist, GetReceptionistDto>();
        }
    }
}
