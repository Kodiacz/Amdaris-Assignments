namespace PetClinic.Infrastructure.Repository
{
    using Microsoft.EntityFrameworkCore;
    using PetClinic.Application.Interfaces;
    using PetClinic.Domain.Entities;

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
        public async Task DeleteSoftAsync(Receptionist receptionist)
        {
            if (!receptionist.IsDeleted)
            {
                receptionist.IsDeleted = true;
                await this.SaveAsync();
            }
        }

        /// <summary>
        /// Gets a collection of Receptionist type entites
        /// </summary>
        /// <returns></returns>
        public async Task<ICollection<Receptionist>> GetAllAsync()
        {
            return await this.context
                .Receptionists
                .Where(receptionist => !receptionist.IsDeleted)
                .ToListAsync();
        }

        /// <summary>
        /// Gets the entity from the database by its Id
        /// </summary>
        /// <param name="id">The id of the Receptionist entity</param>
        /// <returns>Return the Receptionist entity</returns>
        public async Task<Receptionist> GetByIdAsync(int id)
        {
            return (await this.context.Receptionists.FirstOrDefaultAsync(receptionist => receptionist.Id == id))!;
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
