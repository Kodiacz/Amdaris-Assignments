namespace PetCare.Infrastructure
{
    using Microsoft.EntityFrameworkCore;
    using PetCare.Domain.Entities;
    using PetCare.Infrastructure.EntityConfigurations;

    public class PetCareDbContext : DbContext
    {
        public PetCareDbContext(DbContextOptions<PetCareDbContext> options)
            : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; } = null!;

        public DbSet<Pet> Pets { get; set; } = null!;

        public DbSet<Doctor> Doctors { get; set; } = null!;

        public DbSet<Receptionist> Receptionists { get; set; } = null!;

        public DbSet<Schedule> Schedules { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OwnerEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PetEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ReceptionsistEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ScheduleEntityTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
