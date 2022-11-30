namespace PetClinic.Infrastructure.Repository
{
    using Microsoft.EntityFrameworkCore;
    using PetClinic.Domain.Entities;
    using PetClinic.Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class OwnerRepository : IOwnerRepository
    {
        private readonly PetClinicDbContext context;

        public OwnerRepository(PetClinicDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Owner owner)
        {
            await this.context.AddAsync(owner);
        }

        public async Task DeleteSoftAsync(Owner owner)
        {
            if (!owner.IsDeleted)
            {
                owner.IsDeleted = true;
                await this.SaveAsync();
            }
        }

        public async Task<ICollection<Owner>> GetAllAsync()
        {
            return await this.context
                .Owners
                .Where(owner => !owner.IsDeleted)
                .ToListAsync();
        }

        public async Task<Owner> GetByIdAsync(int id)
        {
            return (await this.context.Owners.FirstOrDefaultAsync(owner => owner.Id == id))!;
        }

        public async Task SaveAsync()
        {
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Owner owner)
        {
            this.context.Update(owner);
        }
    }
}
