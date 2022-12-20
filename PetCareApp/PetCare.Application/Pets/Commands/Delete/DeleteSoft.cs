namespace PetCare.Application.Pets.Commands.Delete
{
    public class DeleteSoft : IRequest<Pet>
    {
        public int Id { get; set; }
    }
}
