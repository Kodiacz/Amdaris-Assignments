namespace PetCare.Infrastructure.Repository
{
    using Microsoft.EntityFrameworkCore;
    using PetCare.Domain.Entities;
    using PetCare.Interfaces;
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
        /// Gets all the Owners and uses AsNoTracking method
        /// </summary>
        /// <returns></returns>
        public async Task<List<Owner>> GetAllAsReadOnlyAsync()
        {
            return await this.context
                .Owners
                .AsNoTracking()
                .Include(Owner => Owner.Pets)
                .Where(d => !d.IsDeleted)
                .ToListAsync();
        }

        /// <summary>
        /// Gets all the Owners and accepts a predicate for sarch term also uses
        /// AsNoTracking method
        /// </summary>
        /// <returns></returns>
        public async Task<List<Owner>> GetAllAsReadOnlyAsync(Expression<Func<Owner, bool>> search)
        {
            return await this.context
                .Owners
                .AsNoTracking()
                .Include(Owner => Owner.Pets)
                .Where(search)
                .ToListAsync();
        }

        /// <summary>
        /// Gets the entity from the database by its Id and its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Owner entity</param>
        /// <returns>Return the Owner entity</returns>
        public async Task<Owner> GetByIdAsReadonlyAsync(int id)
        {
            var owner = await this.context
                .Owners
                .Include(Owner => Owner.Pets)
                .AsNoTracking()
                .Where(d => d.Id == id && !d.IsDeleted)
                .FirstOrDefaultAsync();

            return owner!;
        }

        /// <summary>
        /// Gets the entity from the database by its Id and 
        /// applies predicate for where clause. Also its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Owner entity</param>
        /// <param name="search">Expression that is aplpied for the where clause</param>
        /// <returns>Return the Owner entity</returns>
        public async Task<Owner> GetByIdAsReadonlyAsync(int id, Expression<Func<Owner, bool>> search)
        {
            var owner = await this.context
                .Owners
                .Include(Owner => Owner.Pets)
                .AsNoTracking()
                .Where(search)
                .FirstOrDefaultAsync(owner => owner.Id == id)!;

            return owner!;
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
