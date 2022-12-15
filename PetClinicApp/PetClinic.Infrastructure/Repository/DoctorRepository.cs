namespace PetClinic.Infrastructure.Repository
{
    using Microsoft.EntityFrameworkCore;
    using PetClinic.Domain.Entities;
    using PetClinic.Interfaces;

    public class DoctorRepository : IDoctorRepository
    {
        private readonly PetClinicDbContext context;

        public DoctorRepository(PetClinicDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Adding a Doctor type entity in the database
        /// </summary>
        /// <param name="doctor">Doctor type variable</param>
        /// <returns></returns>
        public async Task AddAsync(Doctor doctor)
        {
            await this.context.AddAsync(doctor);
        }

        /// <summary>
        /// Deletes the entity by changing its IsDeleted property to true
        /// </summary>
        /// <param name="doctor">Doctor entity</param>
        /// <returns></returns>
        public async Task DeleteSoftAsync(Doctor doctor)
        {
            if (!doctor.IsDeleted)
            {
                doctor.IsDeleted = true;
            }
        }

        /// <summary>
        /// Gets a collection of Doctor type entites
        /// </summary>
        /// <returns></returns>
        public async Task<List<Doctor>> GetAllAsync()
        {
            return await this.context
                .Doctors
                .Where(doctor => !doctor.IsDeleted)
                .ToListAsync();
        }

        /// <summary>
        /// Gets the entity from the database by its Id
        /// </summary>
        /// <param name="id">The id of the Doctor entity</param>
        /// <returns>Return the Doctor entity</returns>
        public async Task<Doctor> GetByIdAsync(int id)
        {
            return (await this.context.Doctors.FirstOrDefaultAsync(doctor => doctor.Id == id))!;
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
        /// Updating the Doctor entity in the database
        /// </summary>
        /// <param name="doctor">Doctor type variable</param>
        /// <returns></returns>
        public async Task UpdateAsync(Doctor doctor)
        {
            this.context.Update(doctor);
        }
    }
}
