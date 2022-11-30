using PetClinic.Domain.Entities;

namespace PetClinic.Application.Interfaces
{
    public interface IReceptionistRepository
    {
        Task AddAsync(Receptionist receptionist);

        Task UpdateAsync(Receptionist receptionist);

        Task GetByIdAsync(int id);

        Task<ICollection<Receptionist>> GetAllAsync();

        Task DeleteSoftAsync(Receptionist receptionist);
    }
}
