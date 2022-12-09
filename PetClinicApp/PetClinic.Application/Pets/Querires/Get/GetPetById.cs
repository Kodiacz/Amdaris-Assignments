namespace PetClinic.Application.Pets.Querires.Get
{
    public class GetPetById : IRequest<Pet>
    {
        public int Id { get; set; }
    }
}
