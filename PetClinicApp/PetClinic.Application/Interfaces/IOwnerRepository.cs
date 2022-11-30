namespace PetClinic.Interfaces
{
    using PetClinic.Domain.Entities;

    public interface IOwnerRepository
    {
        Task AddAsync(Owner owner);

        Task UpdateAsync(Owner owner);

        Task GetByIdAsync(int id);

        Task<ICollection<Owner>> GetAllAsync();

        Task DeleteSoftAsync(Owner owner);

        Task SaveAsync();
    }
}
