namespace PetCare.Api.Profiles
{
    using GetReceptionist;
    using CreateReceptionist;
    using UpdateReceptionist;
    using DeleteReceptionist;
    using UpdatePartialReceptionist;

    public class ReceptionistProfile : Profile
    {
        public ReceptionistProfile()
        {
            CreateMap<Receptionist, GetReceptionistDto>();
            CreateMap<Receptionist, UpdateReceptionistDto>();
            CreateMap<UpdateReceptionistDto, UpdateReceptionist>();
            CreateMap<CreateReceptionistDto, CreateReceptionist>();
            CreateMap<UpdateReceptionistDto, PartialUpdateReceptionist>();
        }
    }
}
