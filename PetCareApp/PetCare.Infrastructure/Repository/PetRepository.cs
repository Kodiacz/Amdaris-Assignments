namespace PetCare.Infrastructure.Repository
{
    using Microsoft.EntityFrameworkCore;
    using PetCare.Domain.Entities;
    using PetCare.Interfaces;
    using System.Linq.Expressions;

    /// <summary>
    /// This class handles Getting and Adding entities in table Pets in the database
    /// </summary>
    public class PetRepository : IPetRepository
    {
        private readonly PetCareDbContext context;

        public PetRepository(PetCareDbContext context)
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
        public void DeleteSoftAsync(Pet pet)
        {
            if (!pet.IsDeleted)
            {
                pet.IsDeleted = true;
            }
        }

        /// <summary>
        /// Gets a collection of Pet type entites
        /// </summary>
        /// <returns></returns>
        public async Task<List<Pet>> GetAllAsync()
        {
            return await this.context
                .Pets
                .Include(p => p.Owner)
                .Include(p => p.Doctor)
                .Include(p => p.Receptionist)
                .Where(pet => !pet.IsDeleted)
                .ToListAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public async Task<List<Pet>> GetAllAsync(Expression<Func<Pet, bool>> search)
        {
            //TODO: Ask if it is practical to use two Where clauses
            return await this.context
                .Pets
                .Include(p => p.Owner)
                .Include(p => p.Doctor)
                .Include(p => p.Receptionist)
                .Where(search)
                .ToListAsync();
        }

        /// <summary>
        /// Gets all the Pets and uses AsNoTracking method
        /// </summary>
        /// <returns></returns>
        public async Task<List<Pet>> GetAllAsReadOnlyAsync()
        {
            return await this.context
                .Pets
                .Include(p => p.Owner)
                .Include(p => p.Doctor)
                .Include(p => p.Receptionist)
                .AsNoTracking()
                .Where(p => !p.IsDeleted)
                .ToListAsync();
        }

        /// <summary>
        /// Gets all the Doctors and accepts a predicate for sarch term also uses
        /// AsNoTracking method
        /// </summary>
        /// <returns></returns>
        public async Task<List<Pet>> GetAllAsReadOnlyAsync(Expression<Func<Pet, bool>> search)
        {
            return await this.context
                .Pets
                .Include(p => p.Owner)
                .Include(p => p.Doctor)
                .Include(p => p.Receptionist)
                .AsNoTracking()
                .Where(search)
                .ToListAsync();
        }

        /// <summary>
        /// Gets the entity from the database by its Id and its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Pet entity</param>
        /// <returns>Return the Pet entity</returns>
        public async Task<Pet> GetByIdAsReadonlyAsync(int id)
        {
            var owner = await this.context
                .Pets
                .Include(p => p.Owner)
                .Include(p => p.Doctor)
                .Include(p => p.Receptionist)
                .AsNoTracking()
                .Where(d => d.Id == id && !d.IsDeleted)
                .FirstOrDefaultAsync();

            return owner!;
        }

        /// <summary>
        /// Gets the entity from the database by its Id and 
        /// applies predicate for where clause. Also its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Pet entity</param>
        /// <param name="search">Expression that is aplpied for the where clause</param>
        /// <returns>Return the Pet entity</returns>
        public async Task<Pet> GetByIdAsReadonlyAsync(int id, Expression<Func<Pet, bool>> search)
        {
            var owner = await this.context
                .Pets
                .Include(p => p.Owner)
                .Include(p => p.Doctor)
                .Include(p => p.Receptionist)
                .AsNoTracking()
                .Where(search)
                .FirstOrDefaultAsync(owner => owner.Id == id)!;

            return owner!;
        }

        /// <summary>
        /// Gets the entity from the database by its Id
        /// </summary>
        /// <param name="id">The id of the Pet entity</param>
        /// <returns>Return the Pet entity</returns>
        public async Task<Pet> GetByIdAsync(int id)
        {
            return (await this.context
                .Pets
                .Include(p => p.Owner)
                .Include(p => p.Doctor)
                .Include(p => p.Receptionist)
                .Where(pet => pet.Id == id && !pet.IsDeleted)
                .FirstOrDefaultAsync())!;
        }

        /// <summary>
        /// Gets the entity from the database by its Id and accepte predicate 
        /// for search term
        /// </summary>
        /// <param name="id">The id of the Pet entity</param>
        /// <returns>Return the Pet entity</returns>
        public async Task<Pet> GetByIdAsync(int id, Expression<Func<Pet, bool>> search)
        {
            return (await this.context
                .Pets
                .Include(p => p.Owner)
                .Include(p => p.Doctor)
                .Include(p => p.Receptionist)
                .Where(search)
                .FirstOrDefaultAsync(pet => pet.Id == id))!;
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
        public void Update(Pet pet)
        {
            this.context.Update(pet);
        }
    }
}
