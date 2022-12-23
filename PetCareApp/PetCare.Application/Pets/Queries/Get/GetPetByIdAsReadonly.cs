namespace PetCare.Application.Pets.Queries.Get
{
    public class GetPetByIdAsReadonly : IRequest<Pet>
    {
        public int Id { get; set; }
    }
}
