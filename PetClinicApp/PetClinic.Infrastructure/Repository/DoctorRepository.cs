namespace PetClinic.Infrastructure.Repository
{
    using Microsoft.EntityFrameworkCore;
    using PetClinic.Domain.Entities;

    public class DoctorRepository
    {
        private readonly PetClinicDbContext context;

        public DoctorRepository(PetClinicDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Doctor doctor)
        {
            await this.context.AddAsync(doctor);
        }

        public async Task DeleteSoftAsync(Doctor doctor)
        {
            if (!doctor.IsDeleted)
            {
                doctor.IsDeleted = true;
                await this.SaveAsync();
            }
        }

        public async Task<ICollection<Doctor>> GetAllAsync()
        {
            return await this.context
                .Doctors
                .Where(doctor => !doctor.IsDeleted)
                .ToListAsync();
        }

        public async Task<Doctor> GetByIdAsync(int id)
        {
            return (await this.context.Doctors.FirstOrDefaultAsync(doctor => doctor.Id == id))!;
        }

        public async Task SaveAsync()
        {
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Doctor doctor)
        {
            this.context.Update(doctor);
        }
    }
}
