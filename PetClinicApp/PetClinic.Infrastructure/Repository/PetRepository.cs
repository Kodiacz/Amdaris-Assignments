namespace PetClinic.Infrastructure.Repository
{
    using Microsoft.EntityFrameworkCore;
    using PetClinic.Domain.Entities;
using System.Numerics;

    public class PetRepository
    {
        private readonly PetClinicDbContext context;

        public PetRepository(PetClinicDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Pet pet)
        {
            await this.context.AddAsync(pet);
        }

        public async Task DeleteSoftAsync(Pet pet)
{
            if (!pet.IsDeleted)
{
                pet.IsDeleted = true;
                await this.SaveAsync();
            }
        }

        public async Task<ICollection<Pet>> GetAllAsync()
        {
            return await this.context
                .Pets
                .Where(pet => !pet.IsDeleted)
                .ToListAsync();
        }

        public async Task<Pet> GetByIdAsync(int id)
        {
            return (await this.context.Pets.FirstOrDefaultAsync(pet => pet.Id == id))!;
        }

        public async Task SaveAsync()
        {
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Pet pet)
        {
            this.context.Update(pet);
        }
    }
}
