namespace PetCare.Infrastructure.Repository
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using PetCare.Domain.Entities;
    using PetCare.Interfaces;
    using System.Linq.Expressions;

    public class DoctorRepository : IDoctorRepository
    {
        private readonly PetCareDbContext context;

        public DoctorRepository(PetCareDbContext context)
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
        public void DeleteSoftAsync(Doctor doctor)
        {
            if (!doctor.IsDeleted)
            {
                doctor.IsDeleted = true;
            }
        }

        /// <summary>
        /// Detaches given entity from the context
        /// </summary>
        /// <param name="entity">Entity to be detached</param>
        public void Detach(Doctor entity)
        {
            EntityEntry entry = this.context.Entry(entity);

            entry.State = EntityState.Detached;
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
        /// Gets all the Doctors and accepts a predicate for sarch term
        /// </summary>
        /// <returns></returns>
        public async Task<List<Doctor>> GetAllAsync(Expression<Func<Doctor, bool>> search)
        {
            return await this.context
                .Doctors
                .Include(Doctor => Doctor.Patients)
                .Include(Doctor => Doctor.OwnersOfPatients)
                .Where(search)
                .ToListAsync();
        }

        /// <summary>
        /// Gets all the Doctors and uses AsNoTracking method
        /// </summary>
        /// <returns></returns>
        public async Task<List<Doctor>> GetAllAsReadOnlyAsync()
        {
            return await this.context
                .Doctors
                .AsNoTracking()
                .Include(Doctor => Doctor.Patients)
                .Include(Doctor => Doctor.OwnersOfPatients)
                .Where(d => !d.IsDeleted)
                .ToListAsync();
        }

        /// <summary>
        /// Gets all the Doctors and accepts a predicate for sarch term also uses
        /// AsNoTracking method
        /// </summary>
        /// <returns></returns>
        public async Task<List<Doctor>> GetAllAsReadOnlyAsync(Expression<Func<Doctor, bool>> search)
        {
            return await this.context
                .Doctors
                .AsNoTracking()
                .Include(Doctor => Doctor.Patients)
                .Include(Doctor => Doctor.OwnersOfPatients)
                .Where(search)
                .ToListAsync();
        }

        /// <summary>
        /// Gets the entity from the database by its Id and its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Doctor entity</param>
        /// <returns>Return the Doctor entity</returns>
        public async Task<Doctor> GetByIdAsReadonlyAsync(int id)
        {
            var doctor = await this.context
                .Doctors
                .Include(Doctor => Doctor.Patients)
                .Include(Doctor => Doctor.OwnersOfPatients)
                .AsNoTracking()
                .Where(d => d.Id == id && !d.IsDeleted)
                .FirstOrDefaultAsync();
                
            return doctor!;
        }

        /// <summary>
        /// Gets the entity from the database by its Id and 
        /// applies predicate for where clause. Also its using AsNoTracking method
        /// </summary>
        /// <param name="id">The id of the Doctor entity</param>
        /// <param name="search">Expression that is aplpied for the where clause</param>
        /// <param name="detach">bolean that has default value false and desides if the 
        /// entity should be detached or not. True if it should be detached and false to not be detached</param>
        /// <returns>Return the Doctor entity</returns>
        public async Task<Doctor> GetByIdAsReadonlyAsync(int id, Expression<Func<Doctor, bool>> search)
        {
            var doctor = await this.context
                .Doctors
                .Include(Doctor => Doctor.Patients)
                .Include(Doctor => Doctor.OwnersOfPatients)
                .AsNoTracking()
                .Where(search)
                .FirstOrDefaultAsync(doctor => doctor.Id == id)!;

            return doctor!;
        }

        /// <summary>
        /// Gets the entity from the database by its Id
        /// </summary>
        /// <param name="id">The id of the Doctor entity</param>
        /// <returns>Return the Doctor entity</returns>
        public async Task<Doctor> GetByIdAsync(int id, bool detach = false)
        {
            var doctor = (await this.context
                .Doctors
                .Include(Doctor => Doctor.Patients)
                .Include(Doctor => Doctor.OwnersOfPatients)
                .Where(d => !d.IsDeleted && d.Id == id)
                .FirstOrDefaultAsync(doctor => doctor.Id == id))!;
            
            if (detach)
            {
                this.Detach(doctor);
            }

            return doctor;
        }

        /// <summary>
        /// Gets the entity from the database by its Id and accepts a predicate for search term
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Doctor> GetByIdAsync(int id, Expression<Func<Doctor, bool>> search, bool detach = false)
        {
            var doctor = await this.context
                .Doctors
                .Include(Doctor => Doctor.Patients)
                .Include(Doctor => Doctor.OwnersOfPatients)
                .Where(search)
                .FirstOrDefaultAsync(doctor => doctor.Id == id && !doctor.IsDeleted)!;

            if (detach)
            {
                this.Detach(doctor!);
            }

            return doctor!;
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
