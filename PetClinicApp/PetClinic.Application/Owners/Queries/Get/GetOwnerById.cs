namespace PetClinic.Application.Owners.Queries.Get
{
    public class GetOwnerById : IRequest<Owner>
    {
        public int Id { get; set; }
    }
}
