namespace PetCare.Application.Owners.Queries.Get
{
    public class GetOwnerByIdAsReadonly : IRequest<Owner>
    {
        public int Id { get; set; }
    }
}
