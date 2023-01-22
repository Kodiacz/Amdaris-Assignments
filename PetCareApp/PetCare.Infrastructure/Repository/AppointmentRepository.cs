namespace PetCare.Infrastructure.Repository
{
    using Microsoft.EntityFrameworkCore;
    using PetCare.Domain.Entities;
    using PetCare.Interfaces;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly PetCareDbContext context;

        public AppointmentRepository(PetCareDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Adding a Appointment type entity in the database
        /// </summary>
        /// <param name="appointment">Appointment type variable</param>
        /// <returns></returns>
        public async Task AddAsync(Appointment appointment)
        {
            await this.context.AddAsync(appointment);
        }

        /// <summary>
        /// Gets a collection of Appointment type entites
        /// </summary>
        /// <returns></returns>
        public async Task<List<Appointment>> GetAllAsync()
        {
            return await this.context
                .Appointments
                .ToListAsync();
        }

        /// <summary>
        /// Gets all the appointments and accepts a predicate for sarch term
        /// </summary>
        /// <returns></returns>
        public async Task<List<Appointment>> GetAllAsync(Expression<Func<Appointment, bool>> search)
        {
            return await this.context
                .Appointments
                .Where(search)
                .ToListAsync();
        }

        /// <summary>
        /// Gets all the Appointments and uses AsNoTracking method
        /// </summary>
        /// <returns></returns>
        public async Task<List<Appointment>> GetAllAsReadOnlyAsync()
        {
            return await this.context
                .Appointments
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Gets all the Appointments and accepts a predicate for sarch term also uses
        /// AsNoTracking method
        /// </summary>
        /// <returns></returns>
        public async Task<List<Appointment>> GetAllAsReadOnlyAsync(Expression<Func<Appointment, bool>> search)
        {
            return await this.context
                .Appointments
                .AsNoTracking()
                .Where(search)
                .ToListAsync();
        }

        /// <summary>
        /// Gets the entity from the database by its Id and its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Appointment entity</param>
        /// <returns>Return the Appointment entity</returns>
        public async Task<Appointment> GetByIdAsReadonlyAsync(int id)
        {
            var appointment = await this.context
                .Appointments
                .AsNoTracking()
                .FirstOrDefaultAsync();

            return appointment!;
        }

        /// <summary>
        /// Gets the entity from the database by its Id and 
        /// applies predicate for where clause. Also its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Appointment entity</param>
        /// <param name="search">Expression that is aplpied for the where clause</param>
        /// <returns>Return the Appointment entity</returns>
        public async Task<Appointment> GetByIdAsReadonlyAsync(int id, Expression<Func<Appointment, bool>> search)
        {
            var appointment = await this.context
                .Appointments
                .AsNoTracking()
                .Where(search)
                .FirstOrDefaultAsync(appointment => appointment.Id == id)!;

            return appointment!;
        }

        /// <summary>
        /// Gets the entity from the database by its Id
        /// </summary>
        /// <param name="id">The id of the Appointment entity</param>
        /// <returns>Return the Appointment entity</returns>
        public async Task<Appointment> GetByIdAsync(int id)
        {
            return (await this.context.Appointments
                .FirstOrDefaultAsync(appointment => appointment.Id == id))!;
        }
        
        /// <summary>
        /// Gets the entity from the database by its Id and accepts a predicate for search term
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<Appointment> GetByIdAsync(int id, Expression<Func<Appointment, bool>> search)
        {
            return (await this.context.Appointments
                .Where(search)
                .FirstOrDefaultAsync(appointment => appointment.Id == id))!;
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
        /// Updating the Appointment entity in the database
        /// </summary>
        /// <param name="appointment">Appointment type variable</param>
        /// <returns></returns>
        public async Task UpdateAsync(Appointment appointment)
        {
            this.context.Update(appointment);
        }
    }
}
