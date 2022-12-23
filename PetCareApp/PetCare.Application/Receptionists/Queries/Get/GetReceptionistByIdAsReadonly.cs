namespace PetCare.Application.Receptionists.Queries.Get
{
    public class GetReceptionistByIdAsReadonly : IRequest<Receptionist>
    {
        public int Id { get; set; }
    }
}
