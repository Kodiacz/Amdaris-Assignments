namespace PetClinic.Application.Pets.Querires
{
    public class GetPetById : IRequest<Pet>
    {
        public int Id { get; set; }
    }
}
