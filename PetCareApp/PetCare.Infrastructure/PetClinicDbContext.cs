namespace PetCare.Infrastructure
{
    using Microsoft.EntityFrameworkCore;
    using PetCare.Domain.Entities;
    using PetCare.Infrastructure.EntityConfigurations;

    public class PetClinicDbContext : DbContext
    {
        public PetClinicDbContext(DbContextOptions<PetClinicDbContext> options)
            : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; } = null!;

        public DbSet<Pet> Pets { get; set; } = null!;

        public DbSet<Doctor> Doctors { get; set; } = null!;

        public DbSet<Receptionist> Receptionists { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OwnerEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PetEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ReceptionsistEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorEntityTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
