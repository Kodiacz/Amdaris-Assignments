namespace PetClinic.Application.Receptionists.Commands.Delete
{
    public class DeleteSoft : IRequest<Receptionist>
    {
        public int Id { get; set; }
    }
}
