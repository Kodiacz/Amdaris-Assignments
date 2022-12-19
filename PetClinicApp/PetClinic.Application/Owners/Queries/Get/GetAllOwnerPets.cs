namespace PetClinic.Application.Owners.Queries.Get
{
    public class GetAllOwnerPets : IRequest<List<Pet>>
    {
        public int OwnerId { get; set; }
    }
}
