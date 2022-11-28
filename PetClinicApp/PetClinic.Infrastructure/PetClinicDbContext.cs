using Microsoft.EntityFrameworkCore;

namespace PetClinic.Infrastructure
{
    public class PetClinicDbContext : DbContext
    {
        protected PetClinicDbContext() : base()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
