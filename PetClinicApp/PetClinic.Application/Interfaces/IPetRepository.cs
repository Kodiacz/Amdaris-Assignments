namespace PetClinic.Application.Contracts
{
    using PetClinic.Domain.Entities;

    public interface IPetRepository
    {
        void CreatePet(Pet pet);
    }
}
