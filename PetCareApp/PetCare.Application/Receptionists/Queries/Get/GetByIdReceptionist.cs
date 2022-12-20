namespace PetCare.Application.Receptionists.Queries.Get
{
    public class GetByIdReceptionist : IRequest<Receptionist>
    {
        public int Id { get; set; }
    }
}
