namespace PetClinic.Application.Owners.Queries
{
    public class GetOwnerById : IRequest<Owner>
    {
        public int Id { get; set; }
    }
}
