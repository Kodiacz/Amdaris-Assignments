namespace PetCare.Interfaces
{
    public interface IDoctorRepository
    {
        /// <summary>
        /// Adds a Doctor type entity in the database
        /// </summary>
        /// <param name="doctor">Doctor type variable</param>
        /// <returns></returns>
        Task AddAsync(Doctor doctor);

        /// <summary>
        /// Updating the Doctor entity in the database
        /// </summary>
        /// <param name="doctor">Doctor type variable</param>
        /// <returns></returns>
        Task UpdateAsync(Doctor doctor);

        /// <summary>
        /// Gets the entity from the database by its Id
        /// </summary>
        /// <param name="id">The id of the Doctor entity</param>
        /// <param name="detach">bolean that has default value false and desides if the 
        /// entity should be detached or not. True if it should be detached and false to not be detached</param>
        /// <returns>Return the Doctor entity</returns>
        Task<Doctor> GetByIdAsync(int id, bool detach = false);

        /// <summary>
        /// Gets the entity from the database by its Id and 
        /// applies predicate for where clause
        /// </summary>
        /// <param name="id">The id of the Doctor entity</param>
        /// <param name="search">Expression that is aplpied for the where clause</param>
        /// <param name="detach">bolean that has default value false and desides if the 
        /// entity should be detached or not. True if it should be detached and false to not be detached</param>
        /// <returns>Return the Doctor entity</returns>
        Task<Doctor> GetByIdAsync(int id, Expression<Func<Doctor, bool>> search, bool detach = false);

        /// <summary>
        /// Gets the entity from the database by its Id and its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Doctor entity</param>
        /// <returns>Return the Doctor entity</returns>
        Task<Doctor> GetByIdAsReadonlyAsync(int id);

        /// <summary>
        /// Gets the entity from the database by its Id and 
        /// applies predicate for where clause. Also its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Doctor entity</param>
        /// <param name="search">Expression that is aplpied for the where clause</param>
        /// <param name="detach">bolean that has default value false and desides if the 
        /// entity should be detached or not. True if it should be detached and false to not be detached</param>
        /// <returns>Return the Doctor entity</returns>
        Task<Doctor> GetByIdAsReadonlyAsync(int id, Expression<Func<Doctor, bool>> search);

        /// <summary>
        /// Gets a collection of Doctor type entites
        /// </summary>
        /// <returns></returns>
        Task<List<Doctor>> GetAllAsync();

        /// <summary>
        /// Deletes the entity by changing its IsDeleted property to true
        /// </summary>
        /// <param name="doctor">Doctor entity</param>
        /// <returns></returns>
        void DeleteSoftAsync(Doctor doctor);

        /// <summary>
        /// Saves all changes that are done
        /// </summary>
        /// <returns></returns>

        /// <summary>
        /// Detaches given entity from the context
        /// </summary>
        /// <param name="entity">Entity to be detached</param>
        public void Detach(Doctor entity);

        Task SaveAsync();
    }
}
