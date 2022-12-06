namespace PetClinic.Infrastructure.Repository
{
    using Microsoft.EntityFrameworkCore;
    using PetClinic.Domain.Entities;
    using PetClinic.Interfaces;

    public class PetRepository : IPetRepository
    {
        private readonly PetClinicDbContext context;

        public PetRepository(PetClinicDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Adding a Pet type entity in the database
        /// </summary>
        /// <param name="пет">Pet type variable</param>
        /// <returns></returns>
        public async Task AddAsync(Pet pet)
        {
            await this.context.AddAsync(pet);
        }


        /// <summary>
        /// Deletes the entity by changing its IsDeleted property to true
        /// </summary>
        /// <param name="пет">Pet entity</param>
        /// <returns></returns>
        public async Task DeleteSoftAsync(Pet pet)
{
            if (!pet.IsDeleted)
{
                pet.IsDeleted = true;
                await this.SaveAsync();
            }
        }

        /// <summary>
        /// Gets a collection of Pet type entites
        /// </summary>
        /// <returns></returns>
        public async Task<ICollection<Pet>> GetAllAsync()
        {
            return await this.context
                .Pets
                .Where(pet => !pet.IsDeleted)
                .ToListAsync();
        }

        /// <summary>
        /// Gets the entity from the database by its Id
        /// </summary>
        /// <param name="id">The id of the Pet entity</param>
        /// <returns>Return the Pet entity</returns>
        public async Task<Pet> GetByIdAsync(int id)
        {
            return (await this.context.Pets.FirstOrDefaultAsync(pet => pet.Id == id))!;
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
        /// Updating the Pet entity in the database
        /// </summary>
        /// <param name="пет">Pet type variable</param>
        /// <returns></returns>
        public async Task UpdateAsync(Pet pet)
        {
            this.context.Update(pet);
        }
    }
}
