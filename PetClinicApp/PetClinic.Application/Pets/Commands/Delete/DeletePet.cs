namespace PetClinic.Application.Pets.Commands.Delete
{
    public class DeletePet : IRequest<Pet>
    {
        public int Id { get; set; }
    }
}
