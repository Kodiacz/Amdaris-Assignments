namespace PetCare.Application.Owners.Queries.Get
{
    public class GetOwnerByUsername : IRequest<Owner>
    {
        public string Username { get; set; }
    }
}
