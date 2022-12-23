namespace PetCare.Application.Receptionists.Queries.Get
{
    public class GetReceptionistById : IRequest<Receptionist>
    {
        public int Id { get; set; }
    }
}
