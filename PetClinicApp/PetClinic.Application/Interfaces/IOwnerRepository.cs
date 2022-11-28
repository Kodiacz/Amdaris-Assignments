namespace PetClinic.Interfaces
{
    using PetClinic.Domain.Entities;

    public interface IOwnerRepository
    {
        void CreateOwner(Owner owner);
    }
}
