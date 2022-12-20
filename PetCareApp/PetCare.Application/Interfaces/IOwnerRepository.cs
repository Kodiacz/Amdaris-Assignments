namespace PetCare.Interfaces
{
    using PetCare.Domain.Entities;

    public interface IOwnerRepository
    {
        /// <summary>
        /// Adding a Owner type entity in the database
        /// </summary>
        /// <param name="owner">Owner type variable</param>
        /// <returns></returns>
        Task AddAsync(Owner owner);

        /// <summary>
        /// Updating the Owner entity in the database
        /// </summary>
        /// <param name="owner">Owner type variable</param>
        /// <returns></returns>
        Task UpdateAsync(Owner owner);

        /// <summary>
        /// Gets the entity from the database by its Id
        /// </summary>
        /// <param name="id">The id of the Owner entity</param>
        /// <returns>Return the Owner entity</returns>
        Task<Owner> GetByIdAsync(int id);

        /// <summary>
        /// Gets a collection of Owner type entites
        /// </summary>
        /// <returns></returns>
        Task<List<Owner>> GetAllAsync();


        /// <summary>
        /// Deletes the entity by changing its IsDeleted property to true
        /// </summary>
        /// <param name="owner">Owner entity</param>
        /// <returns></returns>
        void DeleteSoftAsync(Owner owner);

        /// <summary>
        /// Saves all changes that are done
        /// </summary>
        /// <returns></returns>
        Task SaveAsync();
    }
}
