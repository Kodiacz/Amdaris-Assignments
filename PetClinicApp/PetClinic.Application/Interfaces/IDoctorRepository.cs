namespace PetClinic.Interfaces
{
    using PetClinic.Domain.Entities;

    public interface IDoctorRepository
    {
        Task AddAsync(Doctor doctor);

        Task UpdateAsync(Doctor doctor);

        Task GetByIdAsync(int id);

        Task<ICollection<Doctor>> GetAllAsync();

        Task DeleteSoftAsync(Doctor doctor);
    }
}
