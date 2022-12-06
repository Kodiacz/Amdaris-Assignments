namespace PetClinic.Application.Receptionists.Queries
{
    public class GetByIdReceptionist : IRequest<Receptionist>
    {
        public int Id { get; set; }
    }
}
