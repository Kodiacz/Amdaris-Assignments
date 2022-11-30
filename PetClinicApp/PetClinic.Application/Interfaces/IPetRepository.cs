namespace PetClinic.Interfaces
{
    using PetClinic.Domain.Entities;

    public interface IPetRepository
    {
        Task AddAsync(Pet pet);

        Task UpdateAsync(Pet pet);

        Task GetByIdAsync(int id);

        Task<ICollection<Pet>> GetAllAsync();

        Task DeleteSoftAsync(Pet pet);
    }
}
