namespace PetClinic.Application
{
    using PetClinic.Domain.Entities;

    public interface IOwnerRepository
    {
        void CreateOwner(Owner owner);

        void TakePetToVet(Pet pet);
    }
}
