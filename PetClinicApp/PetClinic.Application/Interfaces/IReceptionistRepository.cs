using PetClinic.Domain.Entities;

namespace PetClinic.Application.Interfaces
{
    public interface IReceptionistRepository
    {
        /// <summary>
        /// Adding a Receptionist type entity in the database
        /// </summary>
        /// <param name="receptionist">Receptionist type variable</param>
        /// <returns></returns>
        Task AddAsync(Receptionist receptionist);

        /// <summary>
        /// Updating the Receptionist entity in the database
        /// </summary>
        /// <param name="receptionist">Receptionist type variable</param>
        /// <returns></returns>
        Task UpdateAsync(Receptionist receptionist);

        /// <summary>
        /// Gets the entity from the database by its Id
        /// </summary>
        /// <param name="id">The id of the Receptionist entity</param>
        /// <returns>Return the Receptionist entity</returns>
        Task<Receptionist> GetByIdAsync(int id);

        /// <summary>
        /// Gets a collection of Receptionist type entites
        /// </summary>
        /// <returns></returns>
        Task<List<Receptionist>> GetAllAsync();

        /// <summary>
        /// Deletes the entity by changing its IsDeleted property to true
        /// </summary>
        /// <param name="receptionist">Receptionist entity</param>
        /// <returns></returns>
        Task DeleteSoftAsync(Receptionist receptionist);

        /// <summary>
        /// Saves all changes that are done
        /// </summary>
        /// <returns></returns>
        Task SaveAsync();
    }
}
