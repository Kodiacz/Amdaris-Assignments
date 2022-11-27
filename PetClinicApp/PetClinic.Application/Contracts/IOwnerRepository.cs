namespace PetClinic.Application.Contracts
{
    using PetClinic.Domain.Entities;

    public interface IOwnerRepository
    {
        void CreateOwner(Owner owner);
    }
}
