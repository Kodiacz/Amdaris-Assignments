namespace PetCare.Interfaces
{
    using PetCare.Domain.Entities;
using System.Linq.Expressions;

    public interface IPetRepository
    {
        /// <summary>
        /// Adding a Pet type entity in the database
        /// </summary>
        /// <param name="пет">Pet type variable</param>
        /// <returns></returns>
        Task AddAsync(Pet pet);

        /// <summary>
        /// Updating the Pet entity in the database
        /// </summary>
        /// <param name="пет">Pet type variable</param>
        /// <returns></returns>
        Task UpdateAsync(Pet pet);

        /// <summary>
        /// Gets the entity from the database by its Id
        /// </summary>
        /// <param name="id">The id of the Pet entity</param>
        /// <returns>Return the Pet entity</returns>
        Task<Pet> GetByIdAsync(int id);

        /// <summary>
        /// Gets a collection of Pet type entites
        /// </summary>
        /// <returns></returns>
        Task<List<Pet>> GetAllAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        Task<List<Pet>> GetAllAsync(Expression<Func<Pet, bool>> search);

        /// <summary>
        /// Deletes the entity by changing its IsDeleted property to true
        /// </summary>
        /// <param name="пет">Pet entity</param>
        /// <returns></returns>
        void DeleteSoftAsync(Pet pet);

        /// <summary>
        /// Saves all changes that are done
        /// </summary>
        /// <returns></returns>
        Task SaveAsync();

        /// <summary>
        /// Gets all the Pets and uses AsNoTracking method
        /// </summary>
        /// <returns></returns>
        Task<List<Pet>> GetAllAsReadOnlyAsync();

        /// <summary>
        /// Gets all the Doctors and accepts a predicate for sarch term also uses
        /// AsNoTracking method
        /// </summary>
        /// <returns></returns>
        Task<List<Doctor>> GetAllAsReadOnlyAsync(Expression<Func<Doctor, bool>> search);

        /// <summary>
        /// Gets the entity from the database by its Id and its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Pet entity</param>
        /// <returns>Return the Pet entity</returns>
        Task<Pet> GetByIdAsReadonlyAsync(int id);

        /// <summary>
        /// Gets the entity from the database by its Id and 
        /// applies predicate for where clause. Also its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Pet entity</param>
        /// <param name="search">Expression that is aplpied for the where clause</param>
        /// <param name="detach">bolean that has default value false and desides if the 
        /// entity should be detached or not. True if it should be detached and false to not be detached</param>
        /// <returns>Return the Pet entity</returns>
        Task<Pet> GetByIdAsReadonlyAsync(int id, Expression<Func<Pet, bool>> search);
    }
}
