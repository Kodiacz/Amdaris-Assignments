namespace PetClinic.Interfaces
{
    using PetClinic.Domain.Entities;

    public interface IPetRepository
    {
        void CreatePet(Pet pet);
    }
}
