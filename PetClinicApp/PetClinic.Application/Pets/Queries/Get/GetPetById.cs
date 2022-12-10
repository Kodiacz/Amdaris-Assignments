namespace PetClinic.Application.Pets.Queries.Get
{
    public class GetPetById : IRequest<Pet>
    {
        public int Id { get; set; }
    }
}
