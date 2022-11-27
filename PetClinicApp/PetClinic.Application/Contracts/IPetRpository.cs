namespace PetClinic.Application.Contracts
{
    using PetClinic.Domain.Entities;

    public interface IPetRpository
    {
        void CreatePet(Pet pet);
    }
}
