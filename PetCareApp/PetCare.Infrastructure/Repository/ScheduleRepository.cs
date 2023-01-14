namespace PetCare.Infrastructure.Repository
{
    using Microsoft.EntityFrameworkCore;
    using PetCare.Domain.Entities;
    using PetCare.Interfaces;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public class ScheduleRepository : IScheduleRepository
    {
        private readonly PetCareDbContext context;

        public ScheduleRepository(PetCareDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Adding a Schedule type entity in the database
        /// </summary>
        /// <param name="schedule">Schedule type variable</param>
        /// <returns></returns>
        public async Task AddAsync(Schedule schedule)
        {
            await this.context.AddAsync(schedule);
        }


        /// <summary>
        /// Gets a collection of Schedule type entites
        /// </summary>
        /// <returns></returns>
        public async Task<List<Schedule>> GetAllAsync()
        {
            return await this.context
                .Schedules
                .ToListAsync();
        }

        /// <summary>
        /// Gets all the schedules and accepts a predicate for sarch term
        /// </summary>
        /// <returns></returns>
        public async Task<List<Schedule>> GetAllAsync(Expression<Func<Schedule, bool>> search)
        {
            return await this.context
                .Schedules
                .Where(search)
                .ToListAsync();
        }

        /// <summary>
        /// Gets all the Schedules and uses AsNoTracking method
        /// </summary>
        /// <returns></returns>
        public async Task<List<Schedule>> GetAllAsReadOnlyAsync()
        {
            return await this.context
                .Schedules
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Gets all the Schedules and accepts a predicate for sarch term also uses
        /// AsNoTracking method
        /// </summary>
        /// <returns></returns>
        public async Task<List<Schedule>> GetAllAsReadOnlyAsync(Expression<Func<Schedule, bool>> search)
        {
            return await this.context
                .Schedules
                .AsNoTracking()
                .Where(search)
                .ToListAsync();
        }

        /// <summary>
        /// Gets the entity from the database by its Id and its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Schedule entity</param>
        /// <returns>Return the Schedule entity</returns>
        public async Task<Schedule> GetByIdAsReadonlyAsync(int id)
        {
            var schedule = await this.context
                .Schedules
                .AsNoTracking()
                .Where(d => d.Id == id)
                .FirstOrDefaultAsync();

            return schedule!;
        }

        /// <summary>
        /// Gets the entity from the database by its Id and 
        /// applies predicate for where clause. Also its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Schedule entity</param>
        /// <param name="search">Expression that is aplpied for the where clause</param>
        /// <returns>Return the Schedule entity</returns>
        public async Task<Schedule> GetByIdAsReadonlyAsync(int id, Expression<Func<Schedule, bool>> search)
        {
            var schedule = await this.context
                .Schedules
                .AsNoTracking()
                .Where(search)
                .FirstOrDefaultAsync(schedule => schedule.Id == id)!;

            return schedule!;
        }

        /// <summary>
        /// Gets the entity from the database by its Id
        /// </summary>
        /// <param name="id">The id of the Schedule entity</param>
        /// <returns>Return the Schedule entity</returns>
        public async Task<Schedule> GetByIdAsync(int id)
        {
            return (await this.context.Schedules
                .FirstOrDefaultAsync(schedule => schedule.Id == id))!;
        }
        
        /// <summary>
        /// Gets the entity from the database by its Id and accepts a predicate for search term
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<Schedule> GetByIdAsync(int id, Expression<Func<Schedule, bool>> search)
        {
            return (await this.context.Schedules
                .Where(search)
                .FirstOrDefaultAsync(schedule => schedule.Id == id))!;
        }

        /// <summary>
        /// Saves all changes that are done
        /// </summary>
        /// <returns></returns>
        public async Task SaveAsync()
        {
            await this.context.SaveChangesAsync();
        }

        /// <summary>
        /// Updating the Schedule entity in the database
        /// </summary>
        /// <param name="schedule">Schedule type variable</param>
        /// <returns></returns>
        public async Task UpdateAsync(Schedule schedule)
        {
            this.context.Update(schedule);
        }

        public async Task AddRangeAsync(List<Schedule> schedules)
        {
            await this.context.Schedules.AddRangeAsync(schedules);
        }
    }
}
