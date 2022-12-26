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
        /// Gets all the owners and accepts a predicate for sarch term
        /// </summary>
        /// <returns></returns>
        Task<List<Owner>> GetAllAsync(Expression<Func<Owner, bool>> search);

        /// <summary>
        /// Gets all the Owners and uses AsNoTracking method
        /// </summary>
        /// <returns></returns>
        Task<List<Owner>> GetAllAsReadOnlyAsync();

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

        /// <summary>
        /// Gets all the Owners and accepts a predicate for sarch term also uses
        /// AsNoTracking method
        /// </summary>
        /// <returns></returns>
        Task<List<Owner>> GetAllAsReadOnlyAsync(Expression<Func<Owner, bool>> search);

        /// <summary>
        /// Gets the entity from the database by its Id and its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Owner entity</param>
        /// <returns>Return the Owner entity</returns>
        Task<Owner> GetByIdAsReadonlyAsync(int id);

        /// <summary>
        /// Gets the entity from the database by its Id and 
        /// applies predicate for where clause. Also its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Owner entity</param>
        /// <param name="search">Expression that is aplpied for the where clause</param>
        /// <returns>Return the Owner entity</returns>
        Task<Owner> GetByIdAsReadonlyAsync(int id, Expression<Func<Owner, bool>> search);
    }
}
