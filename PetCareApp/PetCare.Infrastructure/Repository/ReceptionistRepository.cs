namespace PetCare.Infrastructure.Repository
{
    using Microsoft.EntityFrameworkCore;
    using PetCare.Application.Interfaces;
    using PetCare.Domain.Entities;
using System.Linq.Expressions;

    public class ReceptionistRepository : IReceptionistRepository
    {
        private readonly PetClinicDbContext context;

        public ReceptionistRepository(PetClinicDbContext context)
        {
            this.context = context;
        }


        /// <summary>
        /// Adding a Receptionist type entity in the database
        /// </summary>
        /// <param name="receptionist">Receptionist type variable</param>
        /// <returns></returns>
        public async Task AddAsync(Receptionist receptionist)
        {
            await this.context.AddAsync(receptionist);
        }

        /// <summary>
        /// Deletes the entity by changing its IsDeleted property to true
        /// </summary>
        /// <param name="receptionist">Receptionist entity</param>
        /// <returns></returns>
        public void DeleteSoftAsync(Receptionist receptionist)
        {
            if (!receptionist.IsDeleted)
            {
                receptionist.IsDeleted = true;
            }
        }

        /// <summary>
        /// Gets a collection of Receptionist type entites
        /// </summary>
        /// <returns></returns>
        public async Task<List<Receptionist>> GetAllAsync()
        {
            return await this.context
                .Receptionists
                .Where(receptionist => !receptionist.IsDeleted)
                .ToListAsync();
        }

        /// <summary>
        /// Gets all the Receptionists and accepts a predicate for sarch term
        /// </summary>
        /// <returns></returns>
        public async Task<List<Receptionist>> GetAllAsync(Expression<Func<Receptionist, bool>> search)
        {
            return await this.context
                .Receptionists
                .Include(receptionist => receptionist.Patients)
                .Include(receptionist => receptionist.OwnersOfPatients)
                .Where(search)
                .ToListAsync();
        }

        /// <summary>
        /// Gets the entity from the database by its Id
        /// </summary>
        /// <param name="id">The id of the Receptionist entity</param>
        /// <returns>Return the Receptionist entity</returns>
        public async Task<Receptionist> GetByIdAsync(int id)
        {
            return (await this.context.Receptionists
                .FirstOrDefaultAsync(receptionist => receptionist.Id == id))!;
        }

        /// <summary>
        /// Gets the entity from the database by its Id and accepts a predicate for search term
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Receptionist> GetByIdAsync(int id, Expression<Func<Receptionist, bool>> search)
        {
            return (await this.context.Receptionists
                .Where(search)
                .FirstOrDefaultAsync(receptionist => receptionist.Id == id && !receptionist.IsDeleted))!;
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
        /// Updating the Receptionist entity in the database
        /// </summary>
        /// <param name="receptionist">Receptionist type variable</param>
        /// <returns></returns>
        public async Task UpdateAsync(Receptionist receptionist)
        {
            this.context.Update(receptionist);
        }
    }
}
