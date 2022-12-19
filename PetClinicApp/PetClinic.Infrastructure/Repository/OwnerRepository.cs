namespace PetClinic.Infrastructure.Repository
{
    using Microsoft.EntityFrameworkCore;
    using PetClinic.Domain.Entities;
    using PetClinic.Interfaces;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public class OwnerRepository : IOwnerRepository
    {
        private readonly PetClinicDbContext context;

        public OwnerRepository(PetClinicDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Adding a Owner type entity in the database
        /// </summary>
        /// <param name="owner">Owner type variable</param>
        /// <returns></returns>
        public async Task AddAsync(Owner owner)
        {
            await this.context.AddAsync(owner);
        }


        /// <summary>
        /// Deletes the entity by changing its IsDeleted property to true
        /// </summary>
        /// <param name="owner">Owner entity</param>
        /// <returns></returns>
        public void DeleteSoftAsync(Owner owner)
        {
            if (!owner.IsDeleted)
            {
                owner.IsDeleted = true;
            }
        }

        /// <summary>
        /// Gets a collection of Owner type entites
        /// </summary>
        /// <returns></returns>
        public async Task<List<Owner>> GetAllAsync()
        {
            return await this.context
                .Owners
                .Where(owner => !owner.IsDeleted)
                .ToListAsync();
        }

        /// <summary>
        /// Gets all the owners and accepts a predicate for sarch term
        /// </summary>
        /// <returns></returns>
        public async Task<List<Owner>> GetAllAsync(Expression<Func<Owner, bool>> search)
        {
            return await this.context
                .Owners
                .Include(owner => owner.Pets)
                .Where(search)
                .ToListAsync();
        }

        /// <summary>
        /// Gets the entity from the database by its Id
        /// </summary>
        /// <param name="id">The id of the Owner entity</param>
        /// <returns>Return the Owner entity</returns>
        public async Task<Owner> GetByIdAsync(int id)
        {
            return (await this.context.Owners
                .FirstOrDefaultAsync(owner => owner.Id == id && !owner.IsDeleted))!;
        }
        
        /// <summary>
        /// Gets the entity from the database by its Id and accepts a predicate for search term
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task<Owner> GetByIdAsync(int id, Expression<Func<Owner, bool>> search)
        {
            return (await this.context.Owners
                .Where(search)
                .FirstOrDefaultAsync(owner => owner.Id == id && !owner.IsDeleted))!;
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
        /// Updating the Owner entity in the database
        /// </summary>
        /// <param name="owner">Owner type variable</param>
        /// <returns></returns>
        public async Task UpdateAsync(Owner owner)
        {
            this.context.Update(owner);
        }
    }
}
