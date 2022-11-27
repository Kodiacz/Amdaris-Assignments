namespace PetClinic.Infrastructure
{
    using PetClinic.Application.Contracts;
    using PetClinic.Domain.Entities;

    public class InMemoryOwnerRepository : IOwnerRepository
    {
        private readonly ICollection<Owner> _owners = new HashSet<Owner>();

        public void CreateOwner(Owner owner)
        {

        }
    }
}
