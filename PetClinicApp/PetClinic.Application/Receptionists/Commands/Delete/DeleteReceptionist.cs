namespace PetClinic.Application.Receptionists.Commands.Delete
{
    public class DeleteReceptionist : IRequest<Receptionist>
    {
        public int Id { get; set; }
    }
}
