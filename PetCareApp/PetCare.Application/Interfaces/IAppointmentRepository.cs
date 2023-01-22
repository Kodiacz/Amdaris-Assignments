namespace PetCare.Interfaces
{
    using PetCare.Domain.Entities;

    public interface IAppointmentRepository
    {
        /// <summary>
        /// Adding a Appointment type entity in the database
        /// </summary>
        /// <param name="appointment">Appointment type variable</param>
        /// <returns></returns>
        Task AddAsync(Appointment appointment);

        /// <summary>
        /// Updating the Appointment entity in the database
        /// </summary>
        /// <param name="appointment">Appointment type variable</param>
        /// <returns></returns>
        Task UpdateAsync(Appointment appointment);

        /// <summary>
        /// Gets the entity from the database by its Id
        /// </summary>
        /// <param name="id">The id of the Appointment entity</param>
        /// <returns>Return the Appointment entity</returns>
        Task<Appointment> GetByIdAsync(int id);

        /// <summary>
        /// Gets a collection of Appointment type entites
        /// </summary>
        /// <returns></returns>
        Task<List<Appointment>> GetAllAsync();

        /// <summary>
        /// Gets all the appointments and accepts a predicate for sarch term
        /// </summary>
        /// <returns></returns>
        Task<List<Appointment>> GetAllAsync(Expression<Func<Appointment, bool>> search);

        /// <summary>
        /// Gets all the Appointments and uses AsNoTracking method
        /// </summary>
        /// <returns></returns>
        Task<List<Appointment>> GetAllAsReadOnlyAsync();

        /// <summary>
        /// Saves all changes that are done
        /// </summary>
        /// <returns></returns>
        Task SaveAsync();

        /// <summary>
        /// Gets all the Appointments and accepts a predicate for sarch term also uses
        /// AsNoTracking method
        /// </summary>
        /// <returns></returns>
        Task<List<Appointment>> GetAllAsReadOnlyAsync(Expression<Func<Appointment, bool>> search);

        /// <summary>
        /// Gets the entity from the database by its Id and its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Appointment entity</param>
        /// <returns>Return the Appointment entity</returns>
        Task<Appointment> GetByIdAsReadonlyAsync(int id);

        /// <summary>
        /// Gets the entity from the database by its Id and 
        /// applies predicate for where clause. Also its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Appointment entity</param>
        /// <param name="search">Expression that is aplpied for the where clause</param>
        /// <returns>Return the Appointment entity</returns>
        Task<Appointment> GetByIdAsReadonlyAsync(int id, Expression<Func<Appointment, bool>> search);
    }
}
