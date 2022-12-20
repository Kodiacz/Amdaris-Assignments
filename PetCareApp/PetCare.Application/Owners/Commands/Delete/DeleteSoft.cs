namespace PetCare.Application.Owners.Commands.Delete
{
    public class DeleteSoft : IRequest<Owner>
    {
        public int Id { get; set; }
    }
}
