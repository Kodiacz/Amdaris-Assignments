namespace PetCare.Application.Interfaces
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
        void DeleteSoftAsync(Receptionist receptionist);

        /// <summary>
        /// Saves all changes that are done
        /// </summary>
        /// <returns></returns>
        Task SaveAsync();

        /// <summary>
        /// Gets all the Receptionists and accepts a predicate for sarch term
        /// </summary>
        /// <returns></returns>
        Task<List<Receptionist>> GetAllAsync(Expression<Func<Receptionist, bool>> search);

        /// <summary>
        /// Gets all the Receptionists and uses AsNoTracking method
        /// </summary>
        /// <returns></returns>
        Task<List<Receptionist>> GetAllAsReadOnlyAsync();

        /// <summary>
        /// Gets all the Receptionists and accepts a predicate for sarch term also uses
        /// AsNoTracking method
        /// </summary>
        /// <returns></returns>
        Task<List<Receptionist>> GetAllAsReadOnlyAsync(Expression<Func<Receptionist, bool>> search);

        /// <summary>
        /// Gets the entity from the database by its Id and its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Receptionist entity</param>
        /// <returns>Return the Receptionist entity</returns>
        Task<Receptionist> GetByIdAsReadonlyAsync(int id);

        /// <summary>
        /// Gets the entity from the database by its Id and 
        /// applies predicate for where clause. Also its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Receptionist entity</param>
        /// <param name="search">Expression that is aplpied for the where clause</param>
        /// <param name="detach">bolean that has default value false and desides if the 
        /// entity should be detached or not. True if it should be detached and false to not be detached</param>
        /// <returns>Return the Receptionist entity</returns>
        Task<Receptionist> GetByIdAsReadonlyAsync(int id, Expression<Func<Receptionist, bool>> search);
    }
}
