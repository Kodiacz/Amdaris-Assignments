namespace PetClinic.Infrastructure.Repository
{
    using Microsoft.EntityFrameworkCore;
    using PetClinic.Domain.Entities;

    public class ReceptionistRepositry
    {
        private readonly PetClinicDbContext context;

        public ReceptionistRepositry(PetClinicDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Receptionist receptionist)
        {
            await this.context.AddAsync(receptionist);
        }

        public async Task DeleteSoftAsync(Receptionist receptionist)
        {
            if (!receptionist.IsDeleted)
            {
                receptionist.IsDeleted = true;
                await this.SaveAsync();
            }
        }

        public async Task<ICollection<Receptionist>> GetAllAsync()
        {
            return await this.context
                .Receptionists
                .Where(receptionist => !receptionist.IsDeleted)
                .ToListAsync();
        }

        public async Task<Receptionist> GetByIdAsync(int id)
        {
            return (await this.context.Receptionists.FirstOrDefaultAsync(receptionist => receptionist.Id == id))!;
        }

        public async Task SaveAsync()
        {
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Receptionist receptionist)
        {
            this.context.Update(receptionist);
        }
    }
}
