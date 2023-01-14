namespace PetCare.Interfaces
{
    using PetCare.Domain.Entities;

    public interface IScheduleRepository
    {
        /// <summary>
        /// Adds a collection of type Scheudle in the database
        /// </summary>
        /// <param name="schedules"></param>
        /// <returns></returns>
        Task AddRangeAsync(List<Schedule> schedules);

        /// <summary>
        /// Adding a Schedule type entity in the database
        /// </summary>
        /// <param name="schedule">Schedule type variable</param>
        /// <returns></returns>
        Task AddAsync(Schedule schedule);

        /// <summary>
        /// Updating the Schedule entity in the database
        /// </summary>
        /// <param name="schedule">Schedule type variable</param>
        /// <returns></returns>
        Task UpdateAsync(Schedule schedule);

        /// <summary>
        /// Gets the entity from the database by its Id
        /// </summary>
        /// <param name="id">The id of the Schedule entity</param>
        /// <returns>Return the Schedule entity</returns>
        Task<Schedule> GetByIdAsync(int id);

        /// <summary>
        /// Gets a collection of Schedule type entites
        /// </summary>
        /// <returns></returns>
        Task<List<Schedule>> GetAllAsync();

        /// <summary>
        /// Gets all the schedules and accepts a predicate for sarch term
        /// </summary>
        /// <returns></returns>
        Task<List<Schedule>> GetAllAsync(Expression<Func<Schedule, bool>> search);

        /// <summary>
        /// Gets all the Schedules and uses AsNoTracking method
        /// </summary>
        /// <returns></returns>
        Task<List<Schedule>> GetAllAsReadOnlyAsync();

        /// <summary>
        /// Saves all changes that are done
        /// </summary>
        /// <returns></returns>
        Task SaveAsync();

        /// <summary>
        /// Gets all the Schedules and accepts a predicate for sarch term also uses
        /// AsNoTracking method
        /// </summary>
        /// <returns></returns>
        Task<List<Schedule>> GetAllAsReadOnlyAsync(Expression<Func<Schedule, bool>> search);

        /// <summary>
        /// Gets the entity from the database by its Id and its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Schedule entity</param>
        /// <returns>Return the Schedule entity</returns>
        Task<Schedule> GetByIdAsReadonlyAsync(int id);

        /// <summary>
        /// Gets the entity from the database by its Id and 
        /// applies predicate for where clause. Also its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Schedule entity</param>
        /// <param name="search">Expression that is aplpied for the where clause</param>
        /// <returns>Return the Schedule entity</returns>
        Task<Schedule> GetByIdAsReadonlyAsync(int id, Expression<Func<Schedule, bool>> search);
    }
}
